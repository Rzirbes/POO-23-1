using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AulaInterfaces.Interface;

namespace AulaInterfaces.Domain.Models
{
    public class Loja
    {
        private List<IItemEstoque> _itensEmEstoque;

        public Loja(List<IItemEstoque> itensEmEstoque)
        {
            _itensEmEstoque = itensEmEstoque;
        }

        public void AdicionarItem(IItemEstoque item) 
        { 
            _itensEmEstoque.Add(item);    
        }

        public void VenderItem(int index) 
        { 
            _itensEmEstoque[index].Vender();
            _itensEmEstoque.RemoveAt(index);    
        }

        
    }
}