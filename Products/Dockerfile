FROM mcr.microsoft.com/dotnet/aspnet:5.0
FROM mcr.microsoft.com/dotnet/sdk:5.0

COPY /bin/Release/net5.0/publish/ BrendensStore/

ENV ASPNETCORE_ENVIROMENT Production

EXPOSE 5000
WORKDIR /BrendensStore
ENTRYPOINT ["dotnet", "Products.dll", "--urls=http://0.0.0.0:5000"]
