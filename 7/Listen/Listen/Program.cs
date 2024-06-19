using System;
using System.Collections.Generic;

namespace Listen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> deineAufgabeListen = new List<string>();
            string aufgabe;
            int i;

            do
            {

                Console.WriteLine("Was ist deine Plan für heute? ");
                Console.WriteLine("wenn hast du keine Aufgaben bitt drükst du x ");
                aufgabe = Console.ReadLine();//Eingabe
                deineAufgabeListen.Add(aufgabe);


            } while (aufgabe != "x" );

                deineAufgabeListen.RemoveAt(deineAufgabeListen.Count - 1);

            foreach (string a in deineAufgabeListen) {

                for (i = 0; i < a ; i++) {

                    Convert.ToInt32(Console.WriteLine("{0}",aufgabe));
                


                }
                
                

                
            }
        }
    }
}
