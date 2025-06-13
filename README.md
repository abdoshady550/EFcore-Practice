# 🛠️ EFcore-Practice

Welcome! This repository is your hands-on playground for learning and experimenting with **Entity Framework Core (EF Core)** in .NET. Here, you'll find multiple projects, each showing off a different EF Core feature—like migrations, reverse engineering, and configuration tricks.

---

## 📂 Projects Overview

This repo is organized into several folders, each focusing on a unique EF Core scenario:

### 1. [`EF_External_Configuration`](EF_External_Configuration)
🔧 **External configuration samples**  
- `Data/` – Data-related files and setups.
- `Entities/` – Entity classes for use in demos.
- [`Program.cs`](EF_External_Configuration/Program.cs) – Entry point to run samples.
- [`EF_External_Configuration.csproj`](EF_External_Configuration/EF_External_Configuration.csproj) – Project setup.

---

### 2. [`EF_Migration`](EF_Migration)
📈 **Database migrations explained**  
- `Data/` – Context and data files.
- `Entities/` – Entity models.
- `Enums/` – Enum definitions for entities.
- `Migrations/` – EF Core migration snapshots.
- [`Program.cs`](EF_Migration/Program.cs) – Run migration demos.
- [`EF_Migration.csproj`](EF_Migration/EF_Migration.csproj) – Project setup.

---

### 3. [`EF_Reverse_Engineering`](EF_Reverse_Engineering)
🔄 **Database-to-Code reverse engineering**  
- `Data/` – Data/context info.
- `Entities/` – Reverse-engineered models from an existing DB.
- [`Program.cs`](EF_Reverse_Engineering/Program.cs) – Demo of the generated models.
- [`EF_Reverse_Engineering.csproj`](EF_Reverse_Engineering/EF_Reverse_Engineering.csproj) – Project file.

---

### 4. [`EFcore_Test`](EFcore_Test)
🧪 **General EF Core tests and experiments**  
- `Data/` – Data/context files.
- `Entities/` – Models for various demos.
- [`Program.cs`](EFcore_Test/Program.cs) – Main testing program.
- [`EFcore_Test.csproj`](EFcore_Test/EFcore_Test.csproj) – Project setup.

---

### 5. [`RESO`](RESO)
🎯 **Additional sample project**  
- `Data/` – Data/context files.
- `Entities/` – More entity models.
- [`Program.cs`](RESO/Program.cs) – Entry point.
- [`RESO.csproj`](RESO/RESO.csproj) – Project setup.

---

## 🚀 Getting Started

1. **Clone the repository**
   ```bash
   git clone https://github.com/abdoshady550/EFcore-Practice.git
   ```

2. **Open in Visual Studio or your favorite .NET IDE**

3. **Restore NuGet packages**
   (Most projects use EF Core packages. Restore them before building.)

4. **Run a project**
   ```bash
   dotnet run --project EF_Migration
   # Replace EF_Migration with the folder of your chosen sample
   ```

---

## 📝 Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)
- Some familiarity with Entity Framework Core concepts

---

## 🎓 Why This Repo?

This is a safe space for tinkering, learning, and experimenting with EF Core!  
Each folder = a new challenge or concept:
- **External Configuration:** Manage EF Core outside the code.
- **Migrations:** Evolve your DB schema with version control.
- **Reverse Engineering:** Generate models from your existing DB.
- **Testing:** Try stuff and break things (safely).

---

## 🤝 Contributing

Found something cool? Want to add more examples?  
**Fork, clone, and send a Pull Request!**  
All contributions are welcome—let’s learn together!

---

## 📄 License

Open source, MIT licensed.

---

Made with ❤️ by [abdoshady550](https://github.com/abdoshady550)

![Entity Framework Core Logo](https://learn.microsoft.com/en-us/ef/core/media/ef-logo.png)
