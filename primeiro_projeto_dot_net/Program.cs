// Screem Sound

string message = (@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");

void PrintMessage(string message)
{
    Console.WriteLine(message);
    Console.WriteLine("\nBem-vindo ao Screen Sound!");
}

void ShowMenuOptions()
{
    Console.WriteLine("\n1. Cadastrar banda");
    Console.WriteLine("2. Listar bandas");
    Console.WriteLine("3. Avaliar banda");
    Console.WriteLine("4. Ver média da banda");
    Console.WriteLine("0. Sair");
}

// Print the welcome message and show the menu options
PrintMessage(message);
ShowMenuOptions();

Console.Write("\nDigite uma opção: ");
string selectOption = Console.ReadLine()!;
int numericOption = int.Parse(selectOption);
if (numericOption == 1)
{
    Console.WriteLine("Você escolheu a opção " + selectOption );
}

Console.WriteLine("FIM DO PROGRAMA");

