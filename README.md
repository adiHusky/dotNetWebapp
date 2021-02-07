# dotNetWebapp

# Introduction

This is a very simple project based on dotnet core which has a dotnet frontend and a dotnet backend.
It has 3 pages which shows the lyrics, singer and relevant details

# Instructions to install extra dependencies

- It is necessary to have dotnet packages before running this project
- Use the following command to install dotnet core for Linux -> https://docs.microsoft.com/en-in/dotnet/core/install/linux
- wget https://packages.microsoft.com/config/ubuntu/18.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
- sudo apt-get update; \
  sudo apt-get install -y apt-transport-https && \
  sudo apt-get update && \
  sudo apt-get install -y dotnet-sdk-5.0
- sudo apt-get update; \
  sudo apt-get install -y apt-transport-https && \
  sudo apt-get update && \
  sudo apt-get install -y aspnetcore-runtime-5.0
- sudo apt-get install -y dotnet-runtime-5.0

#Check the version to verify installation
- dotnet version

#Steps for running the project
- dotnet run 
- open Browser and run local server on the port mentioned ( It will be either 5001 or 5000 mostly)
