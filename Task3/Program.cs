/*
Задача 38: Задайте массив дробных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3,01 7,23 22,79 2,38 78,45] -> 76,07

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
void generate_random_array(int min, int max, double [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble()*(max - min) + min, 2);
    }
}

double get_diff_max_min(double[] array)
{
    double max = array[0];
    double min = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] > max) max  = array[i];
        else if(array[i] < min) min = array[i];
    }

    return max - min;
}


int array_length = get_int_from_console();

double[] array = new double[array_length];

generate_random_array(0, 100, array);

Console.WriteLine($"Сгенерированный массив: {string.Join(", ", array)}");
Console.WriteLine($"Разница между максимальным и минимальным элементами = {get_diff_max_min(array)}");

