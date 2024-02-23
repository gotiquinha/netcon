# API de Conversão de Anos-luz para Quilômetros

Esta é uma API REST simples desenvolvida em .NET 6 que permite aos usuários converter distâncias de anos-luz para quilômetros e vice-versa.

## Funcionalidades

- Conversão de anos-luz para quilômetros.
- Conversão de quilômetros para anos-luz.

## Como Executar

Certifique-se de ter o .NET 6 SDK instalado em sua máquina. Clone o repositório e execute o seguinte comando no diretório raiz do projeto:

```bash
dotnet run
```

A API estará disponível por padrão em http://localhost:5154.

## Endpoints

### Converter Anos-luz para Quilômetros

- **URL**: /api/v1/converter/paraQuilometros
- **Método**: GET
- **Parâmetro de Query**: anosLuz
- **Exemplo de Uso**: http://localhost:5154/api/v1/converter/paraQuilometros?anosLuz=1

### Converter Quilômetros para Anos-luz

- **URL**: /api/v1/converter/paraAnosLuz
- **Método**: GET
- **Parâmetro de Query**: quilometros
- **Exemplo de Uso**: http://localhost:5154/api/v1/converter/paraAnosLuz?quilometros=9461000000000

## Resposta de Sucesso

O código de status 200 OK será retornado juntamente com um JSON contendo o valor convertido, caso a conversão seja bem-sucedida:

```json
{
    "codigoStatus": 200,
    "mensagemErro": "",
    "dataHora": "2024-02-20T19:56:99.933Z",
    "valorConvertido": 9461000000000
}
```

## Resposta de Erro

O código de status 400 Bad Request será retornado em caso de erro, por exemplo, quando um valor não numérico ou menor que 1 é fornecido:

```json
{
    "codigoStatus": 400,
    "mensagemErro": "Valor inválido. O valor deve ser numérico e maior ou igual a 1.",
    "dataHora": "2024-02-20T19:23:23.357Z",
    "valorConvertido": 0
}
```

```json
{
    "codigoStatus": 400,
    "mensagemErro": "Valor inválido. O valor deve ser numérico e maior ou igual a 1.",
    "dataHora": "2024-02-20T19:23:23.357Z",
    "valorConvertido": 0
}
```

## Tecnologias Utilizadas

- .NET 6
- ASP.NET Core
