# 🚀 EFcore-Practice - EF_Migration

Welcome to the **EF_Migration** project!  
This is a simple playground for practicing Entity Framework Core migrations and database interactions using .NET 8.0.  
<br>

---

## 📦 Project Structure

- **Data/**: Contains your database context and configuration files.
- **Entities/**: Houses all your entity classes (models).
- **Enums/**: Stores any enum types used within the project.
- **Migrations/**: Auto-generated EF Core migration files.
- **EF_Migration.csproj**: Project file with all dependencies.
- **Program.cs**: The main entry point of the app.

---

## 🛠️ Tech Stack

- **.NET 8.0**  
- **Entity Framework Core 9**  
- SQL Server (by default, but easily swappable)

---

## ✨ What does it do?

- Initializes an EF Core context.
- Reads data from the database (e.g., Sections, Courses, Instructors, Schedules).
- Nicely prints tabular data to the console, showing schedules per day! 📅

---

## 📊 Output Description

When you run this project, you'll see a clear, well-aligned table in your console that displays all sections in the database along with their related course, instructor, schedule type, and time slot. The table also shows which days of the week each section is held, using an "x" to indicate an active day. 

For example, the output includes:
- **Course names** (e.g., Mathematics, Physics, CS-50)
- **Section identifiers** (e.g., S_MA1, S_PH2)
- **Instructor full names**
- **Schedule types** (such as Daily, Weekend, TwiceAWeek, Compact, DayAfterDay)
- **Time slots** for each section
- A column for each day of the week (SUN, MON, TUE, WED, THU, FRI, SAT) showing when each section occurs

This makes it really easy to:
- 📅 Visualize the weekly schedule for all your sections at a glance
- 👨‍🏫 See which instructor is teaching which section and when
- ⏰ Quickly spot time slot overlaps or gaps in your schedule

---

## 🚦 How to Run

1. **Clone the repo**  
   ```sh
   git clone https://github.com/abdoshady550/EFcore-Practice.git
   cd EFcore-Practice/EF_Migration
   ```

2. **Restore dependencies**  
   ```sh
   dotnet restore
   ```

3. **Apply migrations & update database**  
   ```sh
   dotnet ef database update
   ```

4. **Run the app**  
   ```sh
   dotnet run
   ```

---

## 🖼️ Output Example

Here’s how your console output will look:

![image1](https://github.com/abdoshady550/EFcore-Practice/blob/master/EF_Migration/Screenshot%202025-06-13%20144305.png?raw=true)

---

## 🤩 Why use this?

- Practice EF Core migrations in a clean, isolated project.
- See real examples of table relationships & console formatting.
- Easily extend with your own models or migrations.
- Instantly visualize complex schedule data in a user-friendly way!

---

## 💡 Pro Tips

- Change the connection string in `appsettings.json` to point to your SQL Server.
- Add new entities in the `Entities/` folder and update the `AppDbContext`.
- Use `dotnet ef migrations add <Name>` to create new migrations!

---

## 🙌 Happy Coding!

Made with ❤️ by [abdoshady550](https://github.com/abdoshady550)