using System;

namespace BlocoPedido.Object
{
    using System.ComponentModel;
    
    [Serializable]
    public class ItemPedido
    {
        [DefaultValue(0)]
        public int Codigo { get; set; }
        
        [DefaultValue(0)]
        public int Quantidade { get; set; }

        [DefaultValue("")]
        public string Descricao { get; set; }

        [DefaultValue(0)]
        public double ValorUn { get; set; }

        public double ValorTotal
        {
            get { return ValorUn * Quantidade; }
        }
    }
}
