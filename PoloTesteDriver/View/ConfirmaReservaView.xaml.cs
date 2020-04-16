using PoloTesteDriver.Model;
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
        public Agendamento Agendamento { get; set; }

        public Veiculo veiculo 
        {
            get 
            {
                return Agendamento.veiculo;
            }
            set
            {
                Agendamento.veiculo = value;
            }
        }

        public string Nome
        {
            get
            {
                return Agendamento.Nome;
            }
            set
            {
                Agendamento.Nome = value;
            }
        }

        public string Fone
        {
            get
            {
                return Agendamento.Fone;
            }
            set
            {
                Agendamento.Fone = value;
            }
        }

        public string Email
        {
            get
            {
                return Agendamento.Email;
            }
            set
            {
                Agendamento.Email = value;
            }
        }

        public DateTime DataAgendamento
        {
            get { return Agendamento.DataAgendamento; }
            set { Agendamento.DataAgendamento = value; }
        }
        public TimeSpan HoraAgendamento
        {
            get { return Agendamento.HoraAgendamento; }
            set { Agendamento.HoraAgendamento = value; }
        }

        public ConfirmaReservaView()
        {
            InitializeComponent();

            this.BindingContext = this;
        }

        public ConfirmaReservaView(Veiculo veiculo)
        {
            InitializeComponent();

            this.Agendamento = new Agendamento();

            this.Agendamento.veiculo = veiculo;

            this.BindingContext = this;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string Msg = "Veiculo: " + veiculo.Nome +
                         "\nNome: " + Nome +
                         "\nFone: " + Fone +
                         "\nE-mail: " + Email +
                         "\nData Agenda.: " + DataAgendamento.ToString("dd/MM/yyyy") + 
                         "\nHora Agenda.: " + HoraAgendamento;

            DisplayAlert("Confirmar Agendamento", Msg, "Sim");
        }
    }
}