//ZAD1

using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int a = 0, kolumny, wiersze;
        Console.WriteLine("Podaj ilość wierszy macierzy:");
        wiersze = inputValue();
        Console.WriteLine("Podaj ilość kolumn macierzy:");
        kolumny = inputValue();
        while (wiersze != kolumny)
        {
            Console.WriteLine("Podaj ilość wierszy macierzy (taką samą jak ilość kolumn):");
            wiersze = inputValue();
            Console.WriteLine("Podaj ilość kolumn macierzy (taką samą jak ilość wierszy):");
            kolumny = inputValue();
        }
        int[,] tablica = new int[wiersze, kolumny];
        for (int i = 0; i < wiersze; i++)
        {
            for (int j = 0; j < kolumny; j++)
            {
                if (j == 0)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine("Podaj wartość a:");
                        a = inputValue();
                        tablica[i, j] = a;
                    }
                    else
                    {
                        Console.WriteLine("Podaj wartość a większą od 10:");
                        a = inputValue();
                        while (a < 10)
                        {
                            Console.WriteLine("Podaj wartość a większą od 10:");
                            a = inputValue();
                        }
                        tablica[i, j] = a;
                    }
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        tablica[i, j] = tablica[i, j - 1] + 1;
                    }
                    else
                    {
                        tablica[i, j] = tablica[i, j - 1] - 1;
                    }
                }
            }
        }
        for (int i = 0; i < wiersze; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < kolumny; j++)
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


//ZAD2

using System;

public class MyProgram
{
    public static void Main()
    {
        int a = 1, wiersz, kolumna, w_wys, k_wys, kierunek = 0;
        Console.WriteLine("Podaj ilość wierszy macierzy:");
        wiersz = inputValue();
        Console.WriteLine("Podaj ilość kolumn macierzy:");
        kolumna = inputValue();
        while (wiersz != kolumna)
        {
            Console.WriteLine("Podaj ilość wierszy macierzy (taką samą jak ilość kolumn):");
            wiersz = inputValue();
            Console.WriteLine("Podaj ilość kolumn macierzy (taką samą jak ilość wierszy):");
            kolumna = inputValue();
        }
        int[,] tablica = new int[wiersz, kolumna];
        w_wys = wiersz;
        k_wys = kolumna;
        kolumna = 0;
        wiersz = 0;
        for (int i = 0; i < w_wys * k_wys; i++)
        {
            tablica[wiersz, kolumna] = a++;
            switch (kierunek)
            {
                case 0:
                    if (kolumna + 1 >= k_wys || tablica[wiersz, kolumna + 1] != 0)
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
                    if (wiersz + 1 >= w_wys || tablica[wiersz + 1, kolumna] != 0)
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
        for (int i = 0; i < w_wys; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < k_wys; j++)
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

#endif