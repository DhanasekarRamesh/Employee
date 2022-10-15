## Project Approach: dotnet core 6.0 DataFirst
<hr>
<br />

## Environment setup

* Visual Studio Code
* Dotnet ef cli is required to run the ef commands 

> dotnet tool install --global dotnet-ef

<br />

**Extensions: Required**
* Nuget Package Manager GUI
* Thunder Client
* C# Extension
* SqlServer(mssql) - SqlServer Client for vscode - To prview the tables.

<br /><br />

Step 1: Create a new project
> dotnet new webapi -n employee-management-api

<br />
step 2: Create required tables in database

<br />
step 3: Add Connection string in appsettings.json

Add your *mysql* connectionstring in appsettings.json file in the root project.

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=xxxx,xxxx;Initial Catalog=xxxxxx;User ID=xxxxxx;Password=xxxxxx;Persist Security Info=False;"
  }
}
```
<br />

**Packages required**
> dotnet add package Microsoft.EntityFrameworkCore.Design

> dotnet add package Microsoft.EntityFrameworkCore

> dotnet add package Pomelo.EntityFrameworkCore.MySql

> dotnet add package Microsoft.EntityFrameworkCore.Tools

<br />

**To generate dbcontext and models use the below command**

> dotnet ef dbcontext scaffold -c MyDBContext --context-dir Data -o Models  Name=constring Pomelo.EntityFrameworkCore.MySql

<br />

**To generate controllers use the below command**

>  dotnet aspnet-codegenerator controller -name CategoryController -async -api -m Category -dc MyDBContext -outDir Controllers




<br /><br />
**Addtional Support commands for reference.**

> dotnet ef database update -- --environment Production

> dotnet tool install -g dotnet-aspnet-codegenerator