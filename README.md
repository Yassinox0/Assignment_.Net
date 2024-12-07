# Dot Net Laboratoire 2

## Overview
This repository contains the code and instructions for the Dot Net Laboratoire 2 assignment. The assignment focuses on using NuGet packages, Entity Framework Core (EF Core), and ASP.NET to create and manage a database, perform migrations, and display data in an MVC application.

## Table of Contents
1. [Prerequisites](#prerequisites)
2. [Setup](#setup)
3. [Part 1: NuGet Packages and EF Core Installation](#part-1-nuget-packages-and-ef-core-installation)
4. [Part 2: Creating the Data Context](#part-2-creating-the-data-context)
5. [Part 3: Adding a Migration](#part-3-adding-a-migration)
6. [Part 4: Modifying the Layout of View Pages](#part-4-modifying-the-layout-of-view-pages)
7. [Part 5: Introducing Categories](#part-5-introducing-categories)

## Prerequisites
- Visual Studio 2022 or later
- .NET Core SDK 8.0 or later
- SQL Server

## Setup
1. Clone the repository:
   ```sh
   git clone https://github.com/your-username/dot-net-laboratoire-2.git
Open the project in Visual Studio.

Restore the NuGet packages:

    
 Copier le code dotnet restore
Update the database connection string in appsettings.json to match your SQL Server configuration.

- Example:json
- Copier le code
  ```sh
  {
  "ConnectionStrings": {
    "DefaultConnection": "Server=your_server_name;  
    Database=your_database_name;Trusted_Connection=True;    
    MultipleActiveResultSets=true"
  }
  }
  
## Part 1: NuGet Packages and EF Core Installation
Setup
To add EF Core to your project, use the following command:

 
- Copier le code:
  ```sh
  dotnet add package Microsoft.EntityFrameworkCore.SqlServer
  dotnet add package Microsoft.EntityFrameworkCore.Tools
- Ensure these packages are restored by running:
- Copier le code
    ```sh
    dotnet restore

  
## Part 2: Creating the Data Context
Create a new class ApplicationDbContext and configure it to include your entities. Here’s an example:

csharp
- Copier le code:
  ```sh
  using Microsoft.EntityFrameworkCore;

  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base       (options) { }

    public DbSet<Product> Products { get; set; }
  }

## Part 3: Adding a Migration
Run the following command to create a migration for your database schema:
- Copier le code
  ```sh
  dotnet ef migrations add InitialCreate
- Apply the migration to the database:

  ```sh
  dotnet ef database update
## Part 4: Modifying the Layout of View Pages
To customize the layout, update the _Layout.cshtml file in the Views/Shared folder. For example:
    ```sh

      html
     <nav>
        <ul>
         <li><a href="/">Home</a></li>
         <li><a href="/Products">Products</a></li>
       </ul>
    </nav>
  
## Part 5: Introducing Categories
- Add a new entity Category:
   ```sh
  public class Category
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Product> Products { get; set; }
  }
- Update the ApplicationDbContext:

    ```sh
    public DbSet<Category> Categories { get; set; }


- Run migrations to update the database schema:
    ```sh
  dotnet ef migrations add AddCategory
  dotnet ef database update







