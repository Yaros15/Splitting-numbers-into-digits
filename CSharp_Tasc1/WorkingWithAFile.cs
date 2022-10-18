using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Tasc1
{
    class WorkingWithAFile
    {
        private string pathSave = @"C:\Users\user\Desktop\Файл.txt";
        private string pathUpload;
        private StreamWriter streamWriter;
        private StreamReader streamReader;

        // сеттер для получения пути для загрузки файла
        public void setPath (string pathUpload)
        {
            this.pathUpload = pathUpload;
        }

        // Метод получает в аргументи страку из ввода. Проверяем корректность преобразовав в число, но работаем с стракой.
        // Используем объект для записи данных в файл на новой строке
        public string saveAnEntry(string saveANumber)
        {
            long number;
            string result;

            try
            {
                number = long.Parse(saveANumber);

                using (streamWriter = new StreamWriter(pathSave, true)) {
                    streamWriter.WriteLine(saveANumber);
                }
                result = "Число сохранено";
                return result;

            } catch (Exception) {
                result = "Ошибка ввода текста";
                return result;
            }

         }

        // Используем объект для чтения файла. В цикле пробегаем по всем строкам. Последнюю строку передаем в качестве возвращаемого значения
        public string uploadAFile()
        {
            string liner = null;
            string line;
            using (streamReader = new StreamReader(pathUpload))
            {
                
                while ((line = streamReader.ReadLine()) != null)
                {
                    liner = line;
                }
            }
            return liner;
        }
     }
 }
