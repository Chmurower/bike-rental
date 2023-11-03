FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["BikeRental.Api/BikeRental.Api.csproj", "BikeRental.Api/"]
RUN dotnet restore "BikeRental.Api/BikeRental.Api.csproj"
COPY . .
WORKDIR "/src/BikeRental.Api"
RUN dotnet build "BikeRental.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BikeRental.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BikeRental.Api.dll"]