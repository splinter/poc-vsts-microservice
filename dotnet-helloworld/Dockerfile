FROM microsoft/dotnet:2.0-sdk
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# copy and build everything else
COPY . ./
EXPOSE 3000
RUN dotnet publish -c Release -o out
ENTRYPOINT ["dotnet", "out/dotnet-helloworld.dll"]