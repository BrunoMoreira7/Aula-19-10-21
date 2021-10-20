using System;

namespace ConsoleApp1___InvertendoConteudoVariavel_19_10_21
{
    class Program
    {
        static void Main(string[] args)
        {


            //Exercicio - Celcius para Farheint

            //double F, C;

            //Console.Write("Digite a temperatura em Celsius");
            //C = double.Parse(Console.ReadLine());

            //F = (((9 * C) + 160) / 5);

            //Console.WriteLine("O valor disponibilizado em Celcius convertido em Fahrenheit é: " + F);

            //Console.ReadKey();


            // --------------------------------------------------------------------------------------------------------------------


            // Exercicio - Entrar com 3 notas de um aluno e imprimir a média(nota) final.

            //int nota1, nota2, nota3, div = 3, resultado;

            //Console.WriteLine("Informe a primeira nota");
            //nota1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Informe a segunda nota");
            //nota2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Informe a terceira nota");
            //nota3 = int.Parse(Console.ReadLine());

            //resultado = (nota1 + nota2 + nota3) / div;

            //Console.WriteLine("A média das tres notas é de: " + resultado);


            // --------------------------------------------------------------------------------------------------------------------


            // Exercicio - Ler um numero e mostrar seu antecessor e seu sucessor.

            //Console.WriteLine("Digite um numero: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("O número digitado foi {0}, o Antecessor {1} e o Sucessor {2}", n, n -= 1, n += 2);



            // --------------------------------------------------------------------------------------------------------------------

            // Exercicio - Para uma eleição, receba o numero de eleitores, a quantidade de votos brancos, nulos e validos. Mostre o percentual de cada tipo de voto.

            //int total, qntVbrancos, qntVnulos, qntVvalidos, brancosP, nulosP, validosP;

            //Console.WriteLine("Informar quantidade de votos brancos");
            //qntVbrancos = int.Parse(Console.ReadLine());
            //Console.WriteLine("Informar quantidade de votos nulos");
            //qntVnulos = int.Parse(Console.ReadLine());
            //Console.WriteLine("Informar quantidade de votos validos");
            //qntVvalidos = int.Parse(Console.ReadLine());

            //total = qntVbrancos + qntVnulos + qntVvalidos;

            //brancosP = (qntVbrancos * 100) / total;
            //nulosP = (qntVnulos * 100) / total;
            //validosP = (qntVvalidos * 100) / total;

            //Console.WriteLine("O percentual de votos brancos é de " + brancosP);
            //Console.WriteLine("O percentual de votos brancos é de " + validosP);
            //Console.WriteLine("O percentual de votos brancos é de " + nulosP);


            // ------------------------------------------------------------------------------------------------------------------------------------------------------------

            //Exercicio - //Suponha que um vendedor de carros trabalhe em uma empresa onde todos os veículos custem 30.000 reais.
            //Faça um programa que leia o nome do funcionário, o seu salario base(Exemplo: 1000), e a quantidade de veículos vendidos.
            //Para cada veiculo vendido ele recebe 15 % de comissão, que deve ser somado ao seu salario.Apresente o novo salario da mesma forma do exercício anterior.

            //double salario;
            //string nome;
            //int qtdCarro;
            //double carro = 30000 * 0.15;



            //Console.WriteLine("Digite o nome do funcionário: ");
            //nome = Console.ReadLine();



            //Console.WriteLine("Digite o salário: ");
            //salario = Convert.ToDouble(Console.ReadLine());



            //Console.WriteLine("Digite a quantidade de veículos: ");
            //qtdCarro = Convert.ToInt32(Console.ReadLine());



            //Console.WriteLine("O salario será de R$: {0}", ((carro * qtdCarro) + salario));


            // -----------------------------------------------------------------------------------------------------------------------------------------------------------

            //Exercicio - Faça um programa onde o salario e o percentual de aumento são entradas. A saída é o novo salário.

            //double salario, perc, novoSalario;

            //Console.WriteLine("Informe seu salario atual:");
            //salario = double.Parse(Console.ReadLine());


            //Console.WriteLine("Informe o percentual de aumento: ");
            //perc = double.Parse(Console.ReadLine());

            //novoSalario = salario + (salario * perc) / 100;

            //Console.WriteLine("Salário atual é: " + salario);

            //Exercicio - Ler um período em anos, meses e dias, e mostrar o total em dias. (considerando um ano com 365 dias e um mês com 30 dias).

            //int anos, meses, dias;

            //Console.WriteLine("Informe a quantidade de anos: ");
            //anos = int.Parse(Console.ReadLine());
            //Console.WriteLine("Informe a quantidade de meses: ");
            //meses = int.Parse(Console.ReadLine());
            //Console.WriteLine("Informe a quantidade de dias: ");
            //dias = int.Parse(Console.ReadLine());

            //dias = (anos * 365) + (meses + 30) + dias;
            //dias += (anos * 365) + (meses * 30);

            //Console.WriteLine("Total de dias é: " + dias);

            // -----------------------------------------------------------------------------------------------------------------------------------------------------------

            //////Exercicio de variavel auxiliar
            //int x = 5;
            //int y = 7;
            //int aux;

            //aux = x;
            //x = y;
            //y = aux;

            //Console.WriteLine(x);
            //Console.WriteLine(y);
        }
    }
}
