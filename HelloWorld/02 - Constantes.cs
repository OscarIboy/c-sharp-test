// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hola Mundo");

var radio = 0d;
var resultado = 0d;

const double Pi = 3.1416;

Console.WriteLine("Bienvenido, calculemos círculos!");

// Pi * radio * radio

Console.WriteLine("Ingrese el valor del radio");
radio = Convert.ToDouble(Console.ReadLine());

resultado = Pi * (radio * radio);
// resultado = Math.PI * (radio * radio);

Console.WriteLine("El área de tu circulo es de: " + resultado);