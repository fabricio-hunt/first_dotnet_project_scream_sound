// Welcome to the system

string message = (@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");

// List of bands
List<string> listBands = new List<string>();

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
    Console.WriteLine("5. Mostrar opções do menu");
    Console.WriteLine("0. Sair do programa");
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
            RegisterBand();
            Console.WriteLine("Cadastrar banda");
            break;
        case 2: 
            showRegisteredBands(); //Show the list of bands
            Console.WriteLine("Listar bandas");
            break;
        case 3:
            Console.WriteLine("Avaliar banda");
            break;
        case 4:
            Console.WriteLine("Ver média da banda");
            break;
        case 5:
            Console.Clear();
            ShowMenuOptions();
            MenuSelection();
            break;
        case 0:
            Console.Clear();
            Console.WriteLine("Saindo do programa...");
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            MenuSelection();
            break;
    }
};

MenuSelection();

//Register a band function
void RegisterBand()
{
    Console.Clear();
    Console.WriteLine("Cadastrar banda");
    Console.Write("\nDigite o nome da banda: ");
    string bandName = Console.ReadLine()!;
    listBands.Add(bandName);
    Console.WriteLine($"Banda {bandName} cadastrada com sucesso!");
    Console.Clear();
    MenuSelection();
}
void showRegisteredBands()
{
    Console.Clear();
    Console.WriteLine("**********************************");
    Console.WriteLine("Listar bandas");
    Console.WriteLine("**********************************");
    if (listBands.Count == 0)
    {
        Console.WriteLine("Nenhuma banda cadastrada.");
    }
    else
    {
        Console.WriteLine("\nBandas cadastradas:");
        foreach (string band in listBands)
        {
            Console.WriteLine(band);
        }
    }
    MenuSelection();
   
}

Console.WriteLine("\nFIM DO PROGRAMA");

