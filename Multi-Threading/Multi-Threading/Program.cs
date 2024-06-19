using System;
using System.Threading;
using System.IO; //wenn ich wollte im windos file suchen ich muss im meine C# ( using System.IO ) schreiben..
namespace Multi_Threading
{
    internal class Program
    {
        // wichtige woerter ... Threads, Tasks, Semaphores, Mutex
        static public void schreibgrossbuchtaben()
        {
            int i;
            for(i = 0; i < 10; i++) 
            {

                Console.WriteLine("A");
                Thread.Sleep(250);

            }

        }

        static public void schreibkleinbuchtaben()
        {

            int i;
            for (i = 0; i < 10; i++)
            {
                
                Console.WriteLine("a");
                Thread.Sleep(250);

            }
        }
        static void Main(string[] args)
        {
            // Error handling, Exception Handling
            // try, catch  throw

            string filePath = @"C:\Users\FP2402386\Downloads\elahe\elahe.txt"; // das ist typisch C# ...
            //wird keine probleme verursachen...
            //

            File.ReadAllText(filePath);

            try
            {
                //Attempt to read the content of the file
                string content = File.ReadAllText(filePath);
                // kann zu probleme verursachen...
                Console.WriteLine("File content :");
                Console.WriteLine(content);


            }
            catch (Exception ex)
            {
                Console.WriteLine("Oida da geht was nid" + ex.Message);


            }




            //wie kann ich in deir datei suchen..
            //nach einem wort sucht und ausgabe( ausgabe in einer eigenen datei)

            //Wie kann man das mit dem pfad anders loesen!?



            //schreibgrossbuchtaben();
            //schreibkleinbuchtaben();

            Thread prozess1 = new Thread(new ThreadStart(schreibkleinbuchtaben));
            Thread prozess2 = new Thread(new ThreadStart(schreibgrossbuchtaben));

            prozess1.Start();
            prozess2.Start();

            prozess1.Join(); //wartet bis beendigung

            prozess2.Abort();

            // join.. abort.. 

            // klasse thread .. methoden! bitte nichts mit Task, Mutex, Semaphone


        }
    }
}
