FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
EXPOSE 5000
WORKDIR /app
COPY ./app .
ENTRYPOINT ["dotnet", "ASPNETCORE_ForContainering.dll"]
