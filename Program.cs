// See https://aka.ms/new-console-template for more information
Console.WriteLine("¡Hola! a continuación le voy a pedir que me escriba dos números, seguidamente los voy sumar, restar, multiplicar y dividir y le entregaré los resultados. ");
Console.WriteLine("¿Cuál es el primer número que has elegido?");
var primerNumero = Console.ReadLine();
 int numero1 = int.Parse(primerNumero); 
Console.WriteLine("¿Cuál es el segundo número que has elegido?");
var segundoNumero = Console.ReadLine();
int numero2 = int.Parse(segundoNumero); 
var suma = numero1 + numero2;
var resta= numero1 - numero2;
var dividir= numero1 / numero2;
var multiplicar= numero1 * numero2;
Console.WriteLine("El resultado de sumar " + primerNumero + " y " + segundoNumero + " es: " + suma);
Console.WriteLine("El resultado de restar " + primerNumero + " y " + segundoNumero + " es: " + resta);
Console.WriteLine("El resultado de dividir " + primerNumero + " y " + segundoNumero + " es: " + dividir);
Console.WriteLine("El resultado de multiplicar " + primerNumero + " y " + segundoNumero + " es: " + multiplicar);