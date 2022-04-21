using System;

namespace Ejercicio5
{
   
   public static void main(String[] args) {
        int[][] num = new int[3][3];
        Console.WriteLine("Ingrese los números.");
        for (int i = 0; i < num.length; i++) {
            for (int j = 0; j < num.length; j++) {
                  num[i][j]=numero.nextInt();              
            }            
        }
        Console.WriteLine("Imprimiendo Tabla.");
        for (int i = 0; i < num.length; i++) {
            Console.WriteLine();
            for (int j = 0; j < num.length; j++) {
                  Console.WriteLine(num[i][j] + " ");              
            }            
        }
        
        Console.WriteLine("\nSuma Fila.");
        int suma=0;
        for (int i = 0; i < num.length; i++) {
            for (int j = 0; j < num.length; j++) {
                  suma += num[i][j];              
            }
            Console.WriteLine("Fila " + i + " =" + suma);
            suma=0;
        }
        Console.WriteLine("\nSuma Columna");
        for (int i = 0; i < num.length; i++) {
            for (int j = 0; j < num.length; j++) {
                  suma += num[j][i];              
            }
            Console.WriteLine("Columna " + i + " =" + suma);
            suma=0;
        }
        
    }
}