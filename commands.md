dotnet add package Swashbuckle.AspNetCore --version 9.0.6
dotnet add package Microsoft.EntityFrameworkCore.Design --version 9.0.19
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 9.0.19
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 9.0.19

cria o arquivo FlightsDbContext.cs

configura a connection string em appsettings.json "Server=localhost;Database=db;User Id=sa;Password=P@ssw0rd2024;Encrypt=Optional;TrustServerCertificate=True;"

cria o docker compose file

cria o DockerFile

docker compose up -d

docker exec -it sqlserver /opt/mssql-tools18/bin/sqlcmd \
  -S localhost -U sa -P 'P@ssw0rd2024' -C
Depois, dentro do sqlcmd:
CREATE DATABASE db;
GO

  hostname -I

dotnet tool install dotnet-ef --global

  dotnet ef migrations add InitialCreate -o Data/Migrations

  dotnet ef database update