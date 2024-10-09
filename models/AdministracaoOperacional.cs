using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SistemaParaEstacionamento.models
{
    public class AdministracaoOperacional
    {
        List<string> listaCarros = new List<string>();
        Carro novoCarro = new Carro();
        AdministracaoFinanceira admFinanceira = new AdministracaoFinanceira(); 
        public void CadastrarNovoVeiculo()
        {
            Console.WriteLine("1 - Inserir nome do dono:");
            novoCarro.Dono = Console.ReadLine();
            Console.WriteLine("2 - Inserir a marca:");
            novoCarro.Marca = Console.ReadLine();
            Console.WriteLine("3 - Inserir a cor:");
            novoCarro.Cor = Console.ReadLine();
            Console.WriteLine("4 - Inserir a placa: ");
            novoCarro.Placa = Console.ReadLine();
            Console.WriteLine("4 - Inserir o modelo: ");
            novoCarro.Modelo = Console.ReadLine();        
            Console.WriteLine("5 - Inserir o tipo: ");
            novoCarro.Tipo = Console.ReadLine();
            Console.WriteLine("6 - Inserir o vaga: ");
            novoCarro.Vaga = Console.ReadLine();
            listaCarros.Add($"{novoCarro.Dono},{novoCarro.Marca},{novoCarro.Cor},{novoCarro.Placa},{novoCarro.Modelo},{novoCarro.Tipo},{novoCarro.Vaga}");
        }

        public void ListarVeiculos()
        {
            for (int i = 0; i < listaCarros.Count; i++)
            {
                Console.WriteLine($"vaga:{novoCarro.Vaga} e item: {listaCarros[i]}");
            }
        }

        public void RetiradaDeVeiculo()
        {
            admFinanceira.CalcularValorTotal();
        }
    }
}