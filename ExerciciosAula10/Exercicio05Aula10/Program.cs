// See https://aka.ms/new-console-template for more information
using Exercicio05Aula10;

Console.WriteLine("Hello, World!");

var cartao = new PagamentoCartao();
var boleto = new PagamentoBoleto();
var paypal = new PagamentoPaypal();

paypal.EfetuarPagamento();
cartao.EfetuarPagamento();
boleto.EfetuarPagamento();

paypal.EstornarPagamento();
cartao.EstornarPagamento();
boleto.EstornarPagamento();