/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2

*/
int get_int_from_console()
{
    int console_int = 0;

    Console.Write("Введите количество элементов в массиве: ");

    while(true)
    {
        if( int.TryParse(Console.ReadLine(), out console_int ) )
        {
            break;
        }
        else
        {
            Console.Write("Введено некорректное число, повторите попытку ввода:");
        }
    }
    return console_int;

}
void generate_random_array(int min, int max, int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
}

int get_count_even_numbers(int[] array)
{
    int count = 0;

    foreach(int a in array)
    {
        if( a % 2 == 0) count++;
    }

    return count;
}


int array_length = get_int_from_console();

int[] array = new int[array_length];

generate_random_array(100, 999, array);

Console.WriteLine($"Сгенерированный массив: {string.Join(", ", array)}");
Console.WriteLine($"Количество четных элементов в массиве = {get_count_even_numbers(array)}");
