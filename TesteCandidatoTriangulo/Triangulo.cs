using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteCandidatoTriangulo
{
    public class Triangulo
    {
        /// <summary>
        ///    6
        ///   3 5
        ///  9 7 1
        /// 4 6 8 4
        /// Um elemento somente pode ser somado com um dos dois elementos da próxima linha. Como o elemento 5 na Linha 2 pode ser somado com 7 e 1, mas não com o 9.
        /// Neste triangulo o total máximo é 6 + 5 + 7 + 8 = 26
        /// 
        /// Seu código deverá receber uma matriz (multidimensional) como entrada. O triângulo acima seria: [[6],[3,5],[9,7,1],[4,6,8,4]]
        /// </summary>
        /// <param name="dadosTriangulo"></param>
        /// <returns>Retorna o resultado do calculo conforme regra acima</returns>
        public int ResultadoTriangulo(string dadosTriangulo)
        {
            //"[[6],[3,5],[9,7,1],[4,6,8,4]]"
            int[][] jaggedArray = new int[][]
            {
                new int[] {6 },
                new int[] { 3,5 },
                new int[] { 9, 7, 1 },
                new int[] { 4, 6, 8, 4 }
            };
            int[] v = new int[1];
            var soma=0;
            for (   int i = 0; i < jaggedArray.Length; i++)
            {
                for (int a = 0; i < jaggedArray.Length; a++)
                {
                    soma = jaggedArray[i][a];
                    break;
                }            
            }
            return 0;
        }
    }
}
