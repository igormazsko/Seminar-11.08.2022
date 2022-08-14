// See https://aka.ms/new-console-template for more information
using static System.Console;
Clear();
WriteLine("Введите число: ");
int n = Convert.ToInt32(ReadLine());
string answer = n % 2 == 0 ? "Yes" : "No";
// WriteLine(n % 2 == 0 ? "Yes" : "No");