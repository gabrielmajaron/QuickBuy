using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    class Usuario
    {
        public int ID { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public string Nome { get; set; }

        public string SobreNome { get; set; }

        //public List<Pedido> Pedidos {get; set;}
        // Um Usuario pode ter nenhum ou muitos pedidos
        public ICollection<Pedido> Pedidos { get; set; }

        // Um Pedido pode ter um item ou muitos itens
        public ICollection<ItemPedido> ItensPedido { get; set; }
    }
}
