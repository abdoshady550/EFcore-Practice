# RESO Project 🚀

Welcome to the **RESO** folder!  
This project is a friendly playground for exploring Entity Framework Core (EF Core) and database operations in .NET 8.0.  
Below you'll find details on what this project does, how to get started, and where to look for more info! 🎉

---

## 📦 What’s inside?

- **Program.cs**  
  Main entry point! It demonstrates fetching order bill details from the database using EF Core's raw SQL support and printing them in a formatted way.

- **RESO.csproj**  
  Project setup for .NET 8.0, with all the needed NuGet packages for EF Core, SQL Server, and configuration.

- **Data/** & **Entities/**  
  These folders are for your EF Core entities and database context setup.

---

## 🏃 Quick Start

1. **Clone the repo**
2. Open the `RESO` folder in your favorite IDE (like VS Code or Visual Studio)
3. Make sure you have .NET 8.0 installed
4. Add your database connection string to `appsettings.json`
5. Run the project and check your console for bill details! 🎟️

---

## 💡 What does the code do?

- Connects to a SQL Server database using EF Core.
- Calls a stored procedure (`GetOrderBill`) to get billing info.
- Prints each bill in a stylish format to the console.

```csharp
var orderBillDetails = new AppDbContext().Set<GetBill>()
    .FromSqlInterpolated($"select * from GetOrderBill({1})");
foreach (var item in orderBillDetails)
{
    Console.WriteLine("..."); // Pretty output!
}
```

---

## 📸 Example Output

![Order Bill Example](https://github.com/abdoshady550/EFcore-Practice/blob/master/RESO/Screenshot%202025-06-13%20143702.png?raw=true)

---

## 🤝 Contributing

Feel free to improve, add features, or ask questions!

---

## 📝 License

MIT (or your chosen license)

---

Enjoy coding! 😊
