using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;



namespace Ejercicio8
{
    class Alumnos
    {
        static void Main(string[] args)
        {
            int LONGITUD_FILA_MATRIZ = 4;
            int LONGITUD_COLUMNA_MATRIZ = 5;
            int[,] Matriz = new int[4, 5];

            for (int f = 0; f < LONGITUD_FILA_MATRIZ; f++){
                for (int c = 0; c < LONGITUD_COLUMNA_MATRIZ; c++){
                    Console.Write($" Por favor ingrese el elemento {f+1}, {c+1} del la matriz: ");
                    Matriz[f,c] = int.Parse(System.Console.ReadLine());
                }
            }

            Console.WriteLine("\nLa matriz es");

            for (int f = 0; f < LONGITUD_FILA_MATRIZ; f++){
                for (int c = 0; c < LONGITUD_COLUMNA_MATRIZ; c++){
                    Console.Write("    [" + Matriz[f, c] + "] ");
                }
                Console.WriteLine();
            }
        }
    }
}