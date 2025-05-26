FROM mcr.microsoft.com/dotnet/sdk:9.0

RUN dotnet --version \ 
    && dotnet workload search maui \
    && dotnet workload install maui-windows maui-android \
    && dotnet workload list