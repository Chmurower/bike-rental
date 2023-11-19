# Use the official .NET SDK image as a base image
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /app

# Copy the solution file and restore NuGet packages
COPY *.sln .
COPY *.csproj ./
COPY ../BikeRental.Services/*.csproj ./BikeRental.Services/
COPY ./BikeRental.Models/*.csproj ./BikeRental.Models/

RUN dotnet restore

# Copy the entire solution contents and build the application
COPY . .
RUN dotnet publish -c Release -o out

# Create the final runtime image
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "BikeRental.Api.dll"]
