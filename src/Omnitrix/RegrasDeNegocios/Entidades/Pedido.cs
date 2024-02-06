﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegrasDeNegocios.Entidades
{
    public class Pedido : EntidadeBase
    {
        public Pedido()
        {
            DataSolicitacao = DateTime.Now;
        }
        public string Descricao { get; set; }
        public Cliente Cliente { get; set; }
        public Hamburguer Hamburguer { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public DateTime? DataPreparacao { get; set; }
        public DateTime? DataSaidaEntrega { get; set; }
        public DateTime? DataFinalizacaoEntrega { get; set; }
    }
}
