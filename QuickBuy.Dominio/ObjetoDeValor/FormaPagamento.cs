using QuickBuy.Dominio.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades.ObjetoDeValor
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public bool isTipoBoleto
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Boleto; }
        }

        public bool isTipoCartaoCredito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.CartaoCredito; }
        }

        public bool isTipoNaoDefinido
        {
            get { return Id == (int)TipoFormaPagamentoEnum.NaoDefinido; }
        }

        public bool isTipoTransferencia
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Transferencia; }
        }

    }
}
