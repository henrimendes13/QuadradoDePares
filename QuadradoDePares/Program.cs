/*Leia um valor inteiro N. Apresente o quadrado de cada um dos valores pares, 
de 1 até N, inclusive N, se for o caso.*/

int n;
n = int.Parse(Console.ReadLine());

for (int i=2; i <=n; i=i+2)
{
    Console.WriteLine($"{i}^2 = {Math.Pow(i, 2)}");

}