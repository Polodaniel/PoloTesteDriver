using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using PoloTesteDriver.Model;

namespace PoloTesteDriver.ViewModel
{
    public class DetalhesViewModel : INotifyPropertyChanged
    {
        public string ValorTotal
        {
            get
            {
                return veiculo.PrecoTotalFormatado;
            }
        }

        public Veiculo veiculo { get; set; }

        public DetalhesViewModel(Veiculo veiculo)
        {
            this.veiculo = veiculo;
        }

        #region Texto dos Componentes
        public string TextoFeioABS
        {
            get
            {
                return string.Format("Freio ABS R$: " + Veiculo.FREIO_ABS);
            }
        }

        public string TextoArCondicionado
        {
            get
            {
                return string.Format("Ar Condicionado R$: " + Veiculo.AR_CONDICIONADO);
            }
        }

        public string TextoVidroEletrico
        {
            get
            {
                return string.Format("Vidro Eletrico R$: " + Veiculo.VIDRO_ELETRICO);
            }
        }

        public string TextoDirecaoHidraulica
        {
            get
            {
                return string.Format("Direcao Hidraulica R$: " + Veiculo.DIRECAO_HIDRAULICA);
            }
        }
        #endregion

        #region Propriedades de Controle

        public bool TemFreioABS
        {
            get
            {
                return veiculo.TemFreioABS;
            }
            set
            {
                veiculo.TemFreioABS = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        public bool TemArCondicionado
        {
            get
            {
                return veiculo.TemArCondicionado;
            }
            set
            {
                veiculo.TemArCondicionado = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        public bool TemVidroEletrico
        {
            get
            {
                return veiculo.TemVidroEletrico;
            }
            set
            {
                veiculo.TemVidroEletrico = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        public bool TemDirecaoHidraulica
        {
            get
            {
                return veiculo.TemDirecaoHidraulica;
            }
            set
            {
                veiculo.TemDirecaoHidraulica = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string name = "")
        {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}
