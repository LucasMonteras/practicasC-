
/*


Este código invierte un mensaje, cuenta el número de veces 
Aparece un carácter en particular y luego imprime los resultados.
a la ventana de la consola..

*/


string mensaje = "El veloz zorro marrón salta sobre el perro perezoso.";

char[] charMessage = mensaje.ToCharArray();
Array.Reverse(charMessage);

int letterCount = 0;

foreach (char i in charMessage) 
{ if (i == 'o') 
    { 
        letterCount++; 
    } 
}

string new_message = new String(charMessage);

Console.WriteLine(new_message);
Console.WriteLine($"'o' aparece {letterCount} veces.");











