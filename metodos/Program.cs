



//Este código simula un lanzamiento de dados mediante el método Random.Next() para generar un número y 
//el método Console.WriteLine() para mostrar el valor.

//Random dice = new Random();
//int roll = dice.Next(1, 7);
//Console.WriteLine(roll);

/*
METODOS CON ESTADO Y SIN ESTADO 
    Llos métodos con estado se compilan de forma que dependen de los valores almacenados 
    en memoria por líneas anteriores de código que ya se han ejecutado.

    métodos sin estado se implementan para poder funcionar sin hacer referencia a 
    los valores que ya están almacenados en la memoria y sin cambiarlos.
    no se basan en el estado actual de la aplicación para que funcione correctamente.
RESUMEN
    Para llamar a los métodos de una clase de la biblioteca de clases .NET, se usa el formato ClassName.MethodName(), donde el símbolo . es el operador de acceso a miembros para tener acceso a un método definido en la clase, y los símbolos () son los operadores de invocación de método.
Cuando se llama a un método sin estado, no es necesario crear primero una nueva instancia de su clase.
Al llamar a un método con estado, debe crear una instancia de la clase y tener acceso al método en el objeto.
Para crear una nueva instancia de una clase, use el operador new.
Una instancia de una clase se denomina objeto.





int number = 7;
string text = "seven";

Console.WriteLine(number);
Console.WriteLine();
Console.WriteLine(text);
*/

/*METODODS SOBRECARGADOS


Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");
*/

/*Resumen
Los métodos pueden aceptar varios parámetros o ninguno, en función de cómo se hayan diseñado e implementado. Al pasar varios parámetros, se separan con el símbolo ,.
Los métodos pueden devolver un valor cuando completan su tarea, o pueden no devolver nada (métodos nulos o "void").
Los métodos sobrecargados admiten varias implementaciones del método, cada una con una firma de método única (el número de parámetros y el tipo de datos de cada parámetro).
IntelliSense nos ayuda a escribir código más rápidamente. Esto proporciona una referencia rápida a los métodos, sus valores devueltos, sus versiones sobrecargadas y los tipos de sus parámetros.
learn.microsoft.com es la referencia principal cuando se desea obtener información sobre cómo funcionan los métodos de la biblioteca de clases .NET.*/


/*Desafio clase Math
    
En este desafío, usará IntelliSense o learn.microsoft.com para buscar y 
llamar a un método que devuelva el mayor de dos números.


*/

int firstValue = 500;
int secondValue = 600;
int largerValue = System.Math.Max(firstValue,secondValue);

Console.WriteLine(largerValue);

















