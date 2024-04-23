int par = 0, impar=0;
int[] numeros = new int[10];

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Digite o {i + 1} número inteiro");
    numeros[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Valores pares");
for (int i = 0; i < 10; i++)
{
    if (numeros[i] % 2 == 0)
    {
        Console.WriteLine(numeros[i]);
        par++;
    }
}

/*for(int i=0; i < 10; i++)
{
    Console.WriteLine(par + impar);
}*/

{
    Console.WriteLine("Valores impares");
    for (int i = 0; i < 10; i++)
    {
        if (numeros[i] % 2 != 0)
        {
            Console.WriteLine(numeros[i]);
            impar++;
        }
    }

}
    {
        Console.WriteLine("Primeiro"+numeros[0]);
        Console.WriteLine("Ultimo"+numeros[9]);
    }



/*pares
for (int i = 0; i < 10; i+2)
{
    Console.WriteLine(numeros[i]);
}*/
/*impares
for (int i = 1;i < 10; i+2)
{
    Console.WriteLine(numeros[i]);
}*/
