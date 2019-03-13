using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace TesteClasses
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        private int Quantidade;

        //PROPERTIE é equivalente ao get/set
        public string Nome
        {
            get { return _nome; }
            set {
                _nome = value;
            }
        }

        

        public override string ToString()
        {
            return _nome
                + ", $"
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantidade em estoque:"
                + Quantidade;
        }

        public void CadastrarProduto()
        {
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome do Produto: ");
            _nome = Console.ReadLine();
            Console.Write("\nPreço do produto: ");
            Preco = double.Parse(Console.ReadLine());
            Console.Write("\nQuantidade em estoque: ");
            Quantidade = int.Parse(Console.ReadLine());

        }


        public void AdicionarEstoque()
        {
            Console.Write("\nAdicione a quantidade ao estoque de {0}: ", _nome);
            Quantidade += int.Parse(Console.ReadLine());

        }
    }
}
