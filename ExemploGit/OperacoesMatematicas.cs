namespace ExemploGit
{
    public class OperacoesMatematicas
    {

        public void Somar()
        {
            Console.WriteLine("Digite o número 1");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número 2");
            int n2 = int.Parse(Console.ReadLine());

            int resultado = n1 + n2;

            Console.WriteLine($"resultado: {n1} + {n2} = {resultado}\n");

        }

        public void Subtrair()
        {
            Console.WriteLine("Digite o número 1:");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número 2:");
            int valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Resultado é:" + (valor1 - valor2));


        }

        public void Multiplicar()
        {
            Console.WriteLine("Digite o 1º número: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o 2º número: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"O resultado da multiplicação é {n1 * n2}");
        }

        public void Dividir(int n1, int n2)
        {
            var result = n1 / n2;
            Console.WriteLine($"Seu resultado é {result}");
        }
    }
}
