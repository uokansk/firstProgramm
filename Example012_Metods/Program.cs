// Методы
// 1 Вид ничего не принимают и ничего не возвращают
// имеют тело

void Metod1()
{
    Console.WriteLine("Автор...");
}

// вызов метода
// Metod1();

// Вид 2 принимает аргументы, но ничего не возвращает
void Metod2(string msg)
{
    Console.WriteLine(msg);
}

// вызов метода
// Metod2("Текст сообщения");

//пример метода 2
void Metod21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++; // это инкремент
    }
}

// вызов метода
// Metod21("Текст", 4); // указать явно Metod21(msg: "Текст", count: 4);

// метод 3 что-то возвращает, но ничего не принимает
int Metod3()
{
    return DateTime.Now.Year; // возвращает данные
}

int year = Metod3();

// Console.WriteLine(year);


// метод 4 что-то возвращает и что-то принимает

// string Metod4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;  // string result = "";

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Metod4(4, "Привет, ");
// Console.WriteLine(res);


// для цикла for метод 4
string Metod4(int count, string text)
{
    string result = String.Empty; // string result = "";

    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Metod4(5, "Привет, ");

// Console.WriteLine(res);

// таблица умножения
// for (int i = 2; i < 10; i++)
// {
//     for (int j = 2; j < 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");  //интерполяция строк
//     }
//     Console.WriteLine();
// }


// Дан текст. В нём нужно все пробелы заменить чёрточками, маленькие буквы «к»
// заменить большими «К», а большие «С» заменить на маленькие «с».

string text =
    "— Я думаю, — сказал князь, улыбаясь, — что,"
    + "ежели бы вас послали вместо нашего милого Винценгероде,"
    + "вы бы взяли приступом согласие прусского короля."
    + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012
// s[3]
string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue)
            result = result + $"{newValue}";
        else
            result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replase(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
string newText2 = Replase(newText, 'к', 'К');
Console.WriteLine(newText2);
Console.WriteLine();
string newText3 = Replase(newText2, 'с', 'С');
Console.WriteLine(newText3);
