using System;

namespace TesteClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();
            /*
            Console.WriteLine("Entre com os valores A,B e C do triagulo X: ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com os valores A,B e C do triagulo Y: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());
            double areaX = x.area();
            double areaY = y.area();

            Console.WriteLine("Lados do triangulo X A:{0} B:{1} C:{2} é igual a area {3}", x.A, x.B, x.C, x.area());
            Console.WriteLine("Lados do triangulo Y A:{0} B:{1} C:{2} é igual a area {3}", y.A, y.B, y.C, y.area());
            Console.ReadLine();
            */

            Produto pro = new Produto();

            pro.CadastrarProduto();
            Console.WriteLine(pro);
            Console.ReadLine();

            pro.AdicionarEstoque();
            Console.WriteLine(pro);
            Console.ReadLine();

        }
    }
}
