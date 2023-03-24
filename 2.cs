using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {   string m = Console.ReadLine();
            
            int nomer; // Номер в алфавите
            int d; // Смещение
            string s; //Результат
            int j; // Переменная для циклов

            char[] massage = m.ToCharArray();

            char[] alfavit = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
            for (int i = 0; i < massage.Length; i++)
            {
                // Ищем индекс буквы
                for (j = 0; j < alfavit.Length; j++)
                {
                    if (massage[i] == alfavit[j])
                    {
                        break;
                    }
                }

                if (j != 33)
                {
                    nomer = j;
                    d = nomer + 3;

                    
                    if (d > 32)
                    {
                        d = d - 33;
                    }

                    massage[i] = alfavit[d];
                }
            }
           
            s = new string(massage);
            Console.WriteLine("After:\n" + s);
            char[] s1 = s.ToCharArray();
             for (int i = 0; i < s1.Length; i++)
            {
                // Ищем индекс буквы
                for (j = 0; j < alfavit.Length; j++)
                {
                    if (s1[i] == alfavit[j])
                    {
                        break;
                    }
                }

                if (j != 33)
                {
                    nomer = j;
                    d = nomer - 3;

                    
                    if (d > 32)
                    {
                        d = d - 33;
                    }

                    s1[i] = alfavit[d];
                }
            }
            s = new string(s1);
            Console.WriteLine("Before:\n" + s);
        }
    }
