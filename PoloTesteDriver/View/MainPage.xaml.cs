using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PoloTesteDriver.View
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    public class Veiculo
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public string PrecoFormatado
        {
            get
            {
                return string.Format("R$: " + Preco);
            }
        }
    }

    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public List<Veiculo> Veiculos { get; set; }

        public MainPage()
        {
            InitializeComponent();

            this.Veiculos = new List<Veiculo>
            {
                new Veiculo { Nome = "Azera V6", Preco = 85000 },
                new Veiculo { Nome = "Onix 1.6", Preco = 35000 },
                new Veiculo { Nome = "Fiesta 2.0", Preco = 52000 },
                new Veiculo { Nome = "C3 1.0", Preco = 22000 },
                new Veiculo { Nome = "Uno Fire", Preco = 11000 },
                new Veiculo { Nome = "Sentra 2.0", Preco = 53000 },
                new Veiculo { Nome = "Astra Sedan", Preco = 39000 },
                new Veiculo { Nome = "Vectra 2.0", Preco = 37000 },
                new Veiculo { Nome = "Hilux 4x4", Preco = 90000 },
                new Veiculo { Nome = "Montana", Preco = 57000 },
                new Veiculo { Nome = "Outlander 2.4", Preco = 90000 },
                new Veiculo { Nome = "Polo", Preco = 27000}
            };

            listViewVeiculos.ItemsSource = this.Veiculos;
        }

        private void listViewVeiculos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var veiculo = (Veiculo)e.Item;

            // Abre um Alerta com a Descrição e Preço do Produto
            //DisplayAlert("Veiculo Selecionado ?", " Nome: " + veiculo.Nome + "\n Preço " + veiculo.PrecoFormatado, "Sim");

            // Comando para Abrir uma nova tela
            Navigation.PushAsync(new DetalhesView(veiculo), true);

        }
    }
}
