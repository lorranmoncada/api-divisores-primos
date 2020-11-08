#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /app
EXPOSE 80

COPY *.sln ./
COPY ["FatoresPrimos/FatoresPrimos.csproj", "FatoresPrimos/"]
COPY ["Domain/Domain.csproj", "Domain/"]
COPY ["Entities/Entities.csproj", "Entities/"]
COPY ["FatoresPrimosTest/FatoresPrimosTest.csproj", "FatoresPrimosTest/"]
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o out

WORKDIR /app
COPY --from=build-env /app/out .

ENTRYPOINT ["dotnet", "FatoresPrimos.dll"]