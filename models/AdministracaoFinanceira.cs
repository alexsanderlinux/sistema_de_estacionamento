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

        public void ResgatarValorPorHora()
        {
            Console.WriteLine("Gentileza informar o valor da hora cobrada:");
            string valPorHora  = Console.ReadLine();
            int convValPorHora = Convert.ToInt32(valPorHora);
            if(convValPorHora != 0)
            {
                ValorPorHora = convValPorHora;
            }
            else
            {
                Console.WriteLine("Valor incorreto!");
            }
            
        }

        public void CalcularValorTotal(){

            Console.WriteLine("Gentileza informar a permanencia do veiculo:");
            string valPermanencia  = Console.ReadLine();
            int convPermanencia = Convert.ToInt32(valPermanencia);
            Permanencia = convPermanencia;
            int totalCalculado = ValorEntrada + (ValorPorHora * Permanencia);            
        }
    }
}