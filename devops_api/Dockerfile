FROM mcr.microsoft.com/dotnet/aspnet:3.1
COPY Release/ App/
WORKDIR /App
EXPOSE 80
ENTRYPOINT ["dotnet", "devops_test_api.dll"]
