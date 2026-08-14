// Welcome to the system

string message = (@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");

// Function to print the welcome message
void PrintMessage(string message)
{
    Console.WriteLine(message);
    Console.WriteLine("\nBem-vindo ao Screen Sound!");
}

//Show the menu options to the user
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

//User input for menu selection

void MenuSelection()
{
    Console.Write("\nDigite uma opção: ");
    string selectOption = Console.ReadLine()!;
    int numericOption = int.Parse(selectOption);
    switch (numericOption)
    {
        case 1:
            Console.WriteLine("Cadastrar banda");
            break;
        case 2:
            Console.WriteLine("Listar bandas");
            break;
        case 3:
            Console.WriteLine("Avaliar banda");
            break;
        case 4:
            Console.WriteLine("Ver média da banda");
            break;
        case 0:
            Console.WriteLine("Saindo do programa...");
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            MenuSelection();
            break;
    }
}
;

MenuSelection();

Console.WriteLine("\nFIM DO PROGRAMA");

