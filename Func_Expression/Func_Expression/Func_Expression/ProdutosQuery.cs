using System;

namespace Func_Expression
{
    public static class ProdutosQuery
    {
        public static Func<Produto, bool> FiltroContainsNome(string nome)
        {
            return new Func<Produto, bool>(x => x.Nome.ToLower().Contains(nome.ToLower()));
        }

        public static Func<Produto, bool> FiltroValorMaiorIgual(decimal valor)
        {
            return new Func<Produto, bool>(x => x.Valor >= valor);
        }
    }
}
