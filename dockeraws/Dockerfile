# FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
# WORKDIR /app
# EXPOSE 80
# EXPOSE 443
 
# FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
# WORKDIR /src
# COPY ["dockeraws/dockeraws.csproj", "dockeraws/"]
# RUN dotnet restore "dockeraws/dockeraws.csproj"
# COPY . .
# WORKDIR "/src/dockeraws"
# RUN dotnet build "dockeraws.csproj" -c Release -o /app/build
 
# FROM build AS publish
# RUN dotnet publish "dockeraws.csproj" -c Release -o /app/publish
 
# FROM base AS final
# WORKDIR /app
# COPY --from=publish /app/publish .
# ENTRYPOINT ["dotnet", "dockeraws.dll"]


FROM mcr.microsoft.com/dotnet/sdk:6.0 AS base
WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

COPY . .

RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime
WORKDIR /app
COPY --from=build /app/out ./

EXPOSE 80

ENTRYPOINT ["dotnet","dockeraws.dll" ]


