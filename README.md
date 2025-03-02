# Employee Management System

## Project Overview
This is an **ASP.NET Core MVC** app for managing employee records. It supports **Create, Read, Update, and Delete (CRUD)** operations and uses **Entity Framework Core** for database interaction.

## Features
- Add new employees
- View employee details
- Update employee info
- Delete employee records
- Uses **Entity Framework Core** for database access
- Follows **MVC architecture**

## Technologies Used
- **ASP.NET Core MVC**
- **Entity Framework Core (EF Core)**
- **SQL Server** (or your configured database)
- **Bootstrap** (for UI)
- **GitHub & SourceTree** (for version control)

## Getting Started

### 1. Clone the Repo
```bash
git clone https://github.com/YOUR_GITHUB_USERNAME/EmployeeManagement.git
cd EmployeeManagement

###2. Setup Database
Make sure you have SQL Server installed. Update the connection string in appsettings.json:

json
نسخ
تحرير
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=EmployeeDB;Trusted_Connection=True;"
}
###3. Run Migrations
bash
نسخ
تحرير
dotnet ef migrations add InitialCreate
dotnet ef database update
###4. Run the App
bash
نسخ
تحرير
dotnet run
Then open http://localhost:5000 in your browser.
