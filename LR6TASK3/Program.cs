using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Random o = new Random();
        List<int> chisla = new List<int>();

        List<int> parni = new List<int>();
        List<int> neparni = new List<int>();

        int N = 10;

        Console.Write("Початкова колекція: ");
        for (int i = 0; i < N; i++)
        {
            chisla.Add(o.Next(1, 21));
            Console.Write("{0} ", chisla[i]);
        }
        Console.WriteLine();

        for (int i = 0; i < chisla.Count; i++)
        {
            if (chisla[i] % 2 == 0)
            {
                parni.Add(chisla[i]);
            }
            else
            {
                neparni.Add(chisla[i]);
            }
        }

        Console.Write("Парні числа: ");
        for (int i = 0; i < parni.Count; i++)
        {
            Console.Write("{0} ", parni[i]);
        }
        Console.WriteLine();

        Console.Write("Непарні числа: ");
        for (int i = 0; i < neparni.Count; i++)
        {
            Console.Write("{0} ", neparni[i]);
        }
    }
}
