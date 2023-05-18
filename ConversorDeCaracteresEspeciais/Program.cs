using System;
using System.Text;

namespace ConversorDeCaracteresEspeciais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Digite um texto:");
            string texto = Console.ReadLine();
            sb.Append(texto);
            string textoConvertido = ConverterSetaEmDiante(sb);

            Console.WriteLine("Texto convertido:");
            Console.WriteLine(textoConvertido);
        }

        static string ConverterSetaEmDiante(StringBuilder sb)
        {
            string textoConvertido = sb.ToString().Replace("//", "\\//");
            textoConvertido = sb.ToString().Replace("\\//", "-");
            textoConvertido = sb.ToString().Replace("-->" , "em diante");
            return textoConvertido;
        }
    }
}