// See https://aka.ms/new-console-template for more information

using Exercicio01.Interface;
using Exercicio1.Domain;


Console.WriteLine("Hello, World!");



var cartao = new PagamentoCartao();
var boleto = new PagamentoBoleto();
var paypal = new PagamentoPaypal();
Cliente cliente = new Cliente(1, "Rômulo");



Compra compra1 = new Compra(1, cliente, boleto);

paypal.EfetuarPagamento();
cartao.EfetuarPagamento();
boleto.EfetuarPagamento();

paypal.EstornarPagamento();
cartao.EstornarPagamento();
boleto.EstornarPagamento();