Rest Api simples, criada para testar conceitos de recebimento e retorno de nested JSON, usando C#


Na rota do GET é retornado um array de objetos WeatherForecast, possuindo também uma sub classe Teste.

[
  {
    "date": "2022-03-11T16:00:08.3380456-03:00",
    "temperatureC": 14,
    "temperatureF": 57,
    "summary": "Balmy",
    "teste": {
      "teste1": 2,
      "teste2": 3
    }
  },
  {
    "date": "2022-03-12T16:00:08.3384315-03:00",
    "temperatureC": 37,
    "temperatureF": 98,
    "summary": "Freezing",
    "teste": {
      "teste1": 2,
      "teste2": 3
    }
  },
  {
    "date": "2022-03-13T16:00:08.3384344-03:00",
    "temperatureC": 38,
    "temperatureF": 100,
    "summary": "Balmy",
    "teste": {
      "teste1": 2,
      "teste2": 3
    }
  },
  {
    "date": "2022-03-14T16:00:08.3384347-03:00",
    "temperatureC": 47,
    "temperatureF": 116,
    "summary": "Freezing",
    "teste": {
      "teste1": 2,
      "teste2": 3
    }
  },
  {
    "date": "2022-03-15T16:00:08.3384348-03:00",
    "temperatureC": 11,
    "temperatureF": 51,
    "summary": "Freezing",
    "teste": {
      "teste1": 2,
      "teste2": 3
    }
  }
]


na rota POST é enviado um nestedJSON, e retornado o mesmo.

{
  "date": "2022-03-10T19:02:13.678Z",
  "temperatureC": 0,
  "temperatureF": 32,
  "summary": "string",
  "teste": {
    "teste1": 0,
    "teste2": 0
  }
}
