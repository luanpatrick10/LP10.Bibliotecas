using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Matematica
{
    public class Calculos
    {
        public Calculos() { }

        public double CalcularMediaPonderadaDeDuasNotas(double primeiraNota, double segundaNota, double pesodaDaPrimeiraNota, double pesoDaSegundaNota,int quantidadeDeCasasDecimais)
        {
            double somaDosPesosDasNotas = pesodaDaPrimeiraNota + pesoDaSegundaNota;
            double totalDaMultiplicacaoDaPrimeiraNotaComSeuPeso = primeiraNota * pesodaDaPrimeiraNota;
            double totalDaMultiplicacaoDaSegundaNotaComSeuPeso = segundaNota * pesoDaSegundaNota;
            return Math.Round((totalDaMultiplicacaoDaPrimeiraNotaComSeuPeso + totalDaMultiplicacaoDaSegundaNotaComSeuPeso) / somaDosPesosDasNotas, quantidadeDeCasasDecimais);
        }
    }
}
