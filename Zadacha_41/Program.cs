//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

void Vivod (int[] col)
{
   int caunt = col.Length;
    for(int ind = 0;ind < caunt; ind++)
    {
       if(ind != col.Length - 1) Console.Write($"{col[ind]}, ");
       else Console.WriteLine($"{col[ind]} ");
    }
}


Console.Write("Введите число М (колличество чисел, которое хотите ввести) ");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];
int pol = 0;
for (int index = 0; index < array.Length; index++)
{
    array[index] = Convert.ToInt32(new Random().Next(-100,101));
    if (array[index] > 0) pol++;
}
Console.Write("Вы ввели: ");
Vivod (array);
Console.WriteLine($"Колличество введенных цифр больше 0 = {pol}");