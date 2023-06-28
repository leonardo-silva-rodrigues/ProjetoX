#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["X.WebApi/X.WebApi/X.WebApi.csproj", "X.WebApi/X.WebApi/"]
RUN dotnet restore "X.WebApi/X.WebApi/X.WebApi.csproj"
COPY . .
WORKDIR "/src/X.WebApi/X.WebApi"
RUN dotnet build "X.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "X.WebApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "X.WebApi.dll"]