// See https://aka.ms/new-console-template for more information

using ExemploGit;

var menu = true;
var operacoesMatematicas = new OperacoesMatematicas();

while(menu)
{
    Console.WriteLine("Digite a opção:\n 1- para somar\n 2- para subtrair\n 3- para multiplicar\n 4- para dividir\n 5- para sair\n ");
    var opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            operacoesMatematicas.Somar();
            break;
        case 2:
            operacoesMatematicas.Subtrair();
            break;
        case 3:
            operacoesMatematicas.Multiplicar();
            break;
        case 4:
            operacoesMatematicas.Dividir();
            break;
        case 5:
            Console.WriteLine("Adeus!!");
            menu = false;
            break;
        default:
            Console.WriteLine("Opção não cadastrada!");
            break;
    }
}
