﻿using SistemaParaEstacionamento.models;

 

string opcao;
bool exibirMenu = true;
bool menuConfiguracao = true;
bool menuOperacao = false;
AdministracaoOperacional admOperacional = new AdministracaoOperacional();
Atendente novoAtendente = new Atendente();
AdministracaoFinanceira admFinanceiro = new AdministracaoFinanceira();
 



while(exibirMenu)
{       
    if(menuConfiguracao)
    {
        Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("| Menu de configuração inicial do sistema de estacionamento.|");
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("Digite 0 para realizar a primeira configuração do sistema.");
    }

    if(menuOperacao)
    {
        Console.WriteLine("Menu Operacional:");
        Console.WriteLine("1 - Cadastrar veiculo:");
        Console.WriteLine("2 - Listar veiculos no estacionamento:");
        Console.WriteLine("3 - Retirada de veiculo");
        Console.WriteLine("4 - Encerrar expediente... ");        
    }

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "0":
            Console.Clear();
            novoAtendente.CadastrarAtendente();
            admFinanceiro.ResgatarValores();
            menuConfiguracao = false;
            Console.Clear();
            menuOperacao = true;
            break;

        case "1":
            Console.Clear();
            admOperacional.CadastrarNovoVeiculo();
            menuConfiguracao = false;
            break;

        case "2":
            admOperacional.ListarVeiculos();
            menuConfiguracao = false;
            break;

        case "3":
            admFinanceiro.CalcularValorTotal();
            admOperacional.RetiradaDeVeiculo();
            menuConfiguracao = false;
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

