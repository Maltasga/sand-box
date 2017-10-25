
namespace Func_Expression
{
    public class Produto
    {
        public Produto(int id, string nome, decimal valor)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", Id, Nome, Valor.ToString("c"));
        }
    }
}
