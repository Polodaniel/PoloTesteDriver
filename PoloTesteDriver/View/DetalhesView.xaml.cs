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
        private const int FREIO_ABS = 800;
        private const int AR_CONDICIONADO = 1000;
        private const int VIDRO_ELETRICO = 650;
        private const int DIRECAO_HIDRAULICA = 1250;

        public string ValorTotal 
        {
            get 
            {
                return string.Format("Valor Total R$: " + (
                                                            veiculo.Preco 
                                                            + (TemFreioABS ? FREIO_ABS : 0)
                                                            + (TemArCondicionado ? AR_CONDICIONADO : 0)
                                                            + (TemVidroEletrico ? VIDRO_ELETRICO : 0)
                                                            + (TemDirecaoHidraulica ? DIRECAO_HIDRAULICA : 0)
                                                          )
                                    );
            }
        }

        public Veiculo veiculo { get; set; }

        #region Texto dos Componentes
        public string TextoFeioABS 
        {
            get
            {
                return string.Format("Freio ABS R$: " + FREIO_ABS);
            }
        }

        public string TextoArCondicionado
        {
            get
            {
                return string.Format("Ar Condicionado R$: " + AR_CONDICIONADO);
            }
        }

        public string TextoVidroEletrico
        {
            get
            {
                return string.Format("Vidro Eletrico R$: " + VIDRO_ELETRICO);
            }
        }

        public string TextoDirecaoHidraulica
        {
            get
            {
                return string.Format("Direcao Hidraulica R$: " + DIRECAO_HIDRAULICA);
            }
        }
        #endregion

        #region Propriedades de Controle
        private bool temFreioBS;

        public bool TemFreioABS 
        {
            get 
            {
                return temFreioBS;
            }
            set 
            {
                temFreioBS = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        private bool temArCondicionado;

        public bool TemArCondicionado
        {
            get
            {
                return temArCondicionado;
            }
            set
            {
                temArCondicionado = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        private bool temVidroEletrico;

        public bool TemVidroEletrico
        {
            get
            {
                return temVidroEletrico;
            }
            set
            {
                temVidroEletrico = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        private bool temDirecaoHidraulica;

        public bool TemDirecaoHidraulica
        {
            get
            {
                return temDirecaoHidraulica;
            }
            set
            {
                temDirecaoHidraulica = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        #endregion


        public DetalhesView()
        {
            InitializeComponent();
        }

        public DetalhesView(Veiculo veiculo)
        {
            InitializeComponent();

            this.veiculo = veiculo;

            // Nome da Tela
            //this.Title = this.veiculo.Nome;

            // Biding para passar o Nome da Tela
            this.BindingContext = this;

        }

        private void btnProximo_Clicked(object sender, EventArgs e)
        {
            // Comando para Abrir uma nova tela
            Navigation.PushAsync(new ConfirmaReservaView(this.veiculo), true);
        }
    }
}