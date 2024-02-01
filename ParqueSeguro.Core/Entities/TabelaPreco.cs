﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueSeguro.Core.Entities
{
    public class TabelaPreco : BasicEntity
    {
        public TabelaPreco(DateTime dataInicio, DateTime dataFinal, double valorInicial, double valorAdicional)
        {
            DataInicio = dataInicio;
            DataFinal = dataFinal;
            ValorInicial = valorInicial;
            ValorAdicional = valorAdicional;
        }

        public DateTime DataInicio { get; set; }

        public DateTime DataFinal { get; set; }
        public double ValorInicial { get; set; }
        public double ValorAdicional { get; set; }
    }
}
