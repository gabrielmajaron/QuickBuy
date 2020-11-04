using QuickBuy.Dominio.Entidades.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }

        public DateTime DataPrevisaoEntrega { get; set; }

        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco{ get; set; }

        public FormaPagamento FormaPagamento { get; set; }

        public int FormaPagamentoId { get; set; }

        // Um Pedido pode ter um item ou muitos itens
        ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();
            if(!ItensPedido.Any())
                MensagemValidacao.Add("Crítica - Pedido não pode ficar sem item de pedido");
            if (string.IsNullOrEmpty(CEP))
                MensagemValidacao.Add("Crítica - CEP deve estar preenchido");
        
        }
    }
}
