using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista4PROG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1- é falsa, pois uma variavel int so recebe numeros inteiros e não consegue trabalhar com números depois da vírgula.
            // int v;
            //v = float.Parse(Console.ReadLine());
            // ja no contrario pode ser possivel jogar um float dentro de um int
            // float v;
            //   v = int.Parse(Console.ReadLine());


            //-----------------------------------------------------------------------------------------------------------------------------------------------------

            //2-o console.read.line() retorna o valor da linha interia que o usuario passa, ja o Console. Read() Retorna o valor em ASCII do primeiro caractere digitado na linha, ele lê e faz a conversão.


            //----------------------------------------------------------------------------------------------------------------------------------------------

            //3-tem que tomar cuidado com o tipo de exercico que é pedido, pois essas variaveis sao apenas para numeros e tomar cuidado com o tipo de numero que elas recebem

            //-------------------------------------------------------------------------------------------------------------------------------------------------

            //4- numero 8 aparece mensagem 2, numero 27 aparece mensagem 2 e por ultimo o numero 28 aparece mensagem 1.
            //int num, num2, num3;
            //Console.WriteLine("entre com algum numero : ");
            //num = int.Parse(Console.ReadLine());
            //num2 = num / 2;

            //num3 = num % 2;
            //if ( num3 == 0 && num2*2 > 10)
            // Console.WriteLine("mensagem 1");

            //  else
            //    Console.WriteLine("mensagem 2");

            //Console.ReadKey();
            //-------------------------------------------------------------------------------

            //float s, so, v, t;
            //Console.WriteLine("qual a velocidade?");
            //v = float.Parse(Console.ReadLine());
            //Console.WriteLine("qual a posição inicial ?");
            //so = float.Parse(Console.ReadLine());
            //Console.WriteLine("qual o instante?");
            //t = float.Parse(Console.ReadLine());

            //s = so + v * t;
            //Console.WriteLine("a posição final é " + s);
            //Console.ReadKey();
            //5-exercico 

            //--------------------------------------------------------------------------------------

            //6-exercico

            //  int n;
            //  Console.WriteLine("digite um numero:");
            //  n = int.Parse(Console.ReadLine());

            //if (n % 3 == 0 && n % 5 == 0 && n % 10 == 0) {
            //      Console.WriteLine($"o numero {n} é divisivel por 3,5 e 10");
            //  }
            //else if (n % 3 == 0 && n % 5 == 0) {
            //      Console.WriteLine($"o numero {n} é divisivel por 3 e 5");
            //  }
            //else if (n % 3 == 0)
            //  {
            //      Console.WriteLine($"o numero {n} é divisivel por 3");
            //  }
            //  else if (n  % 5 == 0)
            //  {
            //      Console.WriteLine($"o numero {n} é divisivel por 5");
            //  }
            //else
            //  {
            //      Console.WriteLine("numero não é divisivel por 3 nem por 5 e nem por 10");
            //  }

            //Console.ReadKey();


            //-------------------------------------------------------------------


            // 7- exercicio
            //int casaKm;
            //double disCasEsc, temEscCasa, TemCasaEsc, temTotal,DisEscCasa;
            //Console.Write("Informe o km da sua casa: ");
            // casaKm = int.Parse(Console.ReadLine());


            // disCasEsc = (100 - casaKm) * 0.6;
            // DisEscCasa = casaKm * 0.4;

            //TemCasaEsc = disCasEsc / 15; // considerando velocidade média de 15 km/h
            //temEscCasa = DisEscCasa / 10; // considerando velocidade média de 10 km/h
            // temTotal = TemCasaEsc + temEscCasa;
            //Console.WriteLine("Tempo gasto: " + temTotal + " horas.");

            //Console.ReadKey();

            //fiz dessa maneira pois não entendi a tabela, entao coloquei uma média de ida e de volta para calcular
            //--------------------------------------------------------------------------------------

            //8-exercicio

            //double marc, quant, total, custo, imp, custof, luc;

            //Console.WriteLine("=======MARCAS=======");
            //Console.WriteLine("1 ROYAL");
            //Console.WriteLine("2 WISKAS");
            //Console.WriteLine("3 GOLDEN");
            //Console.WriteLine("4 NUTRIEN");
            //Console.WriteLine("5 SPECIALCAT");
            //Console.WriteLine("6 MARBA");
            //Console.WriteLine("7 GATUS");

            //Console.WriteLine("escolha uma marca:");
            //marc = double.Parse(Console.ReadLine());
            //Console.WriteLine("escolha a quantidade");
            //quant = double.Parse(Console.ReadLine());

            //switch (marc)
            //{

            //    case 1:
            //        total = 129.50 * quant;
            //        custo = total * 0.775;
            //        custof = total - custo;
            //        imp = custof * 0.33;
            //        luc = (total - custof) - imp;


            //        break;
            //    case 2:
            //        total = 182.78 * quant;
            //        custo = total * 0.897;
            //        custof = total - custo;
            //        imp = custof * 0.275;
            //        luc = (total - custof) - imp;


            //        break;
            //    case 3:
            //        total = 159.46 * quant;
            //        custo = total * 0.717;
            //        custof = total - custo;
            //        imp = custof * 0.225;
            //        luc = (total - custof) - imp;


            //        break;
            //    case 4:
            //        total = 144.80 * quant;
            //        custo = total * 0.889;
            //        custof = total - custo;
            //        imp = custof * 0.25;
            //        luc = (total - custof) - imp;


            //        break;
            //    case 5:
            //        total = 205.40 * quant;
            //        custo = total * 0.8324;
            //        custof = total - custo;
            //        imp = custof * 0.22;
            //        luc = (total - custof) - imp;


            //        break;
            //    case 7:
            //        total = 133.99 * quant;
            //        custo = total * 0.946;
            //        custof = total - custo;
            //        imp = custof * 0.20;
            //        luc = (total - custof) - imp;


            //        break;
            //    case 6:
            //        total = 125.10 * quant;
            //        custo = total * 0.904;
            //        custof = total - custo;
            //        imp = custof * 0.179;
            //        luc = (total - custof) - imp;


            //        break;
        







    }
    }
}
