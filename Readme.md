# Chamados

Sistema de chamados (ordens de serviço), projeto integrador do curso de Desenvolvimento Web e Multiplataforma com .NET.

## Requisitos
- .NET SDK 10.0.404 (fixado em `global.json`)

## Como executar
    dotnet build
    dotnet run --project src/Chamados.Web
    dotnet test

## Decisões
- .NET 10 (LTS) como alvo, com suporte até 14/11/2028.
- Solução no formato .slnx (padrão do SDK 10).