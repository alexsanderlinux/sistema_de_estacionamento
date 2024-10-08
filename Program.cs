using SistemaParaEstacionamento.models;

//Carro c = new Carro(); 

string opcao;
bool exibirMenu = true;
bool menuInicial = true;
bool cadastroCarro = false;
bool menuOperacao = false;
List<string> listaCarros = new List<string>();


while(exibirMenu)
{       
    if(menuInicial)
    {
        Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");
        Console.WriteLine("Menu de configuração inicial do estacionamento...");
        Console.WriteLine("1 - Cadastrar atendente");
        Console.WriteLine("2 - Cadastrar preço da entrada...");
        Console.WriteLine("3 - Cadastrar preço por hora...");
        Console.WriteLine("4 - Cadastrar carga horaria atendente");
        Console.WriteLine("5 - encerrar sistema");
        //Console.WriteLine("6 - pular menu");
    }

    if(menuOperacao)
    {
        Console.WriteLine("Menu de operação do sistema:");
        Console.WriteLine("1 - Cadastrar veiculo:");
        Console.WriteLine("2 - Retirada de Veiculo:");
        Console.WriteLine("3 - Listar veiculos no estacionamento:");
        Console.WriteLine("4 - Voltar ao menu de configuração: ");
        Console.WriteLine("5 - Encerrar expediente... ");

    }

    if(cadastroCarro)
    {
        
        Carro c = new Carro();
        Console.WriteLine("Insira na sequencia os dados de cadastro do veiculo:");
        
        Console.WriteLine("1 - Inserir nome do dono:");
        c.Dono = Console.ReadLine();
        Console.WriteLine("2 - Inserir a marca:");
        c.Marca = Console.ReadLine();
        Console.WriteLine("3 - Inserir a cor:");
        c.Cor = Console.ReadLine();
        Console.WriteLine("4 - Inserir a placa: ");
        c.Placa = Console.ReadLine();
        Console.WriteLine("4 - Inserir o modelo: ");
        c.Modelo = Console.ReadLine();        
        Console.WriteLine("5 - Inserir o tipo: ");
        c.Tipo = Console.ReadLine();
        Console.WriteLine("6 - Inserir o vaga: ");
        c.Vaga = Console.ReadLine();

      
        listaCarros.Add($"{c.Dono},{c.Marca},{c.Cor},{c.Placa},{c.Modelo},{c.Tipo},{c.Vaga}");

        for (int i = 0; i < listaCarros.Count; i++)
{
        Console.WriteLine($"posicao:{i} e item: {listaCarros[i]}");

        Console.WriteLine("5 - Inserir o tipo: ");
        opcao = Console.ReadLine();
}

    }


    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("Entrada de veiculo");
            Console.WriteLine("Gentileza informar os dados: ");
            menuInicial = false;
            cadastroCarro = true;
            break;

        case "2":
            Console.WriteLine("Busca de cliente");
            break;

        case "3":
            Console.WriteLine("apagar de cliente");
            break;
        
        case "4":
            
           Console.WriteLine("cadastrar carga horaria atendente");
            break;

        case "5":
            
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