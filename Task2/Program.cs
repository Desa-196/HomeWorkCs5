/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

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

int get_sum_element(int[] array)
{
    int sum = 0;

    for(int i = 1; i < array.Length; i+=2)
    {
        sum += array[i];
    }

    return sum;
}


int array_length = get_int_from_console();

int[] array = new int[array_length];

generate_random_array(0, 100, array);

Console.WriteLine($"Сгенерированный массив: {string.Join(", ", array)}");
Console.WriteLine($"Сумма элементов на нечетных позициях = {get_sum_element(array)}");

