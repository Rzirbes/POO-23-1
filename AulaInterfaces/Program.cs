
using AulaInterfaces.Domain.Models;
using AulaInterfaces.Interface;

var loja = new Loja(new List<IItemEstoque>());
var roupa = new Roupa();

loja.AdicionarItem(roupa);
loja.VenderItem(0);

var calcado = new Calcado();
loja.AdicionarItem(calcado);

var brinquedo = new Brinquedo();
loja.AdicionarItem(brinquedo);

IItemEstoque brinquedo2 = new Brinquedo();