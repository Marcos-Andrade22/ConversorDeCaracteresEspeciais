using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;

namespace ConversorDeCaracteresEspeciais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contPecas = 0;
            while (contPecas < 20)
            {


                string textoConv = "";
                string codigoPeca;
                string codigoOriginal = "";
                string codigoOri;
                string origSKU = "";
                string tipoPeca;
                string texto;
                string catalogo;
                int linhas;
                int qtCodOri;
                string originalSKU = "";
                Console.WriteLine("Digite o número de linhas que existem neste texto");
                linhas = Convert.ToInt32(Console.ReadLine());
                StringBuilder[] vet = new StringBuilder[linhas];
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
                else if (catalogo == "KYB" || catalogo == "kyb")
                {
                    for (int i = 0; i < linhas; i++)
                    {
                        Console.WriteLine("Digite um texto:");
                        texto = Console.ReadLine();
                        vet[i] = new StringBuilder();
                        vet[i].Append(texto);
                        string textoConvertido = ConversorKYB(vet[i]);
                        textoConv += textoConvertido + "\n";
                    }
                }
                else if (catalogo == "originall" || catalogo == "ORIGINALL" || catalogo == "originALL" || catalogo == "Originall" || catalogo == "Original" || catalogo == "original" || catalogo == "ORIGINAL")
                {
                    for (int k = 0; k < linhas; k++)
                    {
                        Console.WriteLine("Digite um texto:");
                        texto = Console.ReadLine();
                        vet[k] = new StringBuilder();
                        vet[k].Append(texto);
                        string textoConvertido = ConversorOriginal(vet[k]);
                        textoConv += textoConvertido + "\n";
                    }
                }
                else if (catalogo == "Tecfil" || catalogo == "tecfil" || catalogo == "TECFIL" || catalogo == "TecFil")
                {
                    for (int w = 0; w < linhas; w++)
                    {
                        Console.WriteLine("Digite um texto:");
                        texto = Console.ReadLine();
                        vet[w] = new StringBuilder();
                        vet[w].Append(texto);
                        string textoConvertido = ConversorTecfil(vet[w]);
                        textoConv += textoConvertido + "\n";
                    }
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
                    if (j == 1)
                    {
                        origSKU = codigoOri;
                    }
                }
                Console.WriteLine("Digite o tipo da peça(Exemplo: Filtro de Combustível) : ");
                tipoPeca = Console.ReadLine();

                string marca;
                Console.WriteLine("Qual a marca?");
                marca = Console.ReadLine();
                string marcaGenuina = "";
                Console.WriteLine("A marca é genuína??");
                marcaGenuina = Console.ReadLine();

                string intercambialidade;
                Console.WriteLine("Possui Intercambialidade?");
                intercambialidade = Console.ReadLine();
                if (intercambialidade == "s" || intercambialidade == "sim" || intercambialidade == "Sim")
                {
                    intercambialidade = "";
                    Console.WriteLine("Quantas Intercambialidades?");
                    int quantasIntercambialidades = Convert.ToInt32(Console.ReadLine());
                    for (int w = 0; w < quantasIntercambialidades; w++)
                    {
                        Console.WriteLine("Digite as intercambialidades:");
                        texto = Console.ReadLine();
                        vet[w] = new StringBuilder();
                        vet[w].Append(texto);
                        string textoConvertido = ConversorKYB(vet[w]);
                        intercambialidade += textoConvertido + "\n";
                    }
                }


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
                Console.WriteLine("SKU: " + codigoPeca + " " + origSKU);
                if (qtCodOri > 0)
                {
                    Console.WriteLine("Código Original: ");
                }
                Console.WriteLine(codigoOriginal);
                Console.WriteLine("\n");
                Console.WriteLine();
                if (marcaGenuina == "s" || marcaGenuina == "sim" || marcaGenuina == "Sim")
                {
                    marcaGenuina = "- Marca Genuína";
                }
                else
                {
                    marcaGenuina = "";
                }
                Console.WriteLine("Marca: " + marca + " " + marcaGenuina);

                /* if (catalogo == "wega" || catalogo == "WEGA" || catalogo == "Wega")
                 {
                     Console.WriteLine("Marca: WEGA - Peça Genuína");
                 }
                 else if (catalogo == "originall" || catalogo == "ORIGINALL" || catalogo == "originALL" || catalogo == "Originall" || catalogo == "Original" || catalogo == "original" || catalogo == "ORIGINAL")
                 {
                     Console.WriteLine("Marca: ORIGINALL");
                 }
                 else if (catalogo == "Tecfil" || catalogo == "tecfil" || catalogo == "TECFIL" || catalogo == "TecFil")
                 {
                     Console.WriteLine("Marca: TECFIL - Peça Genuína");

                 }
                 else if (catalogo == "KYB" || catalogo == "kyb" || catalogo == "Kyb")
                 {
                     Console.WriteLine("Marca: KYB - Peça Genuína");

                 }*/
                Console.WriteLine("\n");
                Console.WriteLine("Intercambialidade: ");
                Console.WriteLine(intercambialidade);
                Console.WriteLine("\n");
                Console.WriteLine("Observação:");
                if (catalogo == "KYB" || catalogo == "kyb" || catalogo == "Kyb")
                {
                    Console.WriteLine("Dimensional Aberto: ");
                    Console.WriteLine("Dimensional Fechado: ");
                    Console.WriteLine("Estrutura: ");
                }
                else
                {
                    Console.WriteLine("Altura: ");
                    Console.WriteLine("Comprimento:");
                    Console.WriteLine("Largura:");
                    Console.WriteLine("Diâmetro Externo: ");
                    Console.WriteLine("Diâmetro Interno: ");
                }
;
                contPecas++;
            }

        }
        //objetivo: Colocar um suporte para que leia um caractere quando está sozinho e quando está junto com outros termos
        //Exemplo: > com outros termos , e > separado
        //09/14>: > quer dizer em diante
        //04/15>05/18: > quer dizer até
        /*
            Gol 1.8 (Sport , GTI) OL 203 // 15 >
            Gol 1.8 (Sport , GTI) // 06 > 10
            Accelo - 915 C - (Sedan) OM 904 LA // 12/2007 >
            Accelo - 915 C -(Sport / GTI / GLI / Coupe )OM 904 LA // 05/2007 > 11/2009
            Sprinter 413 - OM 611 2.2L // 2002 --> 
            Sprinter 411 - OM 611 2.2L // 2002 --> 
        */
        static string ConversorWega(StringBuilder sb)
        {
            sb.Replace("-->", "em diante").Replace("//", "-").Replace("/", " , ").Replace("--", "até");
            return sb.ToString();
        }
        static string ConversorOriginal(StringBuilder sb)
        {
            string[] linhas = sb.ToString().Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string linha in linhas)
            {
                int primeiraPosicao = linha.IndexOf('>');
                int ultimaPosicao = linha.LastIndexOf('>');
                int proximaPosicao = linha.IndexOf('>', primeiraPosicao + 1);
                //index do '>' nao pode ser negativo
                //esse if quer dizer que o '>' esta entre dois termos
                Console.WriteLine("Index Of: {0}", primeiraPosicao);
                Console.WriteLine("Last Index Of: {0}", ultimaPosicao);
                if (primeiraPosicao >= 0)
                {
                    if (ultimaPosicao == linha.Length - 1)
                    {
                        sb.Replace(">", "em diante");
                    }
                    else
                    {
                        sb.Replace(">", "até");
                    }

                }
            }
            return sb.ToString();
        }
        static string ConverteBarra(string linha)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < linha.Length; i++)
            {
                if (linha[i].Equals('/'))
                {
                    if (char.IsDigit(linha[i - 1]) && char.IsDigit(linha[i + 1]))
                    {
                        sb.Append('.');
                        sb.Replace(">", "até");
                    }
                    else
                    {
                        sb.Append(",");
                        sb.Replace(">", "em diante");
                    }
                }
                else if (linha[i].Equals("/") && linha[i + 1].Equals("/"))
                {
                    sb.Replace("//", "-");
                }
                else
                {
                    sb.Append(linha[i]);
                }

            }
            return sb.ToString();
        }
        static string ConversorTecfil(StringBuilder sb)
        {
            string[] linhas = sb.ToString().Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            string armazenaConversao = "";

            foreach (string linha in linhas)
            {
                int ultimaPosicao = linha.LastIndexOf('>');
                armazenaConversao += ConverteBarra(linha);
            }
            return armazenaConversao;
        }

        static string ConversorKYB(StringBuilder sb)
        {
            sb.Replace("/...", " em diante");
            sb.Replace("...", " até ");
            return sb.ToString();
        }
        //catalogo monroe
    }
    /*
  * if (primeiraPosicao >= 0 && proximaPosicao > primeiraPosicao && proximaPosicao < ultimaPosicao)
{
    sb.Append(linha.Replace(">", "até", primeiraPosicao, 1).Replace(">", "em diante", proximaPosicao, 1));
}
else
{
    sb.Append(linha);
}
*/

    /*
1-
2-
3-
4-
5-
6-
7-
8-
9-
10-
11-
12-
13-
14-
15-
16-
17-
18-
19-
20-
     */

}