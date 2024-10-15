# SAMSA

This project is a Windows Forms Application built in C# for managing municipal services, including features for local events and announcements, user registration, and login with roles.

## Features
- **User Login**: Sign in as a user or employee, with validation and role-based access control.
- **User Registration**: Register new users with validation for passwords and roles.
- **Search Functionality**: Search for local events based on name, category, and date.
- **Event Recommendations**: Recommendations based on past searches.
- **Local Events Management**: Display and search through upcoming local events and announcements.

## Requirements
- **Visual Studio 2022** or later
- **.NET Framework 4.8** or higher

## Project Setup

### Step 1: Download and extract
1. Download and Extract the zip file into a folder

### Step 2: Open the Project in Visual Studio
1. Launch **Visual Studio 2022** (or later).
2. Open the solution file:
   - Navigate to the folder where you unzipped the project.
   - Open the `.sln` file (e.g., `MunicipalServicesApp.sln`) by double-clicking it.

### Step 3: Build the Project
1. In Visual Studio, from the **Solution Explorer**, right-click the solution and select **Build Solution** (or press `Ctrl+Shift+B`).
2. Ensure that there are no build errors before proceeding to run the application.

### Step 4: Run the Application
1. In Visual Studio, press `F5` or click the **Start** button to run the application.
2. The login screen will appear by default.

## How to Use the Application

### Login
1. **Enter Username**: Enter your registered username in the "Username" field.
2. **Enter Password**: Enter your password in the "Password" field.
3. **Click 'Login'**: If the credentials are correct, you will be logged in and redirected to the main form.

### Register a New User
1. **Switch to Register Mode**: Click the "Switch to Register" button to open the registration form.
2. **Enter Registration Details**:
   - Enter a **Username**, **Password**, **Confirm Password**, and **Role**.
   - Roles can be "User" or "Employee".
3. **Click 'Register'**: If registration is successful, the system will save the new user to a file and switch back to login mode.

### Search Local Events
1. Navigate to the "Local Events and Announcements" section after login.
2. Enter a **search term**, choose a **category**, or select a **date** to search for specific events.
3. The results will be displayed in a list format. You can click on any event to see more details.

### Important Files:
- **users.txt**: Stores the list of registered users.
- **events.txt**: Stores event information for local events and announcements.

## Additional Notes

- **Data Storage**: User data and event data are stored locally in plain text files (`users.txt` and `events.txt`).
- **User Roles**: Currently supports two roles:
  - **User**: General access for local citizens.
  - **Employee**: Employees have access to additional features (if applicable).
  
Make sure these text files are present in the project directory for proper functionality.

## Error Handling and Validation
- The application includes basic validation for empty fields and password matching during registration.
- Exceptions are handled with error messages displayed in `MessageBox` dialogs.

## Troubleshooting
- **Login Fails**: Ensure the username and password match exactly what was entered during registration.
- **File Not Found Errors**: Ensure `users.txt` and `events.txt` are present in the directory where the `.exe` file is run.