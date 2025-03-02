#Employee Management System
##📌 Project Overview
This is an ASP.NET Core MVC app for managing employee records. It supports Create, Read, Update, and Delete (CRUD) operations and uses Entity Framework Core for database interaction.

##📋 Features
📝 Add new employees
👀 View employee details
✏️ Update employee info
❌ Delete employee records
📊 Uses Entity Framework Core for database access
🔄 Follows MVC architecture
##⚙️ Technologies Used
ASP.NET Core MVC
Entity Framework Core (EF Core)
SQL Server (or your configured database)
Bootstrap (for UI)
GitHub & SourceTree (for version control)
🚀 Getting Started
1️⃣ Clone the Repo
bash
نسخ
تحرير
git clone https://github.com/YOUR_GITHUB_USERNAME/EmployeeManagement.git
cd EmployeeManagement
2️⃣ Setup Database
Make sure you have SQL Server installed. Update the connection string in appsettings.json:

json
نسخ
تحرير
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=EmployeeDB;Trusted_Connection=True;"
}
3️⃣ Run Migrations
bash
نسخ
تحرير
dotnet ef migrations add InitialCreate
dotnet ef database update
4️⃣ Run the App
bash
نسخ
تحرير
dotnet run
Then open http://localhost:5000 in your browser.

📌 API Endpoints
Method	Endpoint	Description
GET	/Employee	List employees
GET	/Employee/Id	Get employee by ID
POST	/Employee	Add an employee
PUT	/Employee/Id	Update employee
DELETE	/Employee/Id	Delete employee
💻 Contributing
Fork the repo
Create a branch (git checkout -b feature-name)
Make changes and commit (git commit -m "Add feature")
Push to GitHub (git push origin feature-name)
Open a Pull Request
