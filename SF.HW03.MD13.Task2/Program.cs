namespace SF.HW03.MD13.Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Читаем весь файл в строку
            string text = File.ReadAllText("C:\\Users\\dvalu\\OneDrive\\Документы\\SF\\SF.HW03.MD13\\Text.txt");
            
            //Убираем из текста знаки пунктуации
            var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());

            // Сохраним символы разделители в массив
            char[] delimiters = new char[] { ' ', '\r', '\n' };

            //Разбиваем строку текста, изпользуя символы-разделители
            var words = noPunctuationText.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            //Размещаем в словаре и подсчитываем повторения слов
            foreach (var word in words)
            {
                if (dictionary.Keys.Contains(word))
                {
                    dictionary[word]++;
                }
                else
                {
                    dictionary.Add(word, 1);
                }
            }

            //Отбираем 10 слов, которые чаще всего встречаются в тексте
            string str = "";
            int count = 0;
            foreach (KeyValuePair<string, int> keyValuePair in dictionary.OrderByDescending(x => x.Value))
            {
                str += keyValuePair.Key + " " + keyValuePair.Value.ToString() + "\n";
                count++;
                if (count == 10) break;    
            }

            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
