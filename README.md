FarmConnectMini

FarmConnectMini is a web-based platform designed to connect farmers and users, allowing farmers to add, manage, and display their crops while users can easily view and explore available produce.
Built with ASP.NET Core MVC, it provides a simple, efficient, and visually appealing interface for managing agricultural data.

🚀 Project Objective

The main goal of this project is to create a centralized and digital system for farmers to showcase their crops and manage their products online.
It bridges the communication gap between farmers and customers, promoting transparency and accessibility.

🧰 Technologies Used
Category	Technology
Frontend	HTML, CSS, Bootstrap
Backend	ASP.NET Core MVC (C#)
Database	In-Memory List / Entity Framework (optional)
IDE	Visual Studio / VS Code
Version Control	Git & GitHub
⚙️ Features

✅ Farmer Dashboard

Add new crops with details (Name, Price, Quantity)

Delete crops when sold or unavailable

View all added crops in an organized table

✅ User Interface

Home page displays all available crops

Button to navigate to the Farmer Dashboard

✅ Attractive UI

Clean and modern interface

Responsive design for better accessibility

✅ Role Separation (Optional)

Farmers: Add / Delete crops

Users: View crops only

🧩 Project Structure
FarmConnectMini/
│
├── Controllers/
│   ├── HomeController.cs
│   └── FarmerController.cs
│
├── Models/
│   └── Crop.cs
│
├── Views/
│   ├── Home/
│   │   ├── Index.cshtml
│   └── Farmer/
│       ├── Index.cshtml
│       └── AddCrop.cshtml
│
├── wwwroot/
│   ├── css/
│   ├── js/
│   └── images/
│
├── README.md
└── LICENSE

🖥️ Installation Steps

Clone the Repository

git clone https://github.com/jenishpatel963-bot/FarmConnectMini-.git


Open in Visual Studio or VS Code

Restore Dependencies

dotnet restore


Build and Run

dotnet run


Access in Browser

https://localhost:5165

🧪 How to Use

Go to Home Page — view available crops.

Click 👨‍🌾 Go to Farmer Dashboard (top-right corner).

Use the Add New Crop button to add items.

View, delete, and manage your crops easily.

)

📚 Future Improvements

Implement a real database (SQL Server / SQLite)

Add authentication for Farmers and Users

Enable search and filter options for crops

Integrate online selling functionality

🤝 Contributing

Pull requests are welcome!
If you’d like to improve UI, add new features, or fix bugs, please fork this repo and submit a pull request.



👨‍💻 Author

Jenish Patel
📧 jenishpatel963-bot
