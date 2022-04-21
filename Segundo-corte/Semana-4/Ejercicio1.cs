using System;
using System.Collections;
using System.Collections.Generic;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack pilaP = new Stack();
            Stack pilaP2 = new Stack();
            pilaP.Push(8);
            pilaP.Push(10);
            pilaP.Push(37);
            pilaP.Push(54);
            pilaP.Push(7);

            while (pilaP.Count>0){
                pilaP2.Push(pilaP.Pop);
            }

        }
    }
}