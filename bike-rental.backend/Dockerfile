# Use the official .NET SDK image as the base image
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env

# Set the working directory to /app
WORKDIR /app

# Expose port 80 for the application
EXPOSE 80
EXPOSE 443

# Copy the solution file and restore dependencies
COPY BikeRental.sln .
COPY BikeRental.Api/BikeRental.Api.csproj ./BikeRental.Api/
COPY BikeRental.Models/BikeRental.Models.csproj ./BikeRental.Models/
COPY BikeRental.Services/BikeRental.Services.csproj ./BikeRental.Services/

# Restore NuGet packages
RUN dotnet restore

# Copy the rest of the application code
COPY BikeRental.Api/ ./BikeRental.Api/
COPY BikeRental.Models/ ./BikeRental.Models/
COPY BikeRental.Services/ ./BikeRental.Services/

# Build the application
RUN dotnet build -c Release -o out

# Create the runtime image
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-final
WORKDIR /app
COPY --from=build-env /app/out .

# Specify the entry point for the application
ENTRYPOINT ["dotnet", "BikeRental.Api.dll"]