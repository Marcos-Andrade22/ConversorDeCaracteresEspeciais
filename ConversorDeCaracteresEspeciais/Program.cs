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
            StringBuilder sb4 = new StringBuilder();
            StringBuilder sb5 = new StringBuilder();
            StringBuilder sb6 = new StringBuilder();
            StringBuilder sb7 = new StringBuilder();
            StringBuilder sb8 = new StringBuilder();
            StringBuilder sb9 = new StringBuilder();
            StringBuilder sb10 = new StringBuilder();
            StringBuilder sb11 = new StringBuilder();
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
                if (i == 4)
                {
                    Console.WriteLine("Digite um texto:");
                    string texto4 = Console.ReadLine();
                    sb4.Append(texto4);
                    string textoConvertido4 = ConverterSetaEBarra(sb4);
                    Console.WriteLine("Texto convertido:");
                    Console.WriteLine(textoConvertido4 + " \n ");
                }
                if (i == 5)
                {
                    Console.WriteLine("Digite um texto:");
                    string texto5 = Console.ReadLine();
                    sb5.Append(texto5);
                    string textoConvertido5 = ConverterSetaEBarra(sb5);
                    Console.WriteLine("Texto convertido:");
                    Console.WriteLine(textoConvertido5 + " \n ");
                }
                if (i == 6)
                {
                    Console.WriteLine("Digite um texto:");
                    string texto6 = Console.ReadLine();
                    sb6.Append(texto6);
                    string textoConvertido6 = ConverterSetaEBarra(sb6);
                    Console.WriteLine("Texto convertido:");
                    Console.WriteLine(textoConvertido6 + " \n ");
                }
                if (i == 7)
                {
                    Console.WriteLine("Digite um texto:");
                    string texto7 = Console.ReadLine();
                    sb7.Append(texto7);
                    string textoConvertido7 = ConverterSetaEBarra(sb7);
                    Console.WriteLine("Texto convertido:");
                    Console.WriteLine(textoConvertido7 + " \n ");
                }
                if (i == 8)
                {
                    Console.WriteLine("Digite um texto:");
                    string texto8 = Console.ReadLine();
                    sb8.Append(texto8);
                    string textoConvertido8 = ConverterSetaEBarra(sb8);
                    Console.WriteLine("Texto convertido:");
                    Console.WriteLine(textoConvertido8 + " \n ");
                }
                if (i == 9)
                {
                    Console.WriteLine("Digite um texto:");
                    string texto9 = Console.ReadLine();
                    sb9.Append(texto9);
                    string textoConvertido9 = ConverterSetaEBarra(sb9);
                    Console.WriteLine("Texto convertido:");
                    Console.WriteLine(textoConvertido9 + " \n ");
                }
                if (i == 10)
                {
                    Console.WriteLine("Digite um texto:");
                    string texto10 = Console.ReadLine();
                    sb10.Append(texto10);
                    string textoConvertido10 = ConverterSetaEBarra(sb10);
                    Console.WriteLine("Texto convertido:");
                    Console.WriteLine(textoConvertido10 + " \n ");
                }
                if (i == 11)
                {
                    Console.WriteLine("Digite um texto:");
                    string texto11 = Console.ReadLine();
                    sb11.Append(texto11);
                    string textoConvertido11 = ConverterSetaEBarra(sb11);
                    Console.WriteLine("Texto convertido:");
                    Console.WriteLine(textoConvertido11 + " \n ");
                }
            }
        }
        //objetivo: ao invés de retornar linha por linha, retornar o texto inteiro formatado
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