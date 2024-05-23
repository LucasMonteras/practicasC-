using System;

class Program {
    static void Main (){
/*Recibe una breve lista de cuatro alumnos y cinco calificaciones de cada uno.
Cada calificación se expresa como un valor entero, de 0 a 100, donde 100 representa que está perfecto.
Las notas finales son el promedio de las notas de las cinco tareas.
La aplicación debe realizar operaciones matemáticas básicas para calcular las calificaciones finales de cada alumno.
La aplicación debe generar o mostrar el nombre de cada alumno y la nota final.
Sophia: 93, 87, 98, 95, 100

Nicolas: 80, 83, 82, 88, 85

Zahirah:   84, 96, 73, 85, 79

Jeong:  90, 92, 98, 100, 97
 Asi quiere el prefesor que se muestren las notas
Student     Grade
Sophia      94.6  A
Nicolas     83.6  B
Zahirah     83.4  B
Jeong       95.4  A

*/
// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;


int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

// Para que el resultado de una division sea un valor decimal el dividendo,el divisor, o ambos deben ser de tipo decimal
//Esta tecnica convierte un entero en un decimal colocando (decimal) o convirtiendo la variable suma o currentAssiggments
decimal sophiaScore = (decimal) sophiaSum / currentAssignments;
decimal nicolasScore = (decimal) nicolasSum / currentAssignments;
decimal zahirahScore = (decimal) zahirahSum / currentAssignments;
decimal jeongScore = (decimal) jeongSum / currentAssignments;


Console.WriteLine("Student\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA");
Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
Console.WriteLine("Zahirah:\t" + zahirahScore + "\tB");
Console.WriteLine("Jeong:\t\t" + jeongScore + "\tA");


/*Estamos desarrollando una calculadora de nota media global de los alumnos que ayudará a calcular el promedio global de las calificaciones de los alumnos. Los parámetros de la aplicación son:

Se nos proporciona el nombre y la información de la clase del alumno.
Cada clase tiene un nombre, la calificación del alumno y el número de horas en créditos de esa clase.
La aplicación debe realizar operaciones matemáticas básicas para calcular la nota media global del alumno determinado.
La aplicación debe generar o mostrar el nombre del alumno, la información de la clase y la nota media global.

Para calcular la nota media global:

Multiplique la nota de un curso por el número de horas en créditos de ese curso.
Hágalo para cada curso y reúna los resultados.
Divida la suma resultante por el número total de horas en créditos.
*/


string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;


int gradeA = 4;
int gradeB = 3;



int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

int totalCreditHours = 0;

totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;


int totalGradePoints = 0;

totalGradePoints += course1Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;


decimal gradePointAverage = (decimal) totalGradePoints/totalCreditHours;

int leadingDigit = (int) gradePointAverage;
int firstDigit = (int) (gradePointAverage * 10) % 10;//inicializar una variable que almacene los dos primeros dígitos después del decimal
int secondDigit = (int) (gradePointAverage * 100 ) % 10;


Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");
Console.WriteLine($"Student: {studentName}\n");


Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t{course5Credit}");

Console.WriteLine($"\nFinal GPA:\t\t\t {leadingDigit}.{firstDigit}{secondDigit}");






    }
}














