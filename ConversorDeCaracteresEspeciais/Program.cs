using System;
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
                Console.WriteLine("Código Original: ");
                Console.WriteLine(codigoOriginal);
                Console.WriteLine("\n");
                if (catalogo == "wega" || catalogo == "WEGA" || catalogo == "Wega")
                {
                    Console.WriteLine("Marca: WEGA - Peça Genuína");
                }
                else if (catalogo == "originall" || catalogo == "ORIGINALL" || catalogo == "originALL" || catalogo == "Originall" || catalogo == "Original" || catalogo == "original" || catalogo == "ORIGINAL")
                {
                    Console.WriteLine("Marca: ORIGINALL - Peça Genuína");
                }
                else if (catalogo == "Tecfil" || catalogo == "tecfil" || catalogo == "TECFIL" || catalogo == "TecFil")
                {
                    Console.WriteLine("Marca: TECFIL- Peça Genuína");

                }
                Console.WriteLine("\n");
                Console.WriteLine("Intercambialidade: ");
                Console.WriteLine("\n");
                Console.WriteLine("Observação:");
                Console.WriteLine("Altura: ");
                Console.WriteLine("Comprimento:");
                Console.WriteLine("Largura:");
                Console.WriteLine("Diâmetro Externo: ");
                Console.WriteLine("Diâmetro Interno: ");
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
            Accelo - 915 C - OM 904 LA // 2007 --> 
            Accelo - 915 C - OM 904 LA // 2007 --> 
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
        static string ConversorTecfil(StringBuilder sb)
        {
            string[] linhas = sb.ToString().Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            
            foreach (string linha in linhas)
            {
                int dezNonosTexto= ((linha.Length / 10) * 9);
                sb.Replace(">", "em diante").Replace("//", "-").Replace("--", "até");
                if (linha.IndexOf('/') < dezNonosTexto)
                {
                    sb.Replace("/", " , ");
                }
                else if (linha.IndexOf('/') > dezNonosTexto)
                {
                    sb.Replace("/", ". ");
                }
            }
            return sb.ToString();
        }
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

    }