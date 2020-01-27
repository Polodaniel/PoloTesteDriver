using System;
using System.Collections.Generic;
using System.Text;

namespace PoloTesteDriver.Model
{
    public class Agendamento
    {
        public Veiculo veiculo { get; set; }

        public string Nome { get; set; }
        public string Fone { get; set; }
        public string Email { get; set; }

        private DateTime _dataAgendamento = DateTime.Today;
        public DateTime DataAgendamento
        {
            get { return _dataAgendamento; }
            set { _dataAgendamento = value; }
        }

        private TimeSpan _horaAgendamento;

        public TimeSpan HoraAgendamento
        {
            get { return _horaAgendamento; }
            set { _horaAgendamento = value; }
        }
    }
}
