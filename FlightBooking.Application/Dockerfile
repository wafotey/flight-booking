FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 80

ENV ASPNETCORE_URLS=http://+:80

USER app
FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG configuration=Release
WORKDIR /src
COPY ["FlightBooking.Application/FlightBooking.Application.csproj", "FlightBooking.Application/"]
COPY ["FlightBooking.Infrastructure/FlightBooking.Infrastructure.csproj", "FlightBooking.Infrastructure/"]
COPY ["FlightBooking.Domain/FlightBooking.Domain.csproj", "FlightBooking.Domain/"]
RUN dotnet restore "FlightBooking.Application/FlightBooking.Application.csproj"
COPY . .
WORKDIR "/src/FlightBooking.Application"
RUN dotnet build "FlightBooking.Application.csproj" -c $configuration -o /app/build

FROM build AS publish
ARG configuration=Release
RUN dotnet publish "FlightBooking.Application.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FlightBooking.Application.dll"]
