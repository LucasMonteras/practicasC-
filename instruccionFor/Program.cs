/* 
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("\n-------------------------------------\n");
// Contar hacia atras

for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
} */

/* for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
} */


//¿Cómo se puede salir prematuramente de la instrucción de iteración 
//    en función de una condición? Podemos usar la palabra clave break.


/* for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}


//Recorrido en bucle de todos los elementos de una matriz

Console.WriteLine("\n ----iteración la matriz hacia atrás----\n");
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    
    Console.WriteLine(names[i]);
}


Console.WriteLine("\n ----Iteracion de la matriz hacia adelante-----\n");
// Iteracion hacia adelante

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
} */


/* 
¿Cómo se actualiza un valor en la matriz durante una iteración con la instrucción foreach?
 */


/* string[] names = { "Alex", "Eddie", "David", "Michael" };
foreach (var name in names)
{
    // No puedo hacer esto:
    if (name == "David") name = "Sammy";

} */



//Superación de la limitación de la instrucción foreach mediante la instrucción for



/* 
string[] names = { "Alex", "Eddie", "David", "Michael" };

for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "David")
    {
        names[i] = "Sammy";
    }
}

foreach (var name in names)
{
    Console.WriteLine(name);
} */



for (int i = 1; i < 101; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
        Console.WriteLine($"{i} - FizzBuzz");
    else if (i % 3 == 0)
        Console.WriteLine($"{i} - Fizz");
    else if (i % 5 == 0)
        Console.WriteLine($"{i} - Buzz");
    else
        Console.WriteLine($"{i}");
}















