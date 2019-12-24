# Sapience

Sistema que interpreta os dados do Portal de Dados Abertos da CVM.

## Setup

* Quais são as ferramentas necessárias
    Exemplo: Visual Studio, Psake, Git, Xamarin, .NET Core SDK 2.0+ etc
* Quais os passos para conseguir executar o projeto
    Exemplo: como executar migrations, como clonar projeto

## Políticas de Código 

* Quais são as regras definidas pelo time
    Exemplo: código escrito em inglês, tratar warning como erro, manter dependências atualizadas etc 
* As regras estão definidas no editorconfig
* Qual code analysis o time utiliza?

## Políticas de branchs

* O que foi acordado com o time
    Exemplo: como lidar com novas features, como lidar com correções em produção
* Qual padrão dos nomes das branchs
* Como funcionará a branch master

## Políticas de Pull Request

* Descrever checklist de ações a serem realizadas para abertura de PR
    Exemplo: garantir cobertura de testes no que foi desenvolvido, vincular a um PBI
* Quem são os responsáveis/envolvidos/revisores durante cada etapa
* Como funciona PR rejeitado
* Tempo/Prioridade de revisão PR

## Políticas de Code Review

* O que deve ser avaliado?
    Exemplo: avaliar apenas qualidade de código, validar regras do editorconfig
* O time valida a funcionalidade desenvolvida ou apenas o código?

## Políticas de Testes Automatizados

* Quais são os testes que o projeto possui
* Quais são os frameworks utilizados
* O que deve ser testado
    Exemplo: teste de integração para API, teste de unidade para regras de negócio etc
* Qual o nível de cobertura para cada teste
* COmo executar os testes

## Política de Release

* Como funciona a esteira de release do projeto?
    Exemplo: o mesmo binário gerado deve ser promovido entre ambientes
* Onde é realizado a release? 
    Exemplo: TFS/VSTS
* O time realiza transformação de chaves por ambiente?
* Como o time lida com contéudo sensível?
    Exemplo: as chaves são criptografas, as chaves são armazenadas no VSTS (protegidas)
* Quais ambientes possuem deploy contínuo?
