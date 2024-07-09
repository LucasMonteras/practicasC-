

/*
Generando números aleatorios entre 1 y 10 hasta que se genere el número 7
 */


Console.WriteLine($"\nGenerando números aleatorios entre 1 y 10 hasta que se genere el número 7\n\n\tNumeros aleatorios");

/* Random random = new Random();
int current = 0;
 */
/* do
{
    current = random.Next(1, 11);
    Console.WriteLine($"\t  {current}");
} while (current != 7);
 */


/* 

Escritura de una instrucción while que solo itere mientras que un número aleatorio es mayor que un valor

 */

Random random = new Random();
int current = random.Next(1, 11);

/*
do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
*/




while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"último número: {current}");





