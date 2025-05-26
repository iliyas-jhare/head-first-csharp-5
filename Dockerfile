FROM mcr.microsoft.com/dotnet/sdk:9.0

RUN dotnet --version \ 
    && dotnet workload install maui \
    && dotnet workload list