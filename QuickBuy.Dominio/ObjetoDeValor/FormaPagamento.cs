using QuickBuy.Dominio.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.ObjetoDeValor
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public Boolean Ehboleto
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Boleto; }
        }

        public Boolean EhCartaoCredito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.CartaoCredito; }

        }

        public Boolean EhCartaoDeposito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Deposito; }

        }

        public Boolean ÑaoFoiDefinido
        {
            get { return Id == (int)TipoFormaPagamentoEnum.NaoDefinido; }

        }
    }

}
