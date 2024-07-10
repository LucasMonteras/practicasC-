

/*

La instrucción do-while ejecuta una instrucción o un bloque de instrucciones mientras que una 
expresión booleana especificada se evalúa como true. Como esa expresión se evalúa después 
de cada ejecución del bucle, un bucle do-while se ejecuta una o varias veces.
Generando números aleatorios entre 1 y 10 hasta que se genere el número 7
 */


/* 
Console.WriteLine($"\nGenerando números aleatorios entre 1 y 10 hasta que se genere el número 7\n\n\tNumeros aleatorios");
 */
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



 */

/* Random random = new Random();
int current = random.Next(1, 11);
 */
/*
do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
*/

/* 
Console.WriteLine($"Escritura de una instrucción while que solo itere mientras que un número aleatorio es mayor que un valor");

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"último número: {current}");

 */

/* -------------------------------------------------------------------------------------- */

/* Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);
 */

/* ---------------------------------------------------------------------------------------- */


/* Debes usar la instrucción do-while o la instrucción while como un bucle de juego externo.
El héroe y el monstruo comenzarán con 10 puntos de salud.
Todos los ataques tendrán un valor comprendido entre 1 y 10.
El héroe ataca primero.
Imprima la cantidad de salud que ha perdido el monstruo y su salud restante.
Si la salud del monstruo es mayor que 0, puede atacar al héroe.
Imprima la cantidad de salud que ha perdido el héroe y su salud restante.
Continúe con esta secuencia de ataque hasta que la salud del monstruo o del héroe sea cero o menos.
Imprima el ganador.
 */


/* int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"El monstruo fue dañado y perdió {roll} salud y ahora tiene {monster} salud.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"El héroe fue dañado y perdió {roll} salud y ahora tiene {hero} salud.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "¡El héroe gana!" : "¡El monstruo gana!");
 */

/* ---------------------------------------------------------------------------------- */



/* Administrar la entrada de usuario durante este desafío
Cuando se usa una instrucción Console.ReadLine() para obtener la entrada de usuario, 
es habitual usar una cadena de tipo que acepta valores NULL (designada string?) para la 
variable de entrada y, a continuación, evaluar el valor especificado por el usuario. 
El siguiente ejemplo de código utiliza una cadena de tipo que acepta valores NULL 
para capturar la entrada del usuario. La iteración continúa mientras el valor proporcionado 
por el usuario es NULL:
 */



/* string? readResult;
Console.WriteLine("Enter a string:");
do
{
    readResult = Console.ReadLine();
} while (readResult == null);
 */


/* --------------------------------------------------------------------------------------------- */


/* 

La expresión booleana evaluada por la instrucción while se puede usar 
para asegurarse de que la entrada del usuario cumple un requisito especificado.
Por ejemplo, si un mensaje pide al usuario que escriba una cadena que 
incluya al menos tres caracteres, se podría usar el siguiente código:

 */

/* string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry == false);
 */


/* -------------------------------------------------------------------------------------------------- */



/* 
El código usa una instrucción do porque el bloque de código debe ejecutarse al menos una vez. 
También PUEDE usar while para lograr el mismo resultado. Algunos desarrolladores pueden pensar que
la lógica de while hace que el código sea más legible. Si es así, puede optar por 
implementar una instrucción while aquí.

 */


/* string? readResult;
string valueEntered = "";
int numValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    readResult = Console.ReadLine();
    if (readResult != null) 
    {
        valueEntered = readResult;
    }

    validNumber = int.TryParse(valueEntered, out numValue);

    if (validNumber == true)
    {
        if (numValue <= 5 || numValue >= 10)
        {
            validNumber = false;
            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
        }
    }
    else 
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumber == false);

Console.WriteLine($"Your input value ({numValue}) has been accepted.");

readResult = Console.ReadLine(); */





/* --------------------------------------------------------------------------------------------------------------- */

/* 
El código usa una instrucción do porque el bloque de código debe ejecutarse al menos una vez.
También PUEDE usar while para lograr el mismo resultado. Algunos desarrolladores pueden pensar 
que la lógica de while hace que el código sea más legible. Si es así, puede optar por 
implementar una instrucción while aquí.
 */


string? readResult;
string roleName = "";
bool validEntry = false;

/* do
{                
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readResult = Console.ReadLine();
    if (readResult != null) 
    {
        roleName = readResult.Trim();
    }

    if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user") 
    {
        validEntry = true;
    }
    else
    {
        Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
    }

} while (validEntry == false);

Console.WriteLine($"Your input value ({roleName}) has been accepted.");
readResult = Console.ReadLine(); */



/* 
El código usa una instrucción for para el bucle externo porque no se puede modificar el valor 
asignado a una variable de iteración "foreach". Para solucionarlo declare una variable de 
cadena adicional en el bucle foreach, pero si lo hace, agregará una complejidad no deseada a la 
lógica del código. En otras palabras, si se usa la instrucción de iteración foreach
(string myString in myStrings) y, luego, se intenta procesar la variable myString, 
se genera un error de compilación.

El código usa una instrucción while para el bucle interno porque, dependiendo del valor 
de la cadena de datos, es posible que el bloque de código no se ejecute 
(si la cadena no contiene un punto). No debe usar una instrucción do en situaciones en las 
que es posible que no sea necesario ejecutar el bloque de iteración.
 */


/* string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }

    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
} */

















