# Sistema de gerenciamento de fazenda

Sistema criado para o curso de ADS da UNIP.

# Instruções

Para executar o programa execute o comando abaixo:

```sh
dotnet run
```

URL para acessar o swegger
http://127.0.0.1:5264/swagger/index.html




```sh

# dependencias

dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 7.0.0
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 7.0.0

```



```sh

# banco sql server no docker

docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=Senharoot123" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2022-latest

```

