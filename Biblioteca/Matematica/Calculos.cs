using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Matematica
{
    public static class Calculos
    {        
        public static double CalcularMediaPonderadaDeDuasNotas(double primeiraNota, double segundaNota, double pesodaDaPrimeiraNota, double pesoDaSegundaNota,int quantidadeDeCasasDecimais)
        {
            double somaDosPesosDasNotas = pesodaDaPrimeiraNota + pesoDaSegundaNota;
            double totalDaMultiplicacaoDaPrimeiraNotaComSeuPeso = primeiraNota * pesodaDaPrimeiraNota;
            double totalDaMultiplicacaoDaSegundaNotaComSeuPeso = segundaNota * pesoDaSegundaNota;
            return Math.Round((totalDaMultiplicacaoDaPrimeiraNotaComSeuPeso + totalDaMultiplicacaoDaSegundaNotaComSeuPeso) / somaDosPesosDasNotas, quantidadeDeCasasDecimais);
        }
        public static double CalcularMediaPonderadaDeNotas(double[] notas,double[] pesoDasNotas, int quantidadeDeCasasDecimaisParaArredondar)
        {
            double resultadoDaMultiplicacaoDasNotasComSeusPesos = 0;
            double resultadoDaSomaDosPesos  = 0;            
            for(int indiceDoPesoDaNota = 0; indiceDoPesoDaNota < pesoDasNotas.Length; indiceDoPesoDaNota++)
                resultadoDaSomaDosPesos += pesoDasNotas[indiceDoPesoDaNota];
            for (int indiceDaNotaMultiplicadaPeloPeso = 0; indiceDaNotaMultiplicadaPeloPeso < notas.Length; indiceDaNotaMultiplicadaPeloPeso++)            
                resultadoDaMultiplicacaoDasNotasComSeusPesos += notas[indiceDaNotaMultiplicadaPeloPeso] * pesoDasNotas[indiceDaNotaMultiplicadaPeloPeso];
            return resultadoDaMultiplicacaoDasNotasComSeusPesos / resultadoDaSomaDosPesos;
        }
    }
}
