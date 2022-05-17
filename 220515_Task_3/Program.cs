// 3. Напишите программу, которая принимает на вход число (N) и 
//    выдаёт таблицу кубов чисел от 1 до N.

// ВОПРОС: Мария! Пытался вместо "double" при объявлении массива и функций с массивами 
// использовать "int" (если я правильно выражаюсь), выдавло ошибку:
// "Не удается неявно преобразовать тип "double" в "int". Существует явное преобразование (возможно, пропущено приведение типов)".
// Почему?

double[] Cubes(int a)
{
    double[] numbers = new double[a];
    int i = 0;
    while (i < a)
    {
        numbers[i] = Math.Pow(i + 1, 3);
        i++;
    }
    return numbers;
}

void PrintCubes(int num)
{
    double[] array = Cubes(num);
    int i = 0;
    while (i < num)
    {
        Console.WriteLine($"{i + 1} ^ 3 = {array[i]}");
        i++;
    }
    Console.WriteLine("---------------------");
}

PrintCubes(10);