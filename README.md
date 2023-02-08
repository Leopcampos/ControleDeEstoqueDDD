# ControleDeEstoqueDDD
Criação dos projetos:

1 - dotnet new sln -n ControleDeEstoqueDDD
<br>2 - Criar a pasta src
<br>3 - Dentro da pasta src
<br>4 - dotnet new classlib -n ControleDeEstoqueDDD.Domain
<br>5 - dotnet new classlib -n ControleDeEstoqueDDD.Application
<br>6 - dotnet new classlib -n ControleDeEstoqueDDD.Infra.Data
<br>7 - dotnet new classlib -n ControleDeEstoqueDDD.Infra.CrossCutting
<br>8 - dotnet new mvc -n ControleDeEstoqueDDD.Web
<br>9 - dotnet new gitignore

******Adicionando os projetos na solução ControleDeEstoqueDDD.sln******
<br>dotnet sln ControleDeEstoqueDDD.sln add .\ControleDeEstoqueDDD.Domain
<br>dotnet sln ControleDeEstoqueDDD.sln add .\ControleDeEstoqueDDD.Application\
<br>dotnet sln ControleDeEstoqueDDD.sln add .\ControleDeEstoqueDDD.Infra.Data\
<br>dotnet sln ControleDeEstoqueDDD.sln add .\ControleDeEstoqueDDD.Infra.CrossCutting\
<br>dotnet sln ControleDeEstoqueDDD.sln add .\ControleDeEstoqueDDD.Web\
<br>dotnet restore
