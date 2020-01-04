FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["CookieAuthentication/CookieAuthentication.csproj", "CookieAuthentication/"]
RUN dotnet restore "CookieAuthentication/CookieAuthentication.csproj"
COPY . .
WORKDIR "/src/CookieAuthentication"
RUN dotnet build "CookieAuthentication.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CookieAuthentication.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CookieAuthentication.dll"]