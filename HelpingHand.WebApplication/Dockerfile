#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["HelpingHand.WebApplication/HelpingHand.WebApplication.csproj", "HelpingHand.WebApplication/"]
RUN dotnet restore "HelpingHand.WebApplication/HelpingHand.WebApplication.csproj"
COPY . .
WORKDIR "/src/HelpingHand.WebApplication"
RUN dotnet build "HelpingHand.WebApplication.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HelpingHand.WebApplication.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HelpingHand.WebApplication.dll"]