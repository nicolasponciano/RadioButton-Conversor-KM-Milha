﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioButton_tp_02
{
    internal class Converte
    {
        public string Valor { get; set; }

        public string converteKm()
        {
            return (float.Parse(Valor) / 1.60934).ToString();
        }

        public string converteMilha()
        {
            return (float.Parse(Valor) * 1.60934).ToString();
        }
    }
}
