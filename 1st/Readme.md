[Описание решения](#описание-решения)
=

Для решения задачи мы будем самостоятельно задавать размер строчного массива, введя метод ***GetSize***
### [GetSize](#getsize)

    int GetSize(string text)
    {
        Console.Write(text);
        string size = Console.ReadLine();
        while (int.TryParse(size, out _) == false || String.IsNullOrEmpty(size) || 
        int.Parse(size) == 0) { Console.Write(text); size = Console.ReadLine(); }
        return int.Parse(size);
    }
    
В методе ***GetSize*** используется проверка, чтобы пользователь вводил именно целое число, не символы, не ноль и не пустую строку.

### [GetArray](#getarray)

Мы создаем новый строчный массив

    string[] array = GetArray(size);

Далее пользователь будет самостоятельно вводить каждый элемент массива, используя созданный нами метод ***GetArray***.

    string[] GetArray(int size)
    {
        string[] array = new string[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Введите {i + 1} значение - ");
            array[i] = Console.ReadLine();
        }
    return array;
    }

### [PrintArray](#printarray)

Далее, для наглядности, мы будем выводить на экран наш новый массив, введя метод ***PrintArray***.

    void PrintArray(string[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            if (i == (array.Length - 1)) Console.Write("'{0}'", array[i]);
            else Console.Write("'{0}', ", array[i]);
        }
        Console.Write("]");
    }
Данный метод мы используем просто для более удобного и понятного вывода массива.

### [ModifPrintArray](#modifprintarray)

Ввиду того, что нам не дано четкое пояснение, что нам необходимо создать новый массив, модифицировать имеющийся или просто вывести на экран элементы массива, ограничиваясь условие, что длина строки должны быть меньше либо равна 3, то мы будем просто выводить на экран все элементы, которые удовлетворяют нашему условию.

Для этого мы создаем новый метод ***ModifPrintArray***.

    void ModifPrintArray(string[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                if (i == (array.Length - 1)) Console.Write("'{0}'", array[i]);
                else Console.Write("'{0}', ", array[i]);
            }
        }
        Console.Write("]");
    }

#### [Пример](#пример)

    Какой длины хотите задать массив? -  4
    Введите 1 значение - 2
    Введите 2 значение - 3456346
    Введите 3 значение - впвккрпв
    Введите 4 значение - sfg
    ['2', '3456346', 'впвккрпв', 'sfg'] -> ['2', 'sfg']