using SistemaParaEstacionamento.models;

 

string opcao;
string opcao1;
bool exibirMenu = true;
bool menuInicial = true;
//bool cadastroCarro = false;
//bool menuOperacao = false;
AdministracaoOperacional adm = new AdministracaoOperacional();



while(exibirMenu)
{       /*
    if(menuInicial)
    {
        Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");
        Console.WriteLine("Menu de configuração inicial sistema de estacionamento...");
      /*  
        opcao1 = Console.ReadLine();
        
        switch(opcao1)
        {
            
            case "1":
                Atendente atendente = new Atendente();

                Console.WriteLine("1 - Cadastrar atendente");
                atendente.Nome = Console.ReadLine();       
                Console.WriteLine("2 - Cadastrar carga horaria atendente");
                string carga = Console.ReadLine(); 
                int cargaConvertida = Convert.ToInt32(carga);
                atendente.CargaHoraria = cargaConvertida;
                
            break;

            case "2":
             Console.WriteLine("2 - Cadastrar preço da entrada...");
            
            
            Console.WriteLine("3 - Cadastrar preço por hora...");
            break;


        }
        
        
        
        
        
        
    }*/

            Console.WriteLine("1 - Cadastrar veiculo:");
            Console.WriteLine("2 - Retirada de Veiculo:");
            Console.WriteLine("3 - Listar veiculos no estacionamento:");
            Console.WriteLine("4 - Voltar ao menu de configuração: ");
            Console.WriteLine("5 - Encerrar expediente... ");

 

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.Clear();

            adm.CadastrarNovoVeiculo();

            /*Console.WriteLine("Menu de operação do sistema:");
            Console.WriteLine("1 - Cadastrar veiculo:");
            Console.WriteLine("2 - Retirada de Veiculo:");
            Console.WriteLine("3 - Listar veiculos no estacionamento:");
            Console.WriteLine("4 - Voltar ao menu de configuração: ");
            Console.WriteLine("5 - Encerrar expediente... ");*/
            menuInicial = false;
               
            break;

        case "2":
                adm.ListarVeiculos();
                menuInicial = false;
                
                
                
                
                break;

        case "3":
                Console.WriteLine("Busca de cliente");

                
                
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