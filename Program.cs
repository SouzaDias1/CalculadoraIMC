using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a sua altura em metros?");
            float altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Qual o seu peso em quilos?");
            float peso = Convert.ToSingle(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine(
                "{0} sua altura é {1} e seu peso é {2}",
                nome, altura, peso
            ); 

            Console.WriteLine("Seu IMC é {0}", imc);

            if(imc<17.00)
            {
                Console.WriteLine("Você está muito abaixo do seu peso normal");
            }
            else if(imc>17.00 && imc<= 18.49)
            {
                Console.WriteLine("Você está abaixo do texto do seu peso normal");
            }
            else if(imc>=18.50 && imc<= 24.99)
            {
                Console.WriteLine("Você está com peso normal");
            }
            else if(imc>=25.00 && imc<= 29.99)
            {
                Console.WriteLine("Você está acima do peso");
            }
            else if(imc>=30.00 && imc<= 34.99)
            {
                Console.WriteLine("Você está com obesidade I");
            }
            else if(imc>=35.00 && imc<= 39.99)
            {
                Console.WriteLine("Você está com obesidade II (severa)");
            }
            else if(imc>=40.00)
            {
                Console.WriteLine("Você está com obesidade III (mórbida)");
            }

        }
    }
}
