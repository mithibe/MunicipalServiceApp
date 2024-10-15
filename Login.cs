using System;
using System.Collections.Generic;
using System.IO; // Ensure this is included for file operations
using System.Windows.Forms;

namespace SAMSA
{
    public partial class Login : UserControl
    {
        // Dictionary to hold users (username as key and User object as value)
        private Dictionary<string, User> userDictionary = new Dictionary<string, User>();
        private bool isRegisterMode = false; // To toggle between login and register modes
        public event EventHandler<User> LoginSuccessful; // Event to signal successful login

        public Login()
        {
            InitializeComponent();
            LoadUsers(); // Load users from the text file on initialization
            ToggleMode();
        }

        // Method to toggle between login and Register mode
        private void ToggleMode()
        {
            if (isRegisterMode)
            {
                lblConfirmPassword.Visible = true;
                txtConfirmPassword.Visible = true;
                lblRole.Visible = true;
                cboRole.Visible = true;
                btnLogin.Visible = false;
                btnRegister.Visible = true;
                btnToggleLoginRegister.Text = "Switch to Login";
            }
            else
            {
                lblConfirmPassword.Visible = false;
                txtConfirmPassword.Visible = false;
                lblRole.Visible = false;
                cboRole.Visible = false;
                btnLogin.Visible = true;
                btnRegister.Visible = false;
                btnToggleLoginRegister.Text = "Switch to Register";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            try
            {
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                    throw new Exception("Username and Password cannot be empty!");

                if (userDictionary.ContainsKey(username))
                {
                    User user = userDictionary[username];
                    if (user.Password == password)
                    {
                        MessageBox.Show($"Login successful! Welcome, {user.Username} ({user.Role})");
                        // Continue to local events and announcements 

                    }
                    else
                    {
                        MessageBox.Show("Incorrect password.");
                    }
                }
                else
                {
                    MessageBox.Show("User does not exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadUsers()
        {
            if (File.Exists("users.txt"))
            {
                string[] lines = File.ReadAllLines("users.txt");
                foreach (string line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        // Add user to dictionary
                        User user = new User(parts[0], parts[1], parts[2]);
                        userDictionary[parts[0]] = user; // Username as key
                    }
                }
            }
        }

        private void btnToggleLoginRegister_Click(object sender, EventArgs e)
        {
            isRegisterMode = !isRegisterMode;
            ToggleMode();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();
            string role = cboRole.SelectedItem?.ToString();

            try
            {
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(role))
                    throw new Exception("All fields are required!");

                if (password != confirmPassword)
                    throw new Exception("Passwords do not match!");

                if (userDictionary.ContainsKey(username))
                    throw new Exception("User already exists!");

                // Register the user
                User newUser = new User(username, password, role);
                userDictionary[username] = newUser; // Add user to dictionary
                SaveUser(newUser); // Save to file
                MessageBox.Show("Registration successful!");

                // Switch back to login mode after registration
                isRegisterMode = false;
                ToggleMode();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Method to save a new user to the text file
        private void SaveUser(User user)
        {
            string userData = $"{user.Username},{user.Password},{user.Role}";
            File.AppendAllText("users.txt", userData + Environment.NewLine); // Correct method call
        }
    }
    
}
