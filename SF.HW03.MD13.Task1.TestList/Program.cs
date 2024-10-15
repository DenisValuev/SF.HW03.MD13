using System.Diagnostics;

namespace SF.HW03.MD13.Task1.TestList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Читаем весь файл в строку
            string text = File.ReadAllText("C:\\Users\\dvalu\\OneDrive\\Документы\\SF\\SF.HW03.MD13\\Text.txt");

            //Сохраним символы разделители в массив
            char[] delimiters = new char[] { ' ', '\r', '\n' };

            //Разюиваем строку текса, изпользуя символы-разделители
            var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
           
            //Создаем пустой список с типом данный string
            var textTestList = new List<string>();

            #region AddRange list
            //Запускаем новый таймер
            var stopWatch = Stopwatch.StartNew();

            //Добавляем в список массив words
            textTestList.AddRange(words);

            //Вывод на экран время выполнения операции в миллисекундак
            Console.WriteLine("Время заполнения списка: " + stopWatch.Elapsed.TotalMilliseconds);
            #endregion

            #region Insert in the middle
            //Вычисляем размер коллекции
            int countTestList = textTestList.Count;
            Console.WriteLine($"Размер двухсвязного списка: {countTestList}");

            int halfCount = countTestList / 2;

            //Запускаем новый таймер
            Stopwatch.StartNew();

            //Добавляем в список массив words
            textTestList.Insert(halfCount, "TEST");

            //Вывод на экран время выполнения операции в миллисекундак
            Console.WriteLine("Время выполнения вставки в середину коллекции: " + stopWatch.Elapsed.TotalMilliseconds);
            #endregion

            #region Insert at the end list
            Stopwatch.StartNew();

            //Добавляем в список массив words
            textTestList.Add("TEST");

            //Вывод на экран время выполнения операции в миллисекундак
            Console.WriteLine("Время добавления в конец коллекции: " + stopWatch.Elapsed.TotalMilliseconds);
            #endregion


            Console.ReadKey();
        }
    }
}
