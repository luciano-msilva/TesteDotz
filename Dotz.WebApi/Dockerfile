#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["Dotz.WebApi/Dotz.WebApi.csproj", "Dotz.WebApi/"]
COPY ["Dotz.Application/Dotz.Application.csproj", "Dotz.Application/"]
COPY ["Dotz.Domain/Dotz.Domain.csproj", "Dotz.Domain/"]
COPY ["Dotz.Infra.Data/Dotz.Infra.Data.csproj", "Dotz.Infra.Data/"]
RUN dotnet restore "Dotz.WebApi/Dotz.WebApi.csproj"
COPY . .
WORKDIR "/src/Dotz.WebApi"
RUN dotnet build "Dotz.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Dotz.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Dotz.WebApi.dll"]