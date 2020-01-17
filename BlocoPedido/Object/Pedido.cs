using System;
using System.Collections.Generic;

namespace BlocoPedido.Object
{
    using System.Linq;

    [Serializable]
    public class Pedido
    {
        public int NumPedido { get; set; }
        public DateTime DataPedido { get; set; }
        public byte[] Imagem { get; set; }
        public string RazaoSocial { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Fone { get; set; }
        public string Identificacao { get; set; }
        public string Cep { get; set; }
        public string Fax { get; set; }
        public string Insc_Estadual { get; set; }
        public string Cnpj { get; set; }
        public string Responsavel { get; set; }
        public string Garantia { get; set; }
        public string Frete { get; set; }
        public List<ItemPedido> ItensPedido { get; set; }
        public List<CondicaoPgto> Condicoes { get; set; }
        public string CondicaoSelecionada { get; set; }
        public string PrazoEntrega { get; set; }
        public string Observacoes { get; set; }
        public string Solicitacao { get; set; }

        public double ValorTotalPedido 
        {
            get
            {
                if ((ItensPedido == null) ||
                    !ItensPedido.Any())
                    return 0;

                return (from item in ItensPedido
                        select item.ValorTotal).Sum();
            }
        }
    }
}