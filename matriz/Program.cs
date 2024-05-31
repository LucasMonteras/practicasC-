

/*string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
//fraudulentOrderIDs[3] = "D000";
*/

string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

//Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
//Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
//Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");


fraudulentOrderIDs[0] = "F000";

//Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

//Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");


/*

La instrucción foreach ofrece una manera sencilla y limpia de iterar los elementos de una matriz.
La instrucción foreach procesa los elementos de matriz en orden creciente de índice, 
comenzando con el índice 0 y terminando con el índice Length - 1. 
Usa una variable temporal para contener el valor del elemento de matriz asociado a la iteración actual.
Cada iteración ejecutará el bloque de código que se encuentra debajo de la declaración foreach.

*/


string[] names = { "Rowena", "Robin", "Bao" };
foreach (string name in names)
{
    //Console.WriteLine(name);
}


//Use la instrucción foreach para crear una suma de todos los elementos disponibles en cada contenedor del almacén.

int[] inventory = { 200, 450, 700, 175, 250 };
int sumaValoresElementos = 0;
int elementos = 0;
foreach (int item in inventory)
{
    sumaValoresElementos += item;
    elementos++;
    //Console.WriteLine($"Elemento => : {elementos} = {item} ➕  {sumaValoresElementos}");

}

//Console.WriteLine($"El total de del valor de los elmentos es : {sumaValoresElementos}");




/*

El equipo ha encontrado un patrón. Los pedidos que comienzan por la letra "B" presentan un fraude con 
una frecuencia 25 veces superior a la normal. Deberá escribir otro código que genere el identificador 
de pedido para los nuevos pedidos que empiecen por la letra "B". El equipo antifraude lo usará para 
investigar más en profundidad.

*/

string[] pedidosFraudalentos = {"B123","C234","A345","C15","B177","G3003","C235","B179"};

foreach (string pedido in pedidosFraudalentos)
{
    if (pedido.StartsWith("B"))
    {
        Console.WriteLine("El pedido " + pedido + " es un pedido fraudulento");
    }
}






