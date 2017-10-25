using System.Collections.Generic;

namespace Func_Expression
{
    public class ProdutoContext
    {
        private readonly static IList<Produto> _produtos = new List<Produto>()
        {
            new Produto(1, "Mouse Logitech", 53.9M),
            new Produto(2, "Teclado Dell ABNT2", 35.0M),
            new Produto(3, "Desktop Dell Optiplex 3040", 3987.8M),
            new Produto(4, "Cabo HDMI", 27.8M),
            new Produto(5, "Fone de Ouvido Bluetooth", 198.5M),
            new Produto(6, "Kindle Paperwhite", 384.1M),
            new Produto(7, "Motorola Z Play", 1850.0M),
            new Produto(8, "Cadeira Escritório", 299.9M),
            new Produto(9, "Caderno 100 folhas", 3.9M),
            new Produto(10, "Agenda Personalizada", 13.0M),
            new Produto(11, "Mochila BaoHua", 153.1M),
            new Produto(12, "Anorak Quechua", 199.99M),
            new Produto(13, "Mouse Pad", 9.9M)
        };

        public static IEnumerable<Produto> GetProdutos()
        {
            return _produtos;
        }
    }
}
