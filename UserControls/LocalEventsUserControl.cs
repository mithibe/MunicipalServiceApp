using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO; // To handle file operations
using System.Linq;
using System.Windows.Forms;

namespace SAMSA
{
    public partial class LocalEventsUserControl : UserControl
    {
        // Data Structures
        private SortedDictionary<DateTime, List<EventOrAnnouncement>> eventsDictionary = new SortedDictionary<DateTime, List<EventOrAnnouncement>>();
        private Queue<string> searchHistory = new Queue<string>();
        private HashSet<string> eventCategories = new HashSet<string>();
        private int maxHistory = 5; // Limit for search history queue

        public LocalEventsUserControl()
        {
            InitializeComponent();

            // Enable full row selection and disable multi-selection
            lstViewEvents.FullRowSelect = true; // Select the entire row
            lstViewEvents.MultiSelect = false; // Only allow one item to be selected at a time

            lstViewEvents.SelectedIndexChanged += lstViewEvents_SelectedIndexChanged; // Attach the selection changed event

            this.Load += new EventHandler(LocalEventsUserControl_Load); // Attach the Load event
        }

        private void LocalEventsUserControl_Load(object sender, EventArgs e)
        {
            // Load events from file
            LoadEvents();

            // Add some sample events if the file is empty
            if (eventsDictionary.Count == 0)
            {
                AddEventOrAnnouncement(new EventOrAnnouncement("Community Clean-Up", "Sanitation", DateTime.Today, "event", "cleanup.jpg"));
                AddEventOrAnnouncement(new EventOrAnnouncement("Road Repair Notice", "Roads", DateTime.Today.AddDays(1), "announcement", "road_repair.jpg"));
                AddEventOrAnnouncement(new EventOrAnnouncement("Electricity Outage", "Utilities", DateTime.Today.AddDays(2), "event", "outage.jpg"));
            }

            DisplayEventsOrAnnouncements();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Get the search term from textbox
            string searchTerm = txtSearch.Text;

            // Get the selected category from the ComboBox (if no category is selected, pass an empty string)
            string selectedCategory = cboCategory.SelectedItem != null ? cboCategory.SelectedItem.ToString() : string.Empty;

            // Get the selected date from the DateTimePicker
            DateTime selectedDate = dtpEventDate.Value.Date;

            // Call the SearchEvents method with all three parameters
            SearchEvents(searchTerm, selectedCategory, selectedDate);

            // Optionally: Add the search term to search history, refresh recommendations, etc.
            AddToSearchHistory(searchTerm);
            DisplayRecommendations();
        }

        // Method to add an event to the dictionary and update the UI
        private void AddEventOrAnnouncement(EventOrAnnouncement newEntry)
        {
            if (!eventsDictionary.ContainsKey(newEntry.Date))
            {
                eventsDictionary[newEntry.Date] = new List<EventOrAnnouncement>();
            }
            eventsDictionary[newEntry.Date].Add(newEntry);

            // Save the event to the file
            SaveEvent(newEntry);

            // Add category to HashSet
            eventCategories.Add(newEntry.Category);

            // Refresh the ComboBox with unique categories
            PopulateCategoryComboBox();
        }

        // Method to populate ComboBox with unique categories
        private void PopulateCategoryComboBox()
        {
            cboCategory.Items.Clear();
            cboCategory.Items.Add("All"); // Add "All" option to display all events

            foreach (var category in eventCategories)
            {
                cboCategory.Items.Add(category);
            }

            // Optionally set "All" as the default selection
            cboCategory.SelectedIndex = 0; //This selects "All" by default
        }

        // Method to display events in the ListView
        private void DisplayEventsOrAnnouncements()
        {
            lstViewEvents.Items.Clear(); // Clear existing items

            foreach (var date in eventsDictionary.Keys)
            {
                foreach (var entry in eventsDictionary[date])
                {
                    ListViewItem item = new ListViewItem(entry.Date.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(entry.Name);
                    item.SubItems.Add(entry.Category);
                    item.SubItems.Add(entry.Type);
                    lstViewEvents.Items.Add(item);
                }
            }
        }

        // Method to add search terms to history and limit the size of the Queue
        private void AddToSearchHistory(string searchTerm)
        {
            if (searchHistory.Count >= maxHistory)
            {
                searchHistory.Dequeue(); // Remove the oldest search term
            }
            searchHistory.Enqueue(searchTerm); // Add the new search term
        }

        // Method to display recommendations based on search history
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

        private void lstViewEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstViewEvents.SelectedItems.Count > 0)
            {
                // Get the selected item
                ListViewItem selectedItem = lstViewEvents.SelectedItems[0];

                // Extract the name and type
                string name = selectedItem.SubItems[1].Text; // Name is in column 1
                string type = selectedItem.SubItems[3].Text; // Type is in column 3

                // Display the image related to the selected event or announcement
                DisplayImageForSelectedItem(type, name);
            }
        }

        private void DisplayImageForSelectedItem(string type, string name)
        {
            string imagePath = "";

            // Check if the image exists for the event or announcement
            if (type == "event")
            {
                // Path to your event images
                imagePath = Path.Combine("Images", "Events", name + ".jpg");
            }
            else if (type == "announcement")
            {
                // Path to your announcement images
                imagePath = Path.Combine("Images", "Announcements", name + ".jpg");
            }

            // Check if the file exists, then load the image
            if (File.Exists(imagePath))
            {
                pictureBox.Image = Image.FromFile(imagePath);
            }
            else
            {
                pictureBox.Image = null; // Clear the image if no image exists
            }
        }

        // Search method: search events based on term, category, and date
        private void SearchEvents(string searchTerm, string category, DateTime date)
        {
            lstViewEvents.Items.Clear(); // Clear the ListView

            foreach (var dateKey in eventsDictionary.Keys)
            {
                foreach (var entry in eventsDictionary[dateKey])
                {
                    bool matchesCategory = category == "All" || entry.Category == category;
                    bool matchesSearchTerm = string.IsNullOrEmpty(searchTerm) || entry.Name.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0;
                    bool matchesDate = date == DateTime.MinValue || entry.Date.Date == date.Date;

                    // Check if the event matches the search term, category, and date
                    if (matchesCategory && matchesSearchTerm && matchesDate)
                    {
                        // Add matching events to the ListView
                        ListViewItem item = new ListViewItem(entry.Date.ToString("dd/MM/yyyy"));
                        item.SubItems.Add(entry.Name);
                        item.SubItems.Add(entry.Category);
                        item.SubItems.Add(entry.Type);
                        lstViewEvents.Items.Add(item);
                    }
                }
            }
        }

        // Method to save events to a text file
        private void SaveEvent(EventOrAnnouncement evt)
        {
            string eventData = $"{evt.Name},{evt.Category},{evt.Date.ToShortDateString()},{evt.Type},{evt.ImagePath}";
            File.AppendAllText("events.txt", eventData + Environment.NewLine);
        }

        // Method to load events from a text file
        private void LoadEvents()
        {
            if (File.Exists("events.txt"))
            {
                var lines = File.ReadAllLines("events.txt");
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 5)
                    {
                        string eventName = parts[0].Trim();
                        string category = parts[1].Trim();
                        DateTime date = DateTime.Parse(parts[2].Trim());
                        string type = parts[3].Trim();
                        string imagePath = parts[4].Trim();

                        // Create a LocalEvent object and add it to the event list
                        EventOrAnnouncement evt = new EventOrAnnouncement(eventName, category, date, type, imagePath);
                        AddEventOrAnnouncement(evt);
                    }
                }
            }
        }
    }
}