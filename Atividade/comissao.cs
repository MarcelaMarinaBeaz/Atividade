using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class comissao
    {
        public int quant_v { get; set; }
        public double preco_produto { get; set; }
        public string Nome_vendedo { get; set; }

        public comissao(int v, double p, string nome)
        {
            this.quant_v = v;
            this.preco_produto = p;
            this.Nome_vendedo = nome;
        }
        public void Somar_Preco()
        {
            preco_produto = (quant_v * preco_produto);
        }
        public void Soma_Comissao()
        {
            double resultado = preco_produto = (preco_produto * 0.5);
            Console.WriteLine($"{Nome_vendedo} sua camissão sers: {resultado}");
        }
    }
}
