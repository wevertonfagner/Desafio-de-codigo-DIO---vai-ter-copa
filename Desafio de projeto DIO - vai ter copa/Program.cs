using System;

namespace Desafio_de_projeto_DIO___vai_ter_copa
{
        class DIO
        {

            static void Main(string[] args)
            {

                string str;
                while ((str = Console.ReadLine()) != null)
                {
                    int x = int.Parse(str);
                    if (x == 0)
                    {
                        Console.WriteLine("vai ter copa!");
                    }
                    else
                    {
                        Console.WriteLine("vai ter duas!");
                    }

                }

            }

        }
}