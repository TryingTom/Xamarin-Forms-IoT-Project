# Xamarin-Forms-IoT-Project
A whole project made for school, including Xamarin Forms mobile app, ASP.NET Core API, and an IoT device made with ESP32. Pretty much everything is on the todo list.

## API
The API is a restful API made with .NET Framework Core, and it uses SQLite with local database and the database is initialized using Fluent API. 

Restore all the dependencies with the restore CLI command inside the root directory.
```
dotnet restore
```

Also make sure you have user secrets initialized for the database connection string!
```
dotnet user-secrets init
dotnet user-secrets set "ConnectionStrings:default" "Data source=[YourDatabaseName].db"
```

## API Calls
There is Postman Collection included inside the project, import the file into your postman and it will include all the calls. *Use environment to set the url and the url index!*
