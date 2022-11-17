# Build Stage
FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /source
COPY . .
RUN dotnet restore "./src/Web/PD.Workademy.Todo.Web/PD.Workademy.Todo.Web.csproj" --disable-parallel
RUN dotnet publish "./src/Web/PD.Workademy.Todo.Web/PD.Workademy.Todo.Web.csproj" -c release -o /app --no-restore

# Serve Stage
FROM mcr.micorosftcom/dotnet/aspnet:6.0-focal
WORKDIR /app
COPY --from = build /app /. 

EXPOSE 5000
ENTRYPOINT ["dotnet", "PD.Workademy.Todo.Web.dll"]