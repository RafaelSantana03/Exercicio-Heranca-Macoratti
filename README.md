# Exercício de Herança - Macoratti

## Descrição

Estou revisando os conceitos de Programação Orientada a Objetos e, nesta semana, estudei o conceito de Herança. O professor Macoratti passou um exercício para resolver, e esta é a minha solução. Ficou bem diferente da solução dele, mas decidi não mudar o meu código.

## Estrutura do Projeto

O projeto consiste em um sistema bancário simples com três tipos de contas:

1. **Conta Corrente**:
   - Pode realizar depósitos, saques e exibir o saldo.
   
2. **Conta Poupança**:
   - Herda de Conta Corrente.
   - Aplica uma taxa de juros de 0,5% em cada depósito.
   - Não permite saldo negativo.

3. **Conta de Investimento**:
   - Herda de Conta Corrente.
   - Aplica uma taxa de remuneração de 0,9% em cada depósito.
   - Aplica uma taxa de 0,1% em cada saque.
   - Não permite saldo negativo.
