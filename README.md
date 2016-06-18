# dotnetcore ef

{
  "dependencies": {
    "Microsoft.EntityFrameworkCore.Sqlite": "1.0.0-rc2-*",
    "Microsoft.EntityFrameworkCore.Tools": {
      "version": "1.0.0-preview1-*",
      "type": "build"
    }
  },

  "tools": {
    "Microsoft.EntityFrameworkCore.Tools": {
      "version": "1.0.0-preview1-*",
      "imports": [
        "dnxcore50",
        "portable-net45+win8"
      ]
    }
  },

dotnet ef --help
dotnet ef migrations add MyFirstMigration
dotnet ef database update
