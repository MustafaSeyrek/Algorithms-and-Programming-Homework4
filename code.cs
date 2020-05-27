using System;

namespace HomeworkSon
{
    class Program

    {
        static int yerBul(string str, char c)
        {
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (c == str[i])
                {
                    break;
                }
                counter++;
            }
            return counter;           
        }
        static void Main(string[] args)
        {
            String letter = "oyuncak evi yıkıp yaksak yapsak da mı otursak yoksa yıkmasak onarsak da mı otursak eve";
            letter = letter.ToLower();
            Boolean flag = false, yazIzni = false, önceYazılıMı = false;
            int yıldızYeri = 0, eksiYeri = 0, yıldızFark = 0, kont = 0;
            String[] words = letter.Split(' ');
            string[] yazılı = new string[words.Length];
            Console.Write("Please enter a input= ");
            String input = Console.ReadLine();
            input = input.ToLower();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '*')
                {
                    kont++;
                }
                else if (input[i] == '-')
                {
                    kont++;
                }
            }
            if (kont != 2)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == '*')
                    {
                        kont = 1;
                        break;
                    }
                    else if (input[i] == '-')
                    {
                        kont = 0;
                        break;
                    }
                }
            }
            if (kont == 0)
            {
                eksiYeri = yerBul(input, '-');
            }
            else if (kont == 1)
            {
                yıldızYeri = yerBul(input, '*');
            }
            else if (kont == 2)
            {
                eksiYeri = yerBul(input, '-');
                yıldızYeri = yerBul(input, '*');
            }
            if (kont == 0)
            {
                for (int i = 0; i < words.Length; i++)
                {
                    yazIzni = true;
                    if (input.Length == words[i].Length)//"-" de karakter sayıları birbirine eşit olmak zorunda
                    {
                        for (int j = 0; j < words[i].Length; j++)
                        {
                            if (words[i][j] != input[j] && input[j] != '-')
                            {
                                yazIzni = false;
                            }
                        }
                    }
                    else
                    {
                        yazIzni = false;
                    }
                    if (yazIzni)
                    {
                        int yazılıBoyut = 0;
                        for (int k = 0; k < yazılı.Length; k++)
                        {
                            if (yazılı[k] == words[i])
                            {
                                önceYazılıMı = true;
                            }
                            if (yazılı[k] != null)
                                yazılıBoyut++;
                        }
                        if (!önceYazılıMı)
                        {
                            Console.WriteLine(words[i]);
                            flag = true;
                            yazılıBoyut++;
                            yazılı[yazılıBoyut] = words[i];
                        }
                        önceYazılıMı = false;
                    }
                }
            }
            else if (kont == 1 || kont == 2)
            {
                for (int i = 0; i < words.Length; i++)
                {
                    yazIzni = true;
                    yıldızFark = words[i].Length - input.Length + 1;//+1 yıldızdan dolayıdır;
                    for (int j = 0; j < words[i].Length; j++)
                    {
                        if (j < yıldızYeri && input[j] != words[i][j] && input[j] != '-')
                        {
                            yazIzni = false;
                            break;
                        }
                        else if (j >= yıldızYeri + yıldızFark && words[i][j] != input[j + 1 - yıldızFark] && input[j + 1 - yıldızFark] != '-')
                        {
                            yazIzni = false;
                        }
                    }
                    if (yazIzni)
                    {
                        int yazılıBoyut = 0;
                        for (int k = 0; k < yazılı.Length; k++)
                        {
                            if (yazılı[k] == words[i])
                            {
                                önceYazılıMı = true;
                            }
                            if (yazılı[k] != null)
                                yazılıBoyut++;
                        }
                        if (!önceYazılıMı)
                        {
                            Console.WriteLine(words[i]);
                            flag = true;
                            yazılıBoyut++;
                            yazılı[yazılıBoyut] = words[i];
                        }
                        önceYazılıMı = false;
                    }
                }
            }
            if (!flag)
                Console.WriteLine("NOT FOUND");
            Console.ReadLine();
        }
    }
}