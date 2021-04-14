#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Oesia.WebApi/Oesia.WebApi.csproj", "Oesia.WebApi/"]
RUN dotnet restore "Oesia.WebApi/Oesia.WebApi.csproj"
COPY . .
WORKDIR "/src/Oesia.WebApi"
RUN dotnet build "Oesia.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Oesia.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Oesia.WebApi.dll"]