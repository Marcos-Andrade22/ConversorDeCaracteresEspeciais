using System;
using System.Text;

namespace ConversorDeCaracteresEspeciais
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o número de linhas que existem neste texto");
            int linhas = Convert.ToInt32(Console.ReadLine());
            StringBuilder[] vet = new StringBuilder[linhas];
            for (int i = 0; i < linhas; i++)
            {

        /*
            Accelo - 915 C - OM 904 LA // 2007 -->
            Accelo - 915 C - OM 904 LA // 2007 -->
            Sprinter 413 - OM 611 2.2L // 2002 -->
            Sprinter 411 - OM 611 2.2L // 2002 -->
        */
        static string ConverterSetaEBarra(StringBuilder sb)
        {
            string textoConvertido = sb.ToString().Replace("-->", "em diante").Replace("//", "-").Replace("/", " , ").Replace("--", "até");
            return textoConvertido;
        }
    }
}