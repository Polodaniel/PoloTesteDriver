using PoloTesteDriver.Model;
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
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
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
