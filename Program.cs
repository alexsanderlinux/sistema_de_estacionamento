


using SistemaParaEstacionamento.models;

Carro c = new Carro(); 

string opcao;
bool exibirMenu = true;
bool menuInicial = true;

while(exibirMenu)
{       
    if(menuInicial){
        Console.WriteLine("Digite sua opcao");
        Console.WriteLine("1 - cadastrar cliente");
        Console.WriteLine("2 - buscar cliente");
        Console.WriteLine("3 - apagar cliente");
        Console.WriteLine("4 - encerrar cliente");
    }

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("Entrada de veiculo");
            Console.WriteLine("Gentileza informar os dados: ");
            menuInicial = false;
            break;

        case "2":
            Console.WriteLine("Busca de cliente");
            break;

        case "3":
            Console.WriteLine("apagar de cliente");
            break;
        
        case "4":
            
            Console.Clear();
            exibirMenu = false;
            Console.WriteLine("Encerrar programa");
            //Environment.Exit(0);
            break;
        
        default:
            Console.WriteLine("opcao invalida...");
            break;
    }

}

//Console.WriteLine("codigo abaixo do enviroment");