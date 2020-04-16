using PoloTesteDriver.Model;
using PoloTesteDriver.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PoloTesteDriver.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalhesView : ContentPage
    {
        public Veiculo veiculo { get; set; }

        public DetalhesView()
        {
            InitializeComponent();
        }

        public DetalhesView(Veiculo veiculo)
        {
            InitializeComponent();
            this.veiculo = veiculo;

            this.BindingContext = new DetalhesViewModel(veiculo);
        }

        private void btnProximo_Clicked(object sender, EventArgs e)
        {
            // Comando para Abrir uma nova tela
            Navigation.PushAsync(new ConfirmaReservaView(this.veiculo), true);
        }
    }
}