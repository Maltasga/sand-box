using System.Collections.Generic;
using System.Linq;

namespace Func_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Produto> produtos = ProdutoContext.GetProdutos();

            IEnumerable<Produto> produtosResult = produtos.Where(ProdutosQuery.FiltroValorMaiorIgual(50));

            foreach (Produto p in produtosResult)
            {
                System.Console.WriteLine(p.ToString());
            }
        }


    }
}
