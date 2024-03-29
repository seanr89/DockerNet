# Step 1: Specify your base image
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

# Step 2: Copy project file to the ./ container folder
COPY *.csproj ./
# Step 3: Run a restore to download dependencies
RUN dotnet restore

# Step 4: Copy app code to the container
COPY . .
# Step 5: Build the app in Release mode
# Step 6: Publish the application
RUN dotnet publish -c Release -o out

# Step 7: Expose port 80 in the container
EXPOSE 80

# Build runtime image
# Step 8: Move the /app folder and run the compiled app
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "NetDockerConsole.dll"]