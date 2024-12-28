using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Tyuiu.SizikovSS.Sprint7.V8.Lib
{
    public class DataService
    {
        public bool ParceID(string str)//проверка для id
        {
            // Регулярное выражение для проверки строки на соответствие условиям
            Regex regex = new Regex(@"^[0-9]{6}$");

            // Проверка строки
            return regex.IsMatch(str);
        }
        public bool ParceProbeg(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
        public bool ParceDate(string date)
        {
            // Создаем объект DateTime для хранения результата парсинга
            DateTime parsedDate;

            // Пробуем преобразовать строку в формат dd.MM.yyyy
            if (DateTime.TryParseExact(date, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int CalculateDaysDifference(string date1, string date2)
        {
            // Парсим даты из строкового представления
            DateTime firstDate = ParseDate(date1);
            DateTime secondDate = ParseDate(date2);

            // Вычисляем разницу в днях
            TimeSpan timeDiff = secondDate - firstDate;
            int daysDifference = Math.Abs(timeDiff.Days);

            return daysDifference;
        }

        private static DateTime ParseDate(string dateString)
        {
            // Форматируем дату для парсинга
            DateTime parsedDate;
            bool isParsed = DateTime.TryParseExact(
                dateString,
                "dd.MM.yyyy",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out parsedDate
            );

            if (!isParsed)
            {
                throw new FormatException($"Дата '{dateString}' имеет неверный формат. Ожидается 'ДД.ММ.ГГГГ'.");
            }

            return parsedDate;
        }

        public string[,] ReadCsvFile()
        {
            // Получаем полный путь к файлу относительно корневой директории проекта
            string filePath = Path.GetFullPath(Directory.GetCurrentDirectory() + @"\..\..\..\..\Data\DataBaseTO.csv");

            // Проверяем существование файла
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"Файл {filePath} не найден.");
            }

            // Считывание всех строк из файла
            var lines = File.ReadAllLines(filePath, Encoding.UTF8);

            // Определение размеров двумерного массива
            int rowsCount = lines.Length;
            int colsCount = lines[0].Split(';').Length;

            // Создание двумерного массива
            string[,] dataBase = new string[rowsCount, colsCount];

            for (int i = 0; i < rowsCount; i++)
            {
                var values = lines[i].Split(';');
                for (int j = 0; j < colsCount; j++)
                {
                    dataBase[i, j] = values[j];
                }
            }

            return dataBase;
        }

        public void AppendToCsvFile(string array)
        {
            // Получаем полный путь к файлу относительно корневой директории проекта
            string filePath = Path.GetFullPath(Directory.GetCurrentDirectory() + @"\..\..\..\..\Data\DataBaseTO.csv");

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Файл не найден.", filePath);
            }

            // Открываем файл для записи в конец
            using (var writer = new StreamWriter(filePath, append: true, Encoding.UTF8))
            {
                writer.WriteLine(array, Encoding.UTF8); // Запись каждого элемента массива в отдельную строку

            }
        }

        public void DelFromCsvFile(string idToDelete)
        {
            // Путь к файлу
            string filePath = Path.GetFullPath(Directory.GetCurrentDirectory() + @"\..\..\..\..\Data\DataBaseTO.csv");

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Файл не найден.", filePath);
            }

            // Чтение всех строк файла с использованием кодировки UTF-8
            string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);

            // Фильтрация строк, исключая ту, где id совпадает с переданным значением
            var filteredLines = lines.Where(line => !line.StartsWith(idToDelete)).ToArray();

            // Запись отфильтрованных строк обратно в файл с использованием кодировки UTF-8
            File.WriteAllLines(filePath, filteredLines, Encoding.UTF8);
        }

        public void AddProbeg(string gosnomer, string actprobeg)
        {
            // Путь к файлу
            string filePath = Path.GetFullPath(Directory.GetCurrentDirectory() + @"\..\..\..\..\Data\DataBaseTO.csv");

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Файл не найден.", filePath);
            }

            // Получить строку по госномеру
            string targetLine = GetLineById(gosnomer);

            if (targetLine == null)
            {
                throw new ArgumentException($"Строка с госномером '{gosnomer}' не найдена в файле.");
            }

            // Разделить строку на части
            string[] parts = targetLine.Split(';');

            // Преобразовать пятый элемент (с индекса 4) в число
            if (!int.TryParse(parts[4], out int toProbeg))
            {
                throw new FormatException($"Пятый элемент строки ('{parts[4]}') не является числом.");
            }

            // Рассчитать разницу
            int difference = int.Parse(actprobeg) - toProbeg;

            // Объявляем переменную needed вне условий
            string needed = " ";

            DateTime currentDateTime = DateTime.Now;
            currentDateTime.ToString("dd.MM.yyyy");//Получаем дату с операционной системы
            string toDateTime = parts[5];

            int dayDifferens = CalculateDaysDifference(toDateTime, currentDateTime.ToString("dd.MM.yyyy"));

            if (difference < 7000 && dayDifferens < 120)
            {
                needed = "Не нуждается в ТО";
            }
            else if (7000 <= difference && difference < 12000 || (120 <= dayDifferens && dayDifferens < 200))
            {
                needed = "Рекомендуется ТО";
            }
            else if (12000 <= difference && difference < 17000 || (7000 <= difference && difference < 12000 || (300 <= dayDifferens)))
            {
                needed = "Нуждается в ТО";
            }
            else if (17000 <= difference && difference < 19000 || ((12000 <= difference && difference < 17000) && (300 <= dayDifferens)))
            {
                needed = "Острая нужда в ТО";
            }
            else if (19000 <= difference || (500 <= dayDifferens))
            {
                needed = "Немедленно провести ТО";
            }

            // Собрать новую строку
            string updatedLine = $"{targetLine};{actprobeg};{needed}";

            // Чтение всех строк файла с использованием кодировки UTF-8
            string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);

            // Найти индекс исходной строки
            int index = Array.IndexOf(lines, targetLine);

            // Обновить строку в массиве
            lines[index] = updatedLine;

            // Записать обновленные строки обратно в файл
            File.WriteAllLines(filePath, lines, Encoding.UTF8);
        }
        public string GetLineById(string id)
        {
            // Путь к файлу
            string filePath = Path.GetFullPath(Directory.GetCurrentDirectory() + @"\..\..\..\..\Data\DataBaseTO.csv");

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Файл не найден.", filePath);
            }

            // Чтение всех строк файла с использованием кодировки UTF-8
            string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);

            // Поиск строки, начинающейся с указанного id
            string foundLine = lines.FirstOrDefault(line => line.StartsWith(id));

            return foundLine;
        }
    }

}

