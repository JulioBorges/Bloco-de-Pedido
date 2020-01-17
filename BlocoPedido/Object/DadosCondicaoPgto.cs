using System;

namespace BlocoPedido.Object
{
    public class DadosCondicaoPgto
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public int NrParcelas { get; set; }
        public double TaxaJuros { get; set; }
        public double ValorTotalPedido { get; set; }

        public double ValorTotalComJuros
        {
            get
            {
                if (Math.Abs(ValorTotalPedido - 0) < double.Epsilon)
                    return 0;

                return (ValorTotalPedido*TaxaJuros);
            }
        }

        public double VlrParcela
        {
            get
            {
                if ((Math.Abs(ValorTotalPedido - 0) < double.Epsilon) || (NrParcelas == 0))
                    return 0;

                return (ValorTotalPedido*TaxaJuros)/NrParcelas;
            }
        }
    }
}