using System;

namespace _19102021_aula_2
{
    class Program
    {
        static void Main(string[] args)
        { /* exercicio 01
            double C;
            double F;

            Console.Write("informe o valor: ");
            C = double.Parse(Console.ReadLine());


            F = ((C * 1.8) + 32); // (((9 * C) + 160) / 5);
            F = ((9 * C) + 160) / 5; // (((9 * C) + 160) / 5);

            Console.WriteLine("Fahrenheit: " + F);
            */

            /* exercicio 2
             
            // Leia o nome de um funcionário, a quantidade de horas trabalhadas e o valor da hora. Feito isto, mostre uma mensagem ao usuário desta maneira:
            //  O salário de XXXX é XXXXX>>

            string nome;
            double qtdehora;
            double valorhora;
            double salario;

            Console.WriteLine("Nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Qtde hora: ");
            qtdehora = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor hora: ");
            valorhora = double.Parse(Console.ReadLine());

            salario = qtdehora * valorhora;

            Console.WriteLine("O salário de" + nome + "é de " + salario);

            */

            /* exercicio 3

            int x = 5;
            int y = 7;

            int aux;
            aux = x;
            x = y;
            y = aux;


            Console.WriteLine(x);
            Console.WriteLine(y);
            */

            // Ler um período em anos, meses e dias, e mostrar o total em dias. (considerando um ano com 365 dias e um mês com 30 dias).

            /*
            int dias;
            int meses;
            int anos;

            Console.WriteLine("dias: ");
            dias = int.Parse(Console.ReadLine());

            Console.WriteLine("meses: ");
            meses = int.Parse(Console.ReadLine());

            Console.WriteLine("anos: ");
            anos = int.Parse(Console.ReadLine());

            dias = (anos * 365) + (meses * 30) + dias;

            Console.WriteLine("Resultado em " + dias + "dias!");
            */

            // Faça um programa onde o salario e o percentual de aumento são entradas. A saída é o novo salário.
            /*
                        double salario, aumento;

                        Console.WriteLine("Salario: ");
                        salario = double.Parse(Console.ReadLine());

                        Console.WriteLine("Aumento: ");
                        aumento = double.Parse(Console.ReadLine());

                        Console.WriteLine("Salario novo: " + (salario + (salario * (aumento / 100))));

                        */
            // Suponha que um vendedor de carros trabalhe em uma empresa onde todos os veículos custem 30.000 reais. Faça um programa que leia o nome do funcionário, o seu salario base (Exemplo: 1000), e a quantidade de veículos vendidos. Para cada veiculo vendido ele recebe 15% de comissão, que deve ser somado ao seu salario. Apresente o novo salario da mesma forma do exercício anterior.
            /*
            string nome;
            double salario;
            double veiculo = 30000;
            double quantidade;
            double porcentagem = 15/100d;


            Console.WriteLine("Nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Salario: ");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine("quantidade de vendas: ");
            quantidade = double.Parse(Console.ReadLine());

            double comissao = (quantidade * veiculo ) * porcentagem;

            Console.WriteLine("Salario final: " + (comissao + salario));
            */

            // Para uma eleição, receba o numero de eleitores, a quantidade de votos brancos, nulos e validos. Mostre o percentual de cada tipo de voto.
            /*
             
            int totaldevotos;
            int branco;
            int nulo;
            int valido;

            Console.WriteLine("totaldevotos: ");
            totaldevotos = int.Parse(Console.ReadLine());

            Console.WriteLine("votos em branco: ");
            branco = int.Parse(Console.ReadLine());

            Console.WriteLine("Votos nulos: ");
            nulo = int.Parse(Console.ReadLine());

            Console.WriteLine("votos validos: ");
            valido = int.Parse(Console.ReadLine());

            Console.WriteLine("porcentagen de votos validos: " + (valido *100 / totaldevotos));
            Console.WriteLine("porcentagen de votos branco: " + (branco * 100 / totaldevotos));
            Console.WriteLine("porcentagen de votos nulo: " + (nulo * 100 / totaldevotos));
            */
            /*
            int numero;

            Console.WriteLine("Numero: ");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("numero anterior: " + (numero - 1));
            Console.WriteLine("numero sucessor: " + (numero + 1));
            */

            double nota1, nota2, nota3;

            Console.WriteLine("Nota 1: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota 2: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota 3: ");
            nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Média: " + (nota1 + nota2 + nota3)/3);
           
            /* exemplo aula 
             
            double valor1;
            double valor2; 
            double soma;
            double sub;
            double mult;
            double div;
            double resultado;


            Console.Write("informe o primeiro valor: ");
            valor1 = double.Parse(Console.ReadLine());

            Console.Write("informe o segundo valor: ");
            valor2 = double.Parse(Console.ReadLine());

            resultado = valor1 + valor2;
            Console.WriteLine(" a soma resulta em: " + resultado);

            resultado = valor2 - valor2;
            resultado = valor1 * valor2;
            resultado = valor1 / valor2;

            Console.WriteLine("a subtração resulta em: " + resultado);
            Console.WriteLine("a subtração resulta em: " + resultado);
            Console.WriteLine("a subtração resulta em: " + resultado);



            /* int inteiro; // numeros positivos e negativos
             string texto; // armazaena sequencia de caracteres ou seja texto, 
                           // TIPO NOME; DECLARA UMA VARIÁVEL
                           // NOME = VALOR; // ATRIBUIÇÃO


             double real;
             bool boleano; 

             Console.ReadKey(); */





        }
    }
}
