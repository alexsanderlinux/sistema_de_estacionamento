using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaParaEstacionamento.models
{
   
    public class Atendente
    {
        List<string> listaAtendentes = new List<string>();
        
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }

        public void CadastrarAtendente()
        {
            Console.WriteLine("Digite o nome do atendente:");
            Nome = Console.ReadLine();
             
            Console.WriteLine("Cadastrar carga horaria do atendente");
            string carga = Console.ReadLine(); 
            int cargaConvertida = Convert.ToInt32(carga);
            CargaHoraria = cargaConvertida;
            listaAtendentes.Add($"{Nome},{CargaHoraria}");
        }
    }
}