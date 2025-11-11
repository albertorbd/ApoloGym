FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

COPY *.sln .
COPY ApoloGym.Model/*.csproj ApoloGym.Model/
COPY ApoloGym.Business/*.csproj ApoloGym.Business/
COPY ApoloGym.Data/*.csproj ApoloGym.Data/
COPY ApoloGym.API/*.csproj ApoloGym.API/
RUN dotnet restore ApoloGym.sln

COPY . .
RUN dotnet publish ApoloGym.sln -c Release -o API/out

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime
WORKDIR /app
COPY --from=build /app/API/out .

EXPOSE 80
ENTRYPOINT ["dotnet", "ApoloGym.API.dll"]