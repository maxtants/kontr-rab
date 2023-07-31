// Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе Разработчик. Мы должны убедится, что базовое знакомство с IT прошло успешно.

// Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:

// 1.Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
// 3.Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
// 4.Написать программу, решающую поставленную задачу
// 5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []



string[] ReadConsole(string msg)
{
    Console.Write(msg);
    string input = Console.ReadLine();
    string[] words = input.Substring(1, input.Length - 2).Split(", ");
    return words;
}

int CountTripleOrLessWords(string[] words)
{
    int count = 0;
    foreach (string word in words)
    {
        if (word.Length - 2 <= 3) count++;
    }
    return count;
}

string[] CreateTripleOrLessWordsArray(int size, string[] words)
{
    string[] array = new string[size];
    int j = 0;
    for (int i = 0; i < words.Length; i++)
    {
        if (words[i].Length - 2 <= 3)
        {
            array[j] = words[i];
            j++;
        }
    }
    return array;
}

void PrintArray(string[] array)
{
    string res = "";

    foreach (string el in array)
    {
        res += el + ", ";
    }

    if (res == "")
    {
        System.Console.WriteLine("[]");
    }
    else
    {
        System.Console.WriteLine("[" + res.Substring(0, res.Length - 2) + "]");
    }
}

Console.Clear();
string[] words = ReadConsole("Введите массив строк в кваратных скобках в кавычках через запятую и пробел: ");
int size = CountTripleOrLessWords(words);
string[] array = CreateTripleOrLessWordsArray(size, words);
PrintArray(array);
