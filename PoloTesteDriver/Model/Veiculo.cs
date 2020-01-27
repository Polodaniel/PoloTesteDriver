using System;
using System.Collections.Generic;
using System.Text;

namespace PoloTesteDriver.Model
{
    public class Veiculo
    {
        public const int FREIO_ABS = 800;
        public const int AR_CONDICIONADO = 1000;
        public const int VIDRO_ELETRICO = 650;
        public const int DIRECAO_HIDRAULICA = 1250;

        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string PrecoFormatado
        {
            get
            {
                return string.Format("R$: " + Preco);
            }
        }

        public bool TemFreioABS { get; set; }
        public bool TemArCondicionado { get; set; }
        public bool TemVidroEletrico { get; set; }
        public bool TemDirecaoHidraulica { get; set; }

        public string PrecoTotalFormatado 
        { 
            get 
            {
                return string.Format("Valor Total R$: " + (
                                            Preco
                                            + (TemFreioABS ? Veiculo.FREIO_ABS : 0)
                                            + (TemArCondicionado ? Veiculo.AR_CONDICIONADO : 0)
                                            + (TemVidroEletrico ? Veiculo.VIDRO_ELETRICO : 0)
                                            + (TemDirecaoHidraulica ? Veiculo.DIRECAO_HIDRAULICA : 0)
                                          )
                    );
            } 
        }
    }
}
