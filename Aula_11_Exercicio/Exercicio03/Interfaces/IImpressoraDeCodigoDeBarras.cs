using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicio03.Domain;

namespace Exercicio03.Interfaces
{
    public interface IImpressoraDeCodigoDeBarras
    {
        public void ImprimirEtiqueta(Produto produto);
    }
}