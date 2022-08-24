# EDA Fundamentals

## 1 O que é?

Solução criada para praticar o que foi aprendido no curso *Fundamentos do Event-Driven Architecture* de balta.io, além da aplicação de demais conceitos e práticas vistos em outros cursos e repositórios do Github.

## 2 Arquitetura da solução

### 2.1 docker

Diretório com arquivo *docker-compose.yml* para criação de containers de mensageria:

- zookeeper

- kafka

- kafka-ui

### 2.2 eda-fundamentals.Shared

Projeto do tipo *classlib* com recursos compartilhados entre os demais projetos da solução, contendo classes abstratas e interfaces.

### 2.3 eda-fundamentals.Order.Domain

### 2.4 eda-fundamentals.Order.Infra

### 2.5 eda-fundamentals.Order.Api

### 2.6 eda-fundamentals.Receipt.Domain

### 2.7 eda-fundamentals.Receipt.Infra

### 2.8 eda-fundamentals.Receipt.Api

## 3 Configuração

### 3.1 Criação e início de containers Docker

Partindo do princípio que você possui o Docker instalado no seu computador, inicie o Docker, entre no diretório `docker` e execute o seguinte comando:

```bash
docker-compose up -d
```

## 4 Referências

- [GitHub - ivanpaulovich/event-sourcing-jambo: An Hexagonal Architecture with DDD + Aggregates + Event Sourcing using .NET Core, Kafka e MongoDB (Blog Engine)](https://github.com/ivanpaulovich/event-sourcing-jambo)

- [GitHub - balta-io/2810: Curso 2810 - Fundamentos da Arquitetura Orientada a Eventos (Event-Driven Architecture) com Apache Kafka](https://github.com/balta-io/2810)


