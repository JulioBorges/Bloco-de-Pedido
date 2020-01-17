using System;

namespace BlocoPedido.Object
{
    [Serializable]
    public class Parametros
    {
        public Int64 UltimoNumPedido { get; set; }
        public string NomeEmpresa { get; set; }

        public Parametros()
        {
            UltimoNumPedido = 0;
            NomeEmpresa = "Empresa Modelo";
        }
    }
}