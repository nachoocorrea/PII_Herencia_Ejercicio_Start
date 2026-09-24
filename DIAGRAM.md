```mermaid
classDiagram
  class User {
    <<abstract>>
    id: string
    name: string
    lastnae: string
    photo: string
    PublicarEnDiscord()* void
  }
  class Conductor {
    rating: double
    bio: string
    PublicarEnDiscord() void
  }
  class Pasajero {
    rating: double
    PublicarEnDiscord() void
  }
  class StandardDriver
  class PoolDriver {
    capacidadMaxima: int
  }
  class Vehicle {
    marca: string
    modelo: string
    patente: string
  }
  Usuario <|-- Conductor
  Usuario <|-- Pasajero
  Conductor <|-- ConductorComun
  Conductor <|-- ConductorPool
  Conductor "1" *-- "1" Vehiculo
```
