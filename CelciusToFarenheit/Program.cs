using System;
using System.Globalization;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {

            float celsius, fahrenheit;
            char sim = 's';

            do { //Faça...

                //Lê a temperatura em Celsius
                celsius = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                //Calcula de Celsius para Fahrenheit
                fahrenheit = 9 * celsius / 5 + 32;
                //Pergunta na tela se quer executar novamente, se sim...
                Console.WriteLine("Equivalente em Fahrenheit: " + fahrenheit.ToString("F1",CultureInfo.InvariantCulture));
                Console.WriteLine("Deseja repetir s/n ?");
                //Lê a character enviardo, e se for verdadeira 's' ele executa denovo, se nao finaliza o programa
                sim = char.Parse(Console.ReadLine());

            } while(sim == 's'); // Enquanto essa condição for verdadeira
        }
    }
}










