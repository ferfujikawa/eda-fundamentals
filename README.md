# EDA Fundamentals

## 1 O que é?

Solução criada para praticar o que foi aprendido no curso *Fundamentos do Event-Driven Architecture* de balta.io, além da aplicação de demais conceitos e práticas vistos em outros cursos e repositórios do Github.

## 2 Contextos

### 2.1 eda-fundamentals.Order

Contexto composto pelos projetos Domain (classlib), Infra (classlib) e Api (webapi). A API deste contexto possui um endpoint para registro de um *Order* e envio de mensagem ao Kafka contendo dados do *Order* registrado.

### 2.2 eda-fundamentals.Receipt

Contexto composto pelos projetos Domain (classlib), Infra (classlib) e App (console). A aplicação console deste contexto cria um *consumer* das mensagens enviadas ao Kafka, e faz a deserialização do *Order* contido na mensagem.

### 2.3 eda-fundamentals.Shared

Projeto do tipo *classlib* com recursos compartilhados entre os demais projetos da solução, contendo classes abstratas e interfaces.

## 3 Configuração

### 3.1 Criação e início de containers Docker

Partindo do princípio que você possui o Docker instalado no seu computador, inicie o Docker, entre no diretório `docker` e execute o seguinte comando:

```bash
docker-compose up -d
```

Assim, serão iniciados 3 *containers* de mensageria:

- zookeeper
- kafka
- kafka-ui

## 4 Referências

- [GitHub - ivanpaulovich/event-sourcing-jambo: An Hexagonal Architecture with DDD + Aggregates + Event Sourcing using .NET Core, Kafka e MongoDB (Blog Engine)](https://github.com/ivanpaulovich/event-sourcing-jambo)

- [GitHub - balta-io/2810: Curso 2810 - Fundamentos da Arquitetura Orientada a Eventos (Event-Driven Architecture) com Apache Kafka](https://github.com/balta-io/2810)
