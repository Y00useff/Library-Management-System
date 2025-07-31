# Library Management System

## Overview

This project is a Windows Forms application developed in C# that functions as a Library Management System. It provides functionalities for managing library resources, including books, members, and borrowing/returning processes. The application interacts with a database to store and retrieve information.

## Features

- **User Authentication**: Secure login and registration for different user roles (e.g., librarians, members).
- **Book Management**: Add, update, delete, and search for books in the library catalog.
- **Member Management**: Register new members, update member details, and view member history.
- **Borrowing/Returning System**: Facilitate the borrowing and returning of books, including tracking due dates and penalties.
- **Intuitive User Interface**: A user-friendly graphical interface built with Windows Forms.

## Technologies Used

- **C#**: The primary programming language for the application logic.
- **Windows Forms**: For building the graphical user interface.
- **ADO.NET**: For connecting to and interacting with the database.
- **SQL Server / SQLite**: (Assumed based on common C# database practices; specific database details might be in connection strings within the code.) The project likely uses a relational database for data storage.

## Project Structure

- `MyWinFormsApp.sln`: The main solution file for the Visual Studio project.
- `MyWinFormsApp.csproj`: The project file for the main Windows Forms application.
- `LibraryApp/`: (If this is a separate project within the solution) Contains components or modules related to library functionalities.
- `Form1.cs`, `LoginForm.cs`, `RegisterForm.cs`, `MemberRegisterForm.cs`: C# source files for various forms and their functionalities.
- `Program.cs`: The entry point of the application.

## Installation and Setup

To set up and run this project, you will need Visual Studio with the .NET desktop development workload installed.

1. **Clone the repository:**
   ```bash
   git clone <repository_url>
   cd MyWinFormsApp
   ```
2. **Open the solution:**
   Open `MyWinFormsApp.sln` in Visual Studio.
3. **Database Configuration:**
   - The application is designed to connect to a database. You may need to configure the database connection string within the application's code (e.g., in `App.config` or directly in the C# files handling database connections).
   - If using SQL Server, ensure SQL Server is installed and accessible. Create the necessary database and tables as per the application's schema (schema details are typically found in SQL scripts or ORM migrations if available, otherwise derived from the application's data access layer).
   - If using SQLite, the database file might be included in the project or created upon first run.
4. **Build the project:**
   In Visual Studio, build the solution to restore NuGet packages and compile the code.

## Usage

1. **Run the application:**
   After building, you can run the application directly from Visual Studio by pressing `F5` or clicking the 


Start button.
2. **Login/Register:**
   Upon launching, you will likely be presented with a login or registration form. Create a new account or use existing credentials to access the system.
3. **Explore Features:**
   Navigate through the application to explore its various features, such as managing books, members, and borrowing records.

## Contributing

Contributions are welcome! If you have suggestions for improvements or find any issues, please feel free to open an issue or submit a pull request.

## License

This project is open-source and available under the [MIT License](LICENSE).

