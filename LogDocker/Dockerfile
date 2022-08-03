#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["LogDocker/LogDocker.csproj", "LogDocker/"]
RUN dotnet restore "LogDocker/LogDocker.csproj"
COPY . .
WORKDIR "/src/LogDocker"
RUN dotnet build "LogDocker.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LogDocker.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LogDocker.dll"]