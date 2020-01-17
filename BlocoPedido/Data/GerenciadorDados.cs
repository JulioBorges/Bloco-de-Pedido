using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using System.IO;
using System.Text;
using BlocoPedido.Object;

namespace BlocoPedido.Data
{
    public static class GerenciadorDados
    {
        // Objetos de dados
        public static ContainerDados Dados;
        public static string ArquivoXmlDados = @"Data\Dados.xml";
        public static string ImagemEmpresa = @"Data\Empresa.logo";
        public static string ObservacaoPadrao = "Será cobrado do cliente todo e qualquer material, inclusive mão de obra que se tornar indispensável " +
                                                "para a construção da rede secundária. Cujo os preços estão condicionados à data do efetivo pagamento. " +
                                                "Para serviços executados fora do horario comercial serão cobrados os encargos determinados pela " +
                                                "legislaçao trabalhista.";

        public static void CarregaDadosArquivos()
        {
            Dados = new ContainerDados();

            if (File.Exists(ArquivoXmlDados))
                CarregaXml(ref Dados, ArquivoXmlDados);
            else
            {
                Dados.Inicializar();
                Dados.SalvaXml(ArquivoXmlDados);
            }
        }

        public static void CarregaXml(ref ContainerDados objetoCarregamento, string caminhoArquivo)
        {
            if (objetoCarregamento == null) 
                throw new ArgumentNullException("objetoCarregamento");

            TextReader reader = new StreamReader(caminhoArquivo, Encoding.UTF8);
            var x = new XmlSerializer(objetoCarregamento.GetType());
            objetoCarregamento = x.Deserialize(reader) as ContainerDados;
        }

        public static void SalvaXml(this object objetoCriacao, string caminhoArquivo)
        {
            TextWriter writer = new StreamWriter(caminhoArquivo, false, Encoding.UTF8);
            var x = new XmlSerializer(objetoCriacao.GetType());
            x.Serialize(writer, objetoCriacao);
            writer.Flush();
            writer.Close();
        }

        public static void SalvaDados()
        {
            Dados.SalvaXml(ArquivoXmlDados);
        }

        public static IEnumerable<DadosCondicaoPgto> GetCondicoes(double vlrTotalPedido)
        {
            return Dados.CondicoesPgto.Select(condicao => new DadosCondicaoPgto
            {
                Codigo = condicao.Codigo,
                Descricao = condicao.Descricao,
                TaxaJuros = condicao.TaxaJuros,
                NrParcelas = condicao.NrParcelas,
                ValorTotalPedido = vlrTotalPedido
            }).ToList();
        }
    }
}