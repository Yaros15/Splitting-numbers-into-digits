using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Tasc1
{
    class SplittingNumbers
    {
        /* Метод получает в качестве аргумента строку из поля ввода. Преобразует строку в число для проверки корректности ввода.  
         Но дальше работаем с текстом. Используем его длину, для пробигания по циклу. В следующем цикле определяем сколько нужно нулей.
         Затем присваиваем символ из текста в переменную типа чар и если нет, то сумируем всю информацию, записываем в стринг и возвращаем данные.
             */
        public string spliting (string text)
        {
            long number;
            string result = null;

            try
            {
                number = long.Parse(text);
                for (int i = 0; i<text.Length; i++)
                {
                    string zero = null;
                    int loopIterations = text.Length - i - 1;
                    while (loopIterations > 0)
                    {
                        zero += "0";
                        loopIterations--;
                    }
                    if (zero != null)
                    {
                        zero = zero + " + ";
                    }
                    char sigit = text [i];
                    string digin = sigit.ToString();
                    if (!digin.Equals("0"))
                    {
                        result = result + digin + zero;
                    }
                }
                return result;
            } catch (Exception)
            {
                result = "Ошибка ввода текста";
                return result;
            }
        }

    }
}
