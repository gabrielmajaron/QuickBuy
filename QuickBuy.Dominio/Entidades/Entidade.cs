using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {

        protected List<string> _mensagensValidacao { get; set; }
        public List<string> MensagemValidacao 
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }

        public abstract void Validate();
        protected bool isValido
        {
            get { return !MensagemValidacao.Any(); }
        }

        protected void LimparMensagemValidacao()
        {
            MensagemValidacao.Clear();
        }
    }
}
