using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro_projeto
{
    internal class Program
    { 
        enum Menu { Soma = 1, Subtracao = 2, Divisao = 3, Multiplicacao = 4, Potencia = 5, Raiz = 6, Sair = 7}
        
        static void Main(string[] args)
        {


            bool escolheuSair = false;
            while (!escolheuSair)  //ENQUANTO O USUARIO NÃO(!) ESCOLHER SAIR EXIBA O MENU
            {

                Console.WriteLine("Bem vindo a Calculadora, selecione uma das opções");
                Console.WriteLine("1-Soma\n2-Subtracao\n3-Divisao\n4-Multiplicacao\n5-Potencia\n6-Raiz\n7-Sair");

                /* VOCÊ PODE USAR DUAS OPÇÕES PARA TRANSFORMAR TEXTO EM NUMERO E VICE E VERSA A PRIMEIRA:
                string opcaoTXT = console.Readline();
                int opcaoInt = int.Parse(opcaoTXT);
                Menu opcao = (Menu)opcaoInt;
                */

                //SEGUNDA OPÇÃO
                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Sub();
                        break;
                    case Menu.Divisao:
                        Div();
                        break;
                    case Menu.Multiplicacao:
                        Mult();
                        break;
                    case Menu.Potencia:
                        Pot();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break; 
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                }

                //CLEAR SERVE PARA LIMPAR AS INFORMAÇÕES DO CONSOLE
                Console.Clear();

            }

        }

        //PARA CRIAR UMA FUNÇÃO LEMBRA DE SEMPRE COLOCAR O STATIC NA FRENTE
        //FUNÇÃO STATIC NÃO RETORNA NADA
        static void Soma()
        {
            Console.WriteLine("Soma de dois numeros");
            Console.WriteLine("Digite o primeiro numero");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            //USANDO INTERPOLAÇÃO $ CODIGO FICA BEM MAIS LIMPO
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte enter para voltar para o menu");
            Console.ReadLine();
        }

        static void Sub()
        {
            Console.WriteLine("Subtração de dois numeros");
            Console.WriteLine("Digite o primeiro numero");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            //USANDO INTERPOLAÇÃO $ CODIGO FICA BEM MAIS LIMPO
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte enter para voltar para o menu");
            Console.ReadLine();
        }
        static void Div()
        {
            Console.WriteLine("Divisão de dois numeros");
            Console.WriteLine("Digite o primeiro numero");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a/(float)b;
            //USANDO INTERPOLAÇÃO $ CODIGO FICA BEM MAIS LIMPO
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte enter para voltar para o menu");
            Console.ReadLine();
        }
        static void Mult()
        {
            Console.WriteLine("Multiplicação de dois numeros");
            Console.WriteLine("Digite o primeiro numero");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            //USANDO INTERPOLAÇÃO $ CODIGO FICA BEM MAIS LIMPO
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte enter para voltar para o menu");
            Console.ReadLine();
        }
        static void Pot()
        {
            Console.WriteLine("Potência de um numero");
            Console.WriteLine("Digite a base");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente");
            int expo = int.Parse(Console.ReadLine());
            // O MATH É UMA FUNÇÃO RESERVADA DO C#
            int resultado = (int)Math.Pow(baseNum, expo);
            //USANDO INTERPOLAÇÃO $ CODIGO FICA BEM MAIS LIMPO
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte enter para voltar para o menu");
            Console.ReadLine();
        }
        static void Raiz()
        {
            Console.WriteLine("Raiz de um numero");
            Console.WriteLine("Digite o numero");
            int a = int.Parse(Console.ReadLine());
            //SQRT SIGNIFICA SQUARE ROOT (RAIZ QUADRADA)
            //USAMOS O DOUBLE PARA PEGAR TAMBEM OS NUMEROS DECIMAIS
            double resultado = Math.Sqrt(a);
            //USANDO INTERPOLAÇÃO $ CODIGO FICA BEM MAIS LIMPO
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte enter para voltar para o menu");
            Console.ReadLine();
        }
    }

}
