using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAMSA
{
    public partial class LocalEventsForm : Form
    {

        private void LocalEventsForm_Load(object sender, EventArgs e)
        {
            // Add some sample events on form load
            AddEvent(new Event("Community Clean-Up", "Sanitation", DateTime.Today));
            AddEvent(new Event("Road Repair Notice", "Roads", DateTime.Today.AddDays(1)));
            AddEvent(new Event("Electricity Outage", "Utilities", DateTime.Today.AddDays(2)));

            DisplayEvents();
        }


        // Data Structures
        private SortedDictionary<DateTime, List<Event>> eventsDictionary = new SortedDictionary<DateTime, List<Event>>();
        private Queue<string> searchHistory = new Queue<string>();
        private HashSet<string> eventCategories = new HashSet<string>();
        private int maxHistory = 5; // Limit for search history queue

        public LocalEventsForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(LocalEventsForm_Load); // Attach the Load event
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Get the search term from textbox
            string searchTerm = txtSearch.Text;

            // Get the selected category from the ComboBox if no category is selected, pass an empty string)
            string selectedCategory = cboCategory.SelectedItem != null ? cboCategory.SelectedItem.ToString() : string.Empty;

            // Get the selected date from the DateTimePicker
            DateTime selectedDate = dtpEventDate.Value.Date;

            // Call the SearchEvents method with all three parameters
            SearchEvents(searchTerm, selectedCategory, selectedDate);

            // Optionally: Add the search term to search history, refresh recommendations, etc.
            AddToSearchHistory(searchTerm);
            DisplayRecommendations();
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mainForm = new MainForm();
            mainForm.Show();
        }

        // Method to add an event to the dictionary and update the UI
        private void AddEvent(Event newEvent)
        {
            if (!eventsDictionary.ContainsKey(newEvent.Date))
            {
                eventsDictionary[newEvent.Date] = new List<Event>();
            }
            eventsDictionary[newEvent.Date].Add(newEvent);

            // Add category to HashSet
            eventCategories.Add(newEvent.Category);

            // Refresh the ComboBox with unique categories
            PopulateCategoryComboBox();
        }

        // Mehod to populate ComboBox with unique categories
        private void PopulateCategoryComboBox()
        {
            cboCategory.Items.Clear();
            foreach (var category in eventCategories)
            {
                cboCategory.Items.Add(category);
            }
        }

        // Method to display events in the ListView
        private void DisplayEvents()
        {
            lstViewEvents.Items.Clear(); // Clear existing items

            foreach (var date in eventsDictionary.Keys)
            {
                foreach (var ev in eventsDictionary[date])
                {
                    ListViewItem item = new ListViewItem(ev.Date.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(ev.Name);
                    item.SubItems.Add(ev.Category);
                    item.SubItems.Add(ev.Category);
                    lstViewEvents.Items.Add(item);
                }
            }
        }

        // Method to add search terms to history and limit size of Queue
        private void AddToSearchHistory(string searchTerm)
        {
            if (searchHistory.Count >= maxHistory)
            {
                searchHistory.Dequeue(); // Remove the oldest search term
            }
            searchHistory.Enqueue(searchTerm); // Add the new search term
        }

        //Method to display recommendations based on search history
        private void DisplayRecommendations()
        {
            lstRecommendations.Items.Clear();

            foreach (var searchTerm in searchHistory)
            {
                foreach (var date in eventsDictionary.Keys)
                {
                    foreach (var ev in eventsDictionary[date])
                    {
                        // Use IndexOf to perform a case-insensitive search
                        if (ev.Category.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
                            ev.Name.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            // Add matching events to the recommendations list
                            lstRecommendations.Items.Add(ev.Name + " _ " + ev.Date.ToString("dd/MM/yyyy"));
                        }
                    }
                }
            }
        }


        // Search method: search events based on term, category and date
        private void SearchEvents(string searchTerm, string category, DateTime date)
        {
            lstViewEvents.Items.Clear(); // Clear the ListView

            foreach (var dateKey in eventsDictionary.Keys)
            {
                foreach (var ev in eventsDictionary[dateKey])
                {
                    // Check if the event matches the search term, category, and date
                    if ((string.IsNullOrEmpty(searchTerm) || ev.Name.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0) &&
                        (string.IsNullOrEmpty(category) || ev.Category == category) &&
                        (date == DateTime.MinValue || ev.Date.Date == date.Date))
                    {
                        // Add matching events to the ListView
                        ListViewItem item = new ListViewItem(ev.Date.ToString("dd/MM/yyyy"));
                        item.SubItems.Add(ev.Name);
                        item.SubItems.Add(ev.Category);
                        lstViewEvents.Items.Add(item);
                    }
                }
            }
        }

    }
}
