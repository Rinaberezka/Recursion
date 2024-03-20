// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. Использовать рекурсию,
// не использовать циклы.


Console.WriteLine("Введите размер  массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] s = new int[n];
for (int i = 0; i < s.Length; i++)
{
    s[i] = Convert.ToInt32(Console.ReadLine());
   
}
Console.WriteLine(string.Join(" ", s));


void ReversArr(int[] s, int n)
{
     
        Console.WriteLine(s[n]);

    if (n != 0) {
        ReversArr(s, n-1);
         
    }

    return;
} 

int[] num = s;

ReversArr(num, num.Length-1);