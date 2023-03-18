using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "C:\\Users\\chern\\Desktop\\input.txt"; // путь к файлу
        int sum = 0; // общая сумма чисел
        int count = 0; // количество чисел

        // Чтение файла построчно
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                // Удаление пробелов в начале и конце строки
                line = line.Trim();

                // Попытка преобразования строки в число
                int number;
                if (int.TryParse(line, out number))
                {
                    sum += number;
                    count++;
                }
            }
        }

        Console.WriteLine("Сумма чисел: " + sum);
        Console.WriteLine("Количество чисел: " + count);
    }
}
