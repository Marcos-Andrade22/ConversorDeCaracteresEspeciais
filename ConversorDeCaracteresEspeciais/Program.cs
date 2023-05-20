using System;
using System.Text;

namespace ConversorDeCaracteresEspeciais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textoConv = "";
            string codigoPeca;
            string codigoOriginal = "";
            string codigoOri;
            string tipoPeca;
            string texto;
            string catalogo;
            StringBuilder[] vet = new StringBuilder[linhas];
            int qtCodOri;
            Console.WriteLine("Qual catálogo estaremos usando ?");
            catalogo = Console.ReadLine();
            if (catalogo == "wega" || catalogo == "WEGA" || catalogo == "Wega")
            {
                for (int i = 0; i < linhas; i++)
                {
                    Console.WriteLine("Digite um texto:");
                    texto = Console.ReadLine();
                    vet[i] = new StringBuilder();
                    vet[i].Append(texto);
                    string textoConvertido = ConversorWega(vet[i]);
                    textoConv += textoConvertido + "\n";
                }
            }
            if (catalogo == "originall" || catalogo == "ORIGINALL" || catalogo == "originALL" || catalogo == "Originall")
            {
                Console.WriteLine("Digite um texto:");
                texto = Console.ReadLine();
                vet[i] = new StringBuilder();
                vet[i].Append(texto);
                string textoConvertido = ConversorOriginal(vet[i]);
                textoConv += textoConvertido + "\n";
            }
            Console.WriteLine("Digite o Código da Peça: ");
            codigoPeca = Console.ReadLine();
            Console.WriteLine("Quantos Códigos Originais Existem nessa peça?");
            qtCodOri = Convert.ToInt32(Console.ReadLine());
            for (int j = 1; j < qtCodOri + 1; j++)
            {
                Console.WriteLine("Digite o Código Original " + j + ": ");
                codigoOri = Console.ReadLine();
                codigoOriginal += codigoOri + "\n";
            }
            Console.WriteLine("Digite o tipo da peça(Exemplo: Filtro de Combustível) : ");
            tipoPeca = Console.ReadLine();
            Console.WriteLine("Digite o número de linhas que existem neste texto");
            int linhas = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Texto convertido:");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine(tipoPeca);
            Console.WriteLine("\n");
            Console.WriteLine("Montadoras: ");
            Console.WriteLine("\n");
            Console.WriteLine(textoConv);
            Console.WriteLine("Código da Peça: ");
            Console.WriteLine(codigoPeca);
            Console.WriteLine("\n");
            Console.WriteLine("SKU: " + codigoPeca + " " + codigoOriginal);
            Console.WriteLine("Código Original: ");
            Console.WriteLine(codigoOriginal);
            Console.WriteLine("\n");
            Console.WriteLine("Marca: WEGA - Peça Genuína");
            Console.WriteLine("\n");
            Console.WriteLine("Intercambialidade: ");

        }
        //objetivo: Colocar um suporte para que leia um caractere quando está sozinho e quando está junto com outros termos
        //Exemplo: > com outros termos , e > separado
        //09/14>: > quer dizer em diante
        //04/15>05/18: > quer dizer até
        /*
            Gol 1.8 (Sport , GTI) OL 203 // 15 > \n
            Gol 1.8 (Sport , GTI) OL 203 // 06 > 10 \n
            Accelo - 915 C - OM 904 LA // 2007 --> \n
            Accelo - 915 C - OM 904 LA // 2007 --> \n
            Sprinter 413 - OM 611 2.2L // 2002 --> \n
            Sprinter 411 - OM 611 2.2L // 2002 --> \n
        */
        static string ConversorWega(StringBuilder sb)
        {
            string textoConvertido = sb.ToString().Replace("-->", "em diante").Replace("//", "-").Replace("/", " , ").Replace("--", "até");
            return textoConvertido;
        }
        static string ConversorOriginal(StringBuilder sb)
        {
            string[] linhas = sb.Split('\n');
            foreach (string linha in linhas)
            {
                int primeiraPosicao = linha.IndexOf('>');
                int ultimaPosicao = linha.LastIndexOf('>');
                int proximaPosicao = linha.IndexOf('>', primeiraPosicao + 1);
                //index do '>' nao pode ser negativo
                //esse if quer dizer que o '>' esta entre dois termos
                if (primeiraPosicao >= 0 && proximaPosicao > primeiraPosicao && proximaPosicao < ultimaPosicao)
                {

                }
            }
        }
    }
}