FROM mpospisil/dotnet-runtime-windowsdesktop:6.0.18-nanoserver-ltsc2022 AS base
#FROM mpospisil/dotnet-runtime-windowsdesktop:6.0.18-windowsservercore-ltsc2022 AS base

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY . .
RUN dotnet restore "src/DevDeptTstApp/DevDeptTstApp.sln"

#COPY . .
#WORKDIR "/src/DevDeptTstApp/DevDeptTstApp"
#RUN dotnet build "DevDeptTstApp.csproj" -c Release -o /app/build
#RUN dotnet restore "src/DevDeptTstApp/DevDeptTstApp.sln"
RUN dotnet build "src/DevDeptTstApp/DevDeptTstApp.sln" -c Release 

FROM build AS publish
RUN dotnet publish "src/DevDeptTstApp/DevDeptTstApp/DevDeptTstApp.csproj" -f net6.0-windows -c Release -o /app/publish /p:UseAppHost=true --runtime win-x64 

FROM base AS final
WORKDIR /app
#COPY --from=publish /src/API_Example1/bin/Release/net6.0-windows .
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "DevDeptTstApp.dll"]
#ENTRYPOINT ["powershell.exe"]
