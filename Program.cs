using System;

namespace split
{
    class Program
    {
        static void Main(string[] args)
        {
            string frases;
            
            Console.WriteLine("DIGITE AS 4  PALAVRAS DESEJADAS EM UMA UNICA LINHA SEPARANDO POR ESPAÇOS");
            frases = Console.ReadLine();

            string[] vet = frases.Split(' ');

            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];
            string p4 = vet[3];

            Console.WriteLine("\nVOCÊ DIGITOU: \n");
            Console.WriteLine(frases);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine(p4);
        }
    }
}
