using System;
using System.Globalization;

namespace csharp_oop {
    class Program {
        static void Main(string[] args) {
            //calculaTrianguloAB();
           // idadePessoa();
            mediaSalario();
        }
        public static void calculaTrianguloAB() {

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();


            Console.WriteLine("Entre com as medidas do Triangulo X ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Entre com as medidas do Triangulo Y ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;

            double areaX = Math.Sqrt(p * (p - x.A) * p * (p - x.B) * p * (p - x.C));

            p = (x.A + x.B + x.C) / 2.0;

            double areaY = Math.Sqrt(p * (p - y.A) * p * (p - y.B) * p * (p - y.C));

            Console.WriteLine("Área de X igual: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de y igual: " + areaX.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY) {
                Console.WriteLine("Maior área: X ");
            } else {
                Console.WriteLine("Maior área: Y ");
            }

        }
        public static void idadePessoa() {
            Pessoa A, B;

            A = new Pessoa();
            B = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            A.Nome = Console.ReadLine();
            A.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            B.Nome = Console.ReadLine();
            B.Idade = int.Parse(Console.ReadLine());

            int idade1 = A.Idade;
            int idade2 = B.Idade;

            if (idade1 > idade2) {
                Console.WriteLine("Pessoa mais velha é: " + A.Nome);
            } else {
                Console.WriteLine("Pessoa mais velha é: " + B.Nome);
            }

        }
        public static void mediaSalario() {

            Funcionario A , B ;

            A = new Funcionario();
            B = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario: ");
            A.Nome = Console.ReadLine();
            A.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("Dados do segundo funcionario: ");
            B.Nome = Console.ReadLine();
            B.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaSalarial = (A.salario + B.salario) / 2.0;

            Console.WriteLine("Salário médio = " + mediaSalarial.ToString("F2", CultureInfo.InvariantCulture));

        }

    }
}
