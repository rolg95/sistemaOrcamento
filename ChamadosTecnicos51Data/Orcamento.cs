﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Orcamento
    {
        public int CodigoOrcamento { get; set; }
        public int CodigoCliente { get; set; }
        public int CodigoTecnico { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public string? Ocorrencia { get; set; }
        public string? Problema { get; set; }
        public bool Concluido { get; set; }
    }
}
