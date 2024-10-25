# LojaOnlineOOP

## Descrição
Este projeto foi desenvolvido como parte dos estudos de Programação Orientada a Objetos (POO). O objetivo é demonstrar a aplicação dos quatro pilares fundamentais da POO: Encapsulamento, Herança, Abstração e Polimorfismo. Utilizando C#, o sistema gerencia diferentes tipos de produtos, aplicando métodos como CalcularPrecoFinal e utilizando conceitos como sobrescrita de métodos e modificadores de acesso.

## Funcionalidades
Cadastro de Produtos: Produtos físicos e digitais.
Cálculo do Preço Final: Produtos físicos incluem impostos e custo de envio; produtos digitais aplicam descontos.

## Conceitos Aplicados
**Encapsulamento:** O atributo Produtos na classe Loja é privado, acessado e modificado por métodos get e set, controlando o acesso aos dados.
**Herança:** A classe Produto serve como base para as classes derivadas ProdutoFisico e ProdutoDigital, que herdam seus atributos e métodos.
**Abstração:** A classe Produto representa um conceito genérico de um produto, definindo seus principais atributos e métodos.
**Polimorfismo:** O método CalcularPrecoFinal é sobrescrito nas classes filhas para tratar os diferentes tipos de produtos, permitindo comportamentos distintos.

## Estrutura do Projeto
**Classes:**
  **Produto:** Classe base que contém os atributos e métodos comuns.
  **ProdutoFisico:** Classe que herda de Produto e inclui impostos e frete no cálculo do preço.
  **ProdutoDigital:** Classe que herda de Produto e aplica desconto no cálculo do preço.

## Tecnologias Utilizadas
**Linguagem:** C#
**Plataforma:** .NET
**IDE:** Visual Studio

## Como Executar
**Clone este repositório:**
Terminal git bash

**Copiar código:**
git clone https://github.com/HaslanDaitx/LojaOnlineOOP

Abra o projeto no Visual Studio.

Compile e execute o projeto para testar as funcionalidades de cadastro e cálculo de produtos.
