# Use the official ASP.NET Core runtime as the base image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app

# Use the .NET SDK image for building the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy the project file(s) from the /src/DotNetWebApp directory and restore dependencies
COPY src/DotNetWebApp/DotNetWebApp.csproj ./DotNetWebApp/
WORKDIR /src/DotNetWebApp
RUN dotnet restore

# Copy the rest of the application source code into the container
COPY src/DotNetWebApp/. ./

# Build and publish the application
RUN dotnet publish -c Release -o /app/publish

# Build runtime image
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "DotNetWebApp.dll"]

