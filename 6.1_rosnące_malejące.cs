using System;
using System.Globalization;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int a=0;
        int[,] tablica = new int[10,10];
        for(int i = 0; i <10; i++)
        {
            for(int j = 0; j <10; j++)
            {
                if (j == 0)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine("Podaj wartość a ");
                        a = inputValue();
                        tablica[i,j]= a;
                    }
                    else
                    {
                        Console.WriteLine("Podaj wartość a większą od 10");
                        a = inputValue();
                        while (a < 10)
                        {
                            Console.WriteLine("Podaj wartość a większą od 10");
                            a = inputValue();
                        }
                        tablica[i,j] = a;
                    }
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        tablica[i,j] = tablica[i,j-1]+1;
                    }
                    else
                    {
                        tablica[i,j] = tablica[i,j - 1] - 1;
                    }
                }
            }
        }
        for (int i = 0;i <10;i++)
        {
            Console.WriteLine();
            for (int j = 0; j < 10; j++)
            {
                Console.Write(tablica[i,j]);
		        Console.Write("\t");
            }
        }
    }
    private static int inputValue()
    {
        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }

}