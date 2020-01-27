using PoloTesteDriver.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PoloTesteDriver.ViewModel
{
    public class ListagemViewModel
    {
        public List<Veiculo> Veiculos { get; set; }

        public ListagemViewModel()
        {
            this.Veiculos = new ListagemVeiculos().Veiculos;
        }
    }
}
