﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hola Mundo");

// Programa que calcula el área de un rectángulo.

double ladoA;
double ladoB;
double resultado;

Console.WriteLine("Calcula el área de un rectángulo!");

Console.WriteLine("Ingrese el valor del lado A");
ladoA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el valor del lado B");
ladoB = Convert.ToDouble(Console.ReadLine());

resultado = ladoA * ladoB;

Console.WriteLine("El área del rectángulo es " + resultado);