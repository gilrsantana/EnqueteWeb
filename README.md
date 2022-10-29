# PROJETO ENQUETE WEB
Projeto web para criação de uma enquete utilizando a tecnologia ASPNET.

## Definições do projeto
- Criação do arquivo globaljson para definir a versão dotnet do projeto
```
dotnet new globaljson --sdk-version 6.0.402
```
- Criação do projeto sem as definições https
```
dotnet new mvc --no-https
```
- Desinstalação e reinstalação da versão mais atual da ferramenta global 
```
dotnet tool uninstall --global Microsoft.Web.LibraryManager.Cli
dotnet tool install --global Microsoft.Web.LibraryManager.Cli
```
- Definição do diretório de bibliotecas client side padrão será jsdelivr, e definido através do arquivo `libman.json`
```
libman init -p jsdelivr
```
- Adicionar a biblioteca `bootstrap 5` ao projeto
```
libman install bootstrap -d wwwroot/lib/bootstrap5
```
- Serão criadas as pastas bootstrap, que contem a versão 4 da biblioteca, e bootstrap5, que contém a versão 5 da biblioteca bootstrap.
- Apagar a pasta bootstrap.
- Apagar as pastas jquery, jquery-validation e jquery-validation-unobtrusive, pois o bootstrap 5 não utiliza mais estas referências.
- Para atualizar as bibliotecas com a versão mais recente da mesma se utiliza o comando libman com o modelo `libman update biblioteca` , conforme exemplo abaixo:
```
libman update bootstrap
```
- Adicionar a referência do arquivo bootstrap.css às Views
```
<link rel="stylesheet" href="/lib/bootstrap5/dist/css/bootstrap.css">

```


