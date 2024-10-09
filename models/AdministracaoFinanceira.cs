using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaParaEstacionamento.models
{
    public class AdministracaoFinanceira
    {
        
        public int ValorEntrada { get; set; }
        public int ValorPorHora { get; set; }
        public int Permanencia { get; set; }

        public void CalcularValorTotal(){

            Console.WriteLine("Gentileza informar a permanencia do veiculo:");
            string valPermanencia  = Console.ReadLine();
            int convPermanencia = Convert.ToInt32(valPermanencia);
            Permanencia = convPermanencia;
            int totalCalculado = ValorEntrada + (ValorPorHora * Permanencia);            
        }
    }
}