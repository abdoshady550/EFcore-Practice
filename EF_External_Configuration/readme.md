# EF_External_Configuration 🚀


Welcome to the **EF_External_Configuration** project!  
This sample demonstrates how to configure **Entity Framework Core (EF Core)** using external configuration files, such as `appsettings.json`, and how to manage your database context through Dependency Injection in a clean, modern .NET way.  

---

## 🌟 Features

- **External Configuration:** Uses `appsettings.json` to store and retrieve the connection string.
- **Dependency Injection:** Sets up `AppDbContext` with DI via `ServiceCollection`.
- **Simple Query Example:** Reads and prints data from the `Wallets` table.
- **Code Comments:** Additional commented-out code shows alternative ways to configure and use `DbContext` and `DbContextFactory`.

---

## 📦 How It Works

1. **Loads Configuration:**  
   The application reads `appsettings.json` to get the connection string:
   ```csharp
   var configuration = new ConfigurationBuilder()
       .AddJsonFile("appsettings.json")
       .Build();
   var connStr = configuration.GetSection("constr").Value;
   ```

2. **Sets up Dependency Injection:**  
   Registers `AppDbContext` using the connection string:
   ```csharp
   service.AddDbContext<AppDbContext>(option =>
       option.UseSqlServer(connStr));
   IServiceProvider serviceProvider = service.BuildServiceProvider();
   ```

3. **Queries Data:**  
   Retrieves and prints all items from the `Wallets` table:
   ```csharp
   using (var context = serviceProvider.GetService<AppDbContext>())
   {
       foreach (var item in context!.Wallets)
       {
           Console.WriteLine(item);
       }
   }
   ```

4. **Additional Patterns:**  
   The code also shows (as comments) how to use `DbContextFactory` and `DbContextOptionsBuilder` for advanced scenarios.

---

## 📁 Structure

- `Program.cs` — Main logic, configuration setup, and EF Core usage.
- `appsettings.json` — Stores the connection string for your database.
- `Data/` — Likely contains your `AppDbContext` and entity models.

---

## ✨ Quick Start

1. **Clone the repo:**  
   ```bash
   git clone https://github.com/abdoshady550/EFcore-Practice.git
   ```

2. **Navigate to the folder:**  
   ```bash
   cd EFcore-Practice/EF_External_Configuration
   ```

3. **Update `appsettings.json`:**  
   Make sure your SQL Server connection string is set under `constr`.

4. **Run the app:**  
   ```bash
   dotnet run
   ```

---

## 🤔 Why Use External Configuration with EF Core?

- **Security:** Keeps sensitive info out of source code.
- **Flexibility:** Easily switch databases/environments.
- **Scalability:** Cleaner for team and production setups.



## 🙌 Happy Coding!

If you like this project, give it a ⭐️ and check out more on [abdoshady550's GitHub](https://github.com/abdoshady550)!  
Feel free to open issues for questions or suggestions.

---
