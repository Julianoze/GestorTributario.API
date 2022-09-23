## Objetivo
Aplicação modelo, com dois repositórios diferentes que trabalham com dados de tributação do produto.
Utilizando o AutoMapper converte em um objeto comum e conhecido pela aplicação, facilitando a integração com
diferentes serviços.

## Requisitos
* dotnet, version 5.0.x, runtime
* Node 14.0 ou superior
* Executar o Mock para poder testar o projeto e a conversão

## Execução
Após instalação do SDK, verifique se sua máquina já está configurada para o uso,
para isso execute:

```
dotnet --info
```

O resultado esperado será algo como isto:
```
SDK do .NET (refletindo qualquer global.json):
 Version:   5.0.302
 Commit:    c005824e35

Ambiente de runtime:
 OS Name:     ubuntu
 OS Version:  20.04
 OS Platform: Linux
 RID:         ubuntu.20.04-x64
 Base Path:   /usr/share/dotnet/sdk/5.0.302/

Host (useful for support):
  Version: 5.0.8
  Commit:  35964c9215

.NET SDKs installed:
  3.1.411 [/usr/share/dotnet/sdk]
  5.0.302 [/usr/share/dotnet/sdk]
```

No projeto, restaure os pacotes Nuget:
```
dotnet restore
```

## Mock
Com o node instalado na sua máquina, acesse via terminal a pasta Mock, na raiz do projeto e execute os seguintes comandos

```
npm i
npm run mock
```

No console será possível ver as rotas para consulta que são:

```
[Imendes] - http://localhost:5003/produtos
[Avant] - http://localhost:5004/products

```

## Utilizando a API
Para utilizar a API acesse, os comandos foram implementados para facilitar a usabilidade:

```
http://localhost:5000
```