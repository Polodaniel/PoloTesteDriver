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
    public partial class ConfirmaReservaView : ContentPage
    {
        public Veiculo veiculo { get; set; }

        public string Nome { get; set; }
        public string Fone { get; set; }
        public string Email { get; set; }

        public ConfirmaReservaView()
        {
            InitializeComponent();

            this.BindingContext = this;
        }

        public ConfirmaReservaView(Veiculo veiculo)
        {
            InitializeComponent();

            this.veiculo = veiculo;

            this.BindingContext = this;
        }
    }
}