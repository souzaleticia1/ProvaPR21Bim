using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaPR21Bim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;

            Console.WriteLine("Digite o exercício: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    int valorAb;

                    Console.WriteLine("Digite um valor: ");
                    valorAb = int.Parse(Console.ReadLine());

                    if(valorAb < 0)
                    {
                        valorAb = valorAb * -1;
                        Console.WriteLine("Valor absoluto: " + valorAb);
                    }
                    else
                        Console.WriteLine("Valor absoluto: " + valorAb);
                    break; 
                case 2:
                    int numDi;

                    Console.WriteLine("Digite um valor: ");
                    numDi = int.Parse(Console.ReadLine());

                    if(numDi %3 == 0 && numDi %5 == 0)
                        Console.WriteLine(numDi + " é divisível por 3 e 5");
                    else
                        if(numDi %4 == 0 && numDi %7 == 0)
                            Console.WriteLine(numDi + " é divisível por 4 e 7");
                    else
                        if(numDi %3 == 0)
                        Console.WriteLine(numDi + " é divisível por 3");
                    else
                        if(numDi %4 == 0)
                        Console.WriteLine(numDi + " é divisível por 4");
                    else
                        if(numDi %5 == 0)
                        Console.WriteLine(numDi + " é divisível por 5");
                    else
                        if(numDi %7 == 0)
                        Console.WriteLine(numDi + " é divisível por 7");
                    else
                        Console.WriteLine("O número " + numDi + " não é divisível por 3, 4, 5 e 7");
                    break;
                case 3:
                    int numMaiMen, maior, menor, numI = 0;

                    Console.WriteLine("Digite um valor: ");
                    numMaiMen = int.Parse(Console.ReadLine());

                    maior = numMaiMen;
                    menor = numMaiMen;

                    for( ; numI < 2 ;)
                    {
                        Console.WriteLine("Digite outro valor: ");
                        numMaiMen = int.Parse(Console.ReadLine());

                        if (numMaiMen > maior)
                            numMaiMen = maior;
                        else
                            if(numMaiMen < menor)
                            numMaiMen = menor;
                        numI++;

                    }
                    Console.WriteLine("Maior: " + maior);
                    break;
                case 4:
                    int numSem;

                    Console.WriteLine("Digite um número de acordo com os dias da semana: ");
                    numSem = int.Parse(Console.ReadLine());

                    switch (numSem)
                    {
                        case 1:
                            Console.WriteLine("Domingo - O que gosto de fazer:");
                            Console.WriteLine("- Dormir bastante");
                            Console.WriteLine("- Assistir filmes/séries");
                            Console.WriteLine("- Jogar video game");
                            Console.WriteLine("- Relaxar o máximo possível");
                            break;
                        case 2:
                            Console.WriteLine("Segunda - Diciplinas:");
                            Console.WriteLine("- Filosofia");
                            Console.WriteLine("- Português");
                            Console.WriteLine("- Matemática");
                            break;
                        case 3:
                            Console.WriteLine("Terça - Diciplinas:");
                            Console.WriteLine("- Química");
                            Console.WriteLine("- História");
                            Console.WriteLine("- Inglês para o mundo da informática");
                            Console.WriteLine("- Libras");
                            break;
                        case 4:
                            Console.WriteLine("Quarta - Diciplinas:");
                            Console.WriteLine("- Biologia");
                            Console.WriteLine("- Português");
                            Console.WriteLine("- Programação");
                            break;
                        case 5:
                            Console.WriteLine("Quinta - Diciplinas:");
                            Console.WriteLine("- Física");
                            Console.WriteLine("- Rede de computadores");
                            Console.WriteLine("- Sociologia");
                            break;
                        case 6:
                            Console.WriteLine("Sexta - Diciplinas:");
                            Console.WriteLine("- Geografia");
                            Console.WriteLine("- Matemática");
                            Console.WriteLine("- Banco de dados");
                            break;
                        case 7:
                            Console.WriteLine("Sábado - O que gosto de fazer:");
                            Console.WriteLine("- Dormir bastante");
                            Console.WriteLine("- Assistir filmes/séries");
                            Console.WriteLine("- Jogar video game");
                            Console.WriteLine("- Relaxar o máximo possível");
                            break;
                        default:
                            Console.WriteLine("Número inválido!");
                            break;
                    }
                    break;
                case 5:
                    int numSeq, numMai, numMen;

                    Console.WriteLine("Digite um valor: ");
                    numSeq = int.Parse(Console.ReadLine());

                    numMai = numSeq;
                    numMen = numSeq;

                    for ( ; numSeq != 0 ; )
                    {
                        Console.WriteLine("Digite outro valor: ");
                        numSeq = int.Parse(Console.ReadLine());

                        if (numSeq > numMen)
                            numSeq = numMai;
                        else
                            numSeq = numMen;
                    }
                    Console.WriteLine("Maior: " + numMai);
                    Console.WriteLine("Menor: " + numMen);
                    break;
                case 6:
                    int numPer, numMen1 = 0, somaNumMen1 = 0;

                    Console.WriteLine("Digite um valor: ");
                    numPer = int.Parse(Console.ReadLine());

                    for( ; numMen1 != 0 ;)
                    {
                        numMen1 = numPer - numMen1;
                        somaNumMen1 = somaNumMen1 + numMen1;
                    }
                    
                    if(somaNumMen1 == numPer)
                        Console.WriteLine("O número " + numPer + " é um número perfeiro");
                    else
                        Console.WriteLine("O número " + numPer + " não é um número perfeiro");
                    break;
                case 7:
                    int numSeq2, somaNumSeq2 = 0, medNumSeq2Par, contSeq2 = -1;

                    Console.WriteLine("Digite um valor: ");
                    numSeq2 = int.Parse(Console.ReadLine());

                    if (numSeq2 % 2 == 0)
                        somaNumSeq2 = numSeq2;

                    for( ; numSeq2 != 0 ;)
                    {
                        Console.WriteLine("Digite outro valor: ");
                        numSeq2 = int.Parse(Console.ReadLine());

                        if (numSeq2 % 2 == 0)
                            somaNumSeq2 = somaNumSeq2 + numSeq2;
                        contSeq2++;
                    }
                    medNumSeq2Par = somaNumSeq2 / contSeq2;
                    
                    if(somaNumSeq2 == 0)
                        Console.WriteLine("Não foi possível calcular a média!");
                    else
                        Console.WriteLine("Média aritmética: " + medNumSeq2Par);
                    break;
                default:
                    Console.WriteLine("Valor inválido!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
