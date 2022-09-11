using System;
using System.Collections.Generic;
using System.Text;

namespace AppHotelV2.Model
{
    public class Hospedagem
    {
        Quarto suite;
        public int QntAdultos { get; set; }
        public int QntCriancas { get; set; }
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }

        public Quarto Suite
        {
            get => suite;

            set
            {
                if (value == null) throw new Exception("Por favor, selecione uma suíte");
                suite = value;
            }
        }

        public int Estadia
        {
            get
            {
                return DataCheckOut.Subtract(DataCheckIn).Days;
            }
        }

        public double ValorTotal
        {
            get
            {
                return ((QntAdultos * Suite.ValorDiariaAdulto) + (QntCriancas * Suite.ValorDiariaCrianca)) * Estadia;
            }
        }
    }
}

            }
        }

    }
}
