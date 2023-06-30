using System;
using System.Drawing;
using System.Globalization;

public class MyProgram
{
    public static void Main()
    {
        int[,] tablica = new int[10, 10];
        int a = 1, wiersz = 0, kolumna = 0, kierunek = 0;

        for (int i = 0; i < 100; i++)
        {
            tablica[wiersz, kolumna] = a++;
            switch (kierunek)
            {
                case 0:
                    if (kolumna + 1 >= 10 || tablica[wiersz, kolumna + 1] != 0)
                    {
                        kierunek = 1;
                        wiersz++;
                    }
                    else
                    {
                        kolumna++;
                    }
                    break;
                case 1:
                    if (wiersz + 1 >= 10 || tablica[wiersz + 1, kolumna] != 0)
                    {
                        kierunek = 2;
                        kolumna--;
                    }
                    else
                    {
                        wiersz++;
                    }
                    break;
                case 2:
                    if (kolumna - 1 < 0 || tablica[wiersz, kolumna - 1] != 0)
                    {
                        kierunek = 3;
                        wiersz--;
                    }
                    else
                    {
                        kolumna--;
                    }
                    break;
                case 3:
                    if (wiersz - 1 < 0 || tablica[wiersz - 1, kolumna] != 0)
                    {
                        kierunek = 0;
                        kolumna++;
                    }
                    else
                    {
                        wiersz--;
                    }
                    break;
            }
        }
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < 10; j++)
            {
                Console.Write(tablica[i, j]);
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
