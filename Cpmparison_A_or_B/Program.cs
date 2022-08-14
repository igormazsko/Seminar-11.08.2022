// Сравнение двух чисел
using static System.Console;
Clear();
WriteLine("Введите число A: ");
int a = Convert.ToInt32(ReadLine());
WriteLine("Введите число B: ");
int b = Convert.ToInt32(ReadLine());
string answer = a>b ? "A>B" : a<b ?  "A<B" : "A=B";
// WriteLine(answer);
WriteLine(a>b ? "A>B" : a<b ?  "A<B" : "A=B");
