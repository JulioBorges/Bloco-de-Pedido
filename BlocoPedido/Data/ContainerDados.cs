using System;
using System.Collections.Generic;
using BlocoPedido.Object;

namespace BlocoPedido.Data
{
    [Serializable]
    public class ContainerDados
    {
        public Parametros ParametrosApp { get; set; }
        public List<CondicaoPgto> CondicoesPgto { get; set; }
        public List<Pedido> PedidosArmazenados { get; set; }

        public void Inicializar()
        {
            ParametrosApp = new Parametros();

            CondicoesPgto = new List<CondicaoPgto>
                                {
                                    new CondicaoPgto
                                        {
                                            Codigo = 1,
                                            Descricao = "Uma no Pedido",
                                            NrParcelas = 1,
                                            TaxaJuros = 1
                                        },
                                    new CondicaoPgto
                                        {
                                            Codigo = 2,
                                            Descricao = "1 + 30 ddp",
                                            NrParcelas = 2,
                                            TaxaJuros = 1.015
                                        },
                                    new CondicaoPgto
                                        {
                                            Codigo = 3,
                                            Descricao = "1 + 30/60 ddp",
                                            NrParcelas = 3,
                                            TaxaJuros = 1.030
                                        },
                                    new CondicaoPgto
                                        {
                                            Codigo = 4,
                                            Descricao = "1 + 30/60/90 ddp",
                                            NrParcelas = 4,
                                            TaxaJuros = 1.069
                                        }
                                };
        }
    }
}