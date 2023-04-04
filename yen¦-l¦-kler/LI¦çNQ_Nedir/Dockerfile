#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["LİNQ_Nedir/LİNQ_Nedir.csproj", "LİNQ_Nedir/"]
RUN dotnet restore "LİNQ_Nedir/LİNQ_Nedir.csproj"
COPY . .
WORKDIR "/src/LİNQ_Nedir"
RUN dotnet build "LİNQ_Nedir.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LİNQ_Nedir.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LİNQ_Nedir.dll"]
