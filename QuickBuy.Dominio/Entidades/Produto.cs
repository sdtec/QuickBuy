﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();

            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarCritica("Crítica: Nome precisa ser informado");
            }

            if (string.IsNullOrEmpty(Descricao))
            {
                AdicionarCritica("Crítica: Descricao precisa ser informado");
            }
        }
    }
}
