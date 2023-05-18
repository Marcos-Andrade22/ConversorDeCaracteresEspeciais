using System;
using System.Text;

namespace ConversorDeCaracteresEspeciais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            StringBuilder sb3 = new StringBuilder();
            Console.WriteLine("Digite o número de linhas que existem neste texto");
            int linhas = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < linhas; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Digite um texto:");
                    string texto = Console.ReadLine();
                    sb.Append(texto);
                    string textoConvertido = ConverterSetaEBarra(sb);
                    Console.WriteLine("Texto convertido:");
                    Console.WriteLine(textoConvertido + " \n ");
                }
                if (i == 1)
                {
                    Console.WriteLine("Digite um texto:");
                    string texto1 = Console.ReadLine();
                    sb1.Append(texto1);
                    string textoConvertido1 = ConverterSetaEBarra(sb1);
                    Console.WriteLine("Texto convertido:");
                    Console.WriteLine(textoConvertido1 + " \n ");
                }
                if (i == 2)
                {
                    Console.WriteLine("Digite um texto:");
                    string texto2 = Console.ReadLine();
                    sb2.Append(texto2);
                    string textoConvertido2 = ConverterSetaEBarra(sb2);
                    Console.WriteLine("Texto convertido:");
                    Console.WriteLine(textoConvertido2 + " \n ");
                }
                if (i == 3)
                {
                    Console.WriteLine("Digite um texto:");
                    string texto3 = Console.ReadLine();
                    sb3.Append(texto3);
                    string textoConvertido3 = ConverterSetaEBarra(sb3);
                    Console.WriteLine("Texto convertido:");
                    Console.WriteLine(textoConvertido3 + " \n ");
                }
            }
        }
        //objetivo: conseguir colocar um texto inteiro sem precisar de ir linha por linha e criar varios strinbuilders
        /*
            Accelo - 915 C - OM 904 LA // 2007 -->
            Accelo - 915 C - OM 904 LA // 2007 -->
            Sprinter 413 - OM 611 2.2L // 2002 -->
            Sprinter 411 - OM 611 2.2L // 2002 -->
        */
        static string ConverterSetaEBarra(StringBuilder sb)
        {
            string textoConvertido = sb.ToString().Replace("-->", "em diante").Replace("//", "-"); ;           
            return textoConvertido;
        }
    }
}