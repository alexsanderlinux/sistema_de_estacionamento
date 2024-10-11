using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace SistemaParaEstacionamento.models
{
    public class AdministracaoFinanceira
    {
        public decimal resgatarValorEntrada = 0;
        public decimal resgatarValorPorHora = 0;
        public decimal resgatarPermanencia = 0;
        public decimal totalCalculado = 0;
        /*
        public AdministracaoFinanceira(decimal valorEntrada, decimal valPorHora)
        {
            this.resgatarValorEntrada = valorEntrada;
            this.resgatarValorPorHora = valPorHora;
        }
        */
               
        public void ResgatarValores()
        {
            Console.WriteLine("Gentileza informar o valor da entrada:");
            string valEntrada  = Console.ReadLine();
            this.resgatarValorEntrada = Convert.ToDecimal(valEntrada);
            


            
            Console.WriteLine("Gentileza informar o valor por hora:");
            string valorPorHora  = Console.ReadLine();
            this.resgatarValorPorHora = Convert.ToDecimal(valorPorHora);

           
        }

       
      
        public void CalcularValorTotal()
        {
            Console.WriteLine("Gentileza informar a permanencia do veiculo:");
            string valPermanencia  = Console.ReadLine();
            resgatarPermanencia = Convert.ToDecimal(valPermanencia);
            this.totalCalculado = this.resgatarValorEntrada + (this.resgatarValorPorHora * this.resgatarPermanencia); 
            Console.WriteLine(this.totalCalculado);           
        }
    }
}