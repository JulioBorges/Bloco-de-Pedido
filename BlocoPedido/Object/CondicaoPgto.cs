using System;

namespace BlocoPedido.Object
{
    [Serializable]
    public class CondicaoPgto
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public int NrParcelas { get; set; }
        public double TaxaJuros { get; set; }
    }
}