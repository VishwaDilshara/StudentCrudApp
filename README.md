# Foobar

Foobar is a Python library for dealing with word pluralization.

## Installation

Create MVC Project
```bash
dotnet new mvc -n StudentCrudApp
cd StudentCrudApp
```
Add MySQL Support
```bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Pomelo.EntityFrameworkCore.MySql
```
## Path setup in MySQL
Ensure dotnet-ef is in your PATH
```bash
export PATH="$PATH:$HOME/.dotnet/tools"
```
```bash
echo 'export PATH="$PATH:$HOME/.dotnet/tools"' >> ~/.zshrc
source ~/.zshrc
```
```bash
echo 'export PATH="$PATH:$HOME/.dotnet/tools"' >> ~/.bash_profile
source ~/.bash_profile
```
## Run your migrations
```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

## Run Project
```bash
dotnet run 
```

## open mysql
```bash
mysql -u root -p
```


# Adding one table in the model 
## model example
```bash
using System.ComponentModel.DataAnnotations;

namespace StudentCrudApp.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Subject { get; set; }
    }
}

```
## AppDbContext 
```bash
using Microsoft.EntityFrameworkCore;
using StudentCrudApp.Models;

namespace StudentCrudApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        
        public DbSet<Teacher> Teachers { get; set; }  //new table adding example
    }
}

```

