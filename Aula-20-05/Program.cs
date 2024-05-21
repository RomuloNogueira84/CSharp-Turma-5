using System;

namespace Aula_20_05
{
    class Program
    {
        static void Main(string[] args)
        {
            String esposa = "Keity";
            String marido = "Romulo";
            int idadeEsposa = 29;
            int idadeMarido = 39;
            Double alturaEsposa = 1.53;
            Double alturaMarido = 1.87;

            Console.WriteLine($"Eu sou {marido} sou casado com {esposa} eu tenho {idadeMarido} e minha esposa tem {idadeEsposa} e eu tenho {alturaMarido} e ela tem {alturaEsposa} de altura");

            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine(nome);

        int a = 10;
        int b = 3;

            Console.WriteLine("Digite o primeiro numero: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            a = int.Parse(Console.ReadLine());

            //soma
            int soma =  a + b;
            Console.WriteLine("A soma de a e b é : " + soma);
            // subtração
            int subtracao = a - b;
            Console.WriteLine("A subtração de a e b é: " + subtracao);
            // multiplicação
            int multiplicacao = a * b;
            Console.WriteLine("A multiplicação de a e b é: " + multiplicacao);

            // divisão
            int divisao = a / b;
            Console.WriteLine("A divisão de a e b é: " + divisao);

            // resto
            int resto = a % b;
            Console.WriteLine("O resto de a e b é: " + resto);

            int idade = 15;

            if(idade > 17) {
                Console.WriteLine("Alistado");
            }else if (idade <= 17 && idade >= 15)
            {
                Console.WriteLine("Espera");
            }else
            {
                Console.WriteLine("Volte pra casa");
            }




            Console.WriteLine("Digite a primeira nota:");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota");
            int n3 = int.Parse(Console.ReadLine());

            double media = (n1 + n2 + n3) / 3.0;

            if (media >= 6)
            {
                Console.WriteLine(" Meus parabens você foi Aprovado");
            }
            else
            {
                Console.WriteLine(" Você foi Reprovado");
            }
        }
    }
}

