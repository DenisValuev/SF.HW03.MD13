using System.Diagnostics;

namespace SF.HW03.MD13.Task1.TestLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Читаем весь файл в строку
            string text = File.ReadAllText("C:\\Users\\dvalu\\OneDrive\\Документы\\SF\\SF.HW03.MD13\\Text.txt");

            //Сохраним символы разделители в массив
            char[] delimiters = new char[] { ' ', '\r', '\n' };

            //Разбиваем строку текста, изпользуя символы-разделители
            var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            #region New linkedList
            //Запускаем новый таймер
            var stopWatch = Stopwatch.StartNew();

            //Создаем  список с типом данный string и добавляем в список массив words
            var textTestLinkedList = new LinkedList<string>(words);

            //Вывод на экран время выполнения операции в миллисекундак
            Console.WriteLine("Время выполнения операции: " + stopWatch.Elapsed.TotalMilliseconds);
            #endregion

            #region AddAfterFirst
            stopWatch = Stopwatch.StartNew();

            textTestLinkedList.AddAfter(textTestLinkedList.First, "TEST");

            Console.WriteLine("Время выполнения вставки после первого элемента: " + stopWatch.Elapsed.TotalMilliseconds);
            #endregion

            #region AddAfterLast
            stopWatch = Stopwatch.StartNew();

            textTestLinkedList.AddAfter(textTestLinkedList.Last, "TEST");

            Console.WriteLine("Время выполнения вставки после последнего элемента: " + stopWatch.Elapsed.TotalMilliseconds);
            #endregion
            //Вычисляем размер коллекции
            int countTestLinkedList = textTestLinkedList.Count;
            Console.WriteLine($"Размер двухсвязного списка: {countTestLinkedList}");

            Console.ReadKey();
        }
    }
}
