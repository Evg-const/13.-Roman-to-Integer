using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Roman_to_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ;)
            {
                Console.WriteLine("Введите Римское число: ");
                string input = Console.ReadLine();
                Console.WriteLine(RomanToInt(input));
            }
            
            int RomanToInt(string s)
            {
                int result = 0;

                int temp(char t)
                {  //принимакет символ - отдает нужную цифру
                    switch (t)
                    {
                        case 'I':
                            return 1;
                            break;

                        case 'V':
                            return 5;
                            break;

                        case 'X':
                            return 10;
                            break;

                        case 'L':
                            return 50;
                            break;

                        case 'C':
                            return 100;
                            break;

                        case 'D':
                            return 500;
                            break;

                        case 'M':
                            return 1000;
                            break;
                        default:
                            return 0;
                            break;
                    }
                }

                if (s.Length == 0)
                {  //если строка равна нулю
                    return 0;
                }

                if (s.Length > 1)
                {       //если в строке больше одного символа
                    for (int i = 1; i < s.Length; i++)
                    {

                        if (temp(s[(s.Length - i - 1)]) >= temp(s[(s.Length - i)]))
                        { //если первый символ больше след.

                            result += temp(s[(s.Length - i)]);
                        }
                        else
                        {
                            result += temp(s[(s.Length - i)]) - temp(s[(s.Length - i - 1)]); //если первый символ меньше след.
                            i++;
                        }

                    }
                    if (temp(s[0]) >= temp(s[1]))
                    {
                        result += temp(s[0]);
                    }
                }

                else
                {                   //если в строке один символ
                    result = temp(s[0]);    //перевод полько этого символа
                }


                return result;
            }




        }
    }
}
