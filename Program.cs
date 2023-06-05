//Bibliotecas na versão de C#. São bem mais práticas por conter uma enorme variedade de bibliotecas se compsarada com o C++, porém são mais lentas.
using System;
using System.Globalization;
namespace Course
{   //Classe Triângulo.
    public class Triangulo
    {   //Variáveis usando encapsulamento. Get e Set são modificadores usados para controlar o acesso e modificação dos valores dos atibutos da classe.
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        //Função da equação.
        public double CalcularArea()
        {   //Calculo para achar a metade do perímetro do triângulo.
            double p = (A + B + C) / 2.0;
            //Calculo feito para achar o valor final da área do triângulo.
            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            //Valor devolvido para a variável area.
            return area;
        }
    }
    //Classe onde o programa fica.
    public class Program
    {   //Função principal do programa. Ela vai mostrar os resultados para o usuário.
        public static void Main(string[] args)
        {   //Variável X e Y.
            Triangulo x = LerTriangulo("X");
            Triangulo y = LerTriangulo("Y");
            //Definindo os valores da area do trinagulo x e y.
            double areaX = x.CalcularArea();
            double areaY = y.CalcularArea();
            //Interface que mostrará o valor para o usuário, além de arredondar o valor até 4 casas depois da vírgula.
            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            //Condicioinal feita para mostrar ao usuário qual dos dois pe maior.
            if (areaX > areaY)
            {   //Caso X seja maior.
                Console.WriteLine("Maior área: X");
            }
            else //Caso Y seja maior.
            {
                Console.WriteLine("Maior área: Y");
            }
        }
        //Parte do código que irá aparecer para o usuário colocar as informações necessárias.
        public static Triangulo LerTriangulo(string nomeTriangulo)
        {   //Região onde chamamos a classe Triangulo.
            Triangulo triangulo = new Triangulo();
            //Interface interativa para o usuário.
            Console.WriteLine("Entre com as medidas  do triângulo " + nomeTriangulo + ":");
            //Interface que irá receber os valores e depois irá mandá-los para as funções e assim realizar a equação.
            triangulo.A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            triangulo.B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            triangulo.C = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            return triangulo;
        }
    }
}
