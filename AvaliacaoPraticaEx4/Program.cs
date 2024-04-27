// ./Program.cs
using System;

// EXERCICIO 4 - Não foi utilizado nenhum PROMPT.

Console.WriteLine();
Produto produto = new Produto("iPhone 13", 3298.75, 15);
Console.WriteLine("Nome: " + produto.Nome);
Console.WriteLine("Preço: " + produto.Preco);
Console.WriteLine("Quantidade de produtos em estoque: " + produto.QuantidadeEmEstoque);

Console.WriteLine();

produto.adicionarEstoque(5);
Console.WriteLine("Quantidade de produtos em estoque após a adição: " + produto.QuantidadeEmEstoque);

Console.WriteLine();

produto.removerEstoque(3);
Console.WriteLine("Quantidade de produtos em estoque após a remoção: " + produto.QuantidadeEmEstoque);

Console.WriteLine();

double valorTotal = produto.CalcularValorTotalEstoque();
Console.WriteLine("O valor total em produtos do estoque atualizado é R$" + valorTotal);

