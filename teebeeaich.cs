using System;
using System.Linq;
using System.IO;

namespace teebeeaich
{
    class Program
    {
        static void Main(string[] args)
        {
            string startString = File.ReadAllText(args[0]);
            string endString = "";
            for(int x = 0; x < startString.Length; x++)
            {
                switch (startString.ElementAt<char>(x))
                {
                    case ' ':
                        endString += "  ";
                        break;
                    case '-':
                        endString += "dash ";
                        break;
                    case 'a':
                        endString += "ay ";
                        break;
                    case 'b':
                        endString += "bee ";
                        break;
                    case 'c':
                        endString += "cee ";
                        break;
                    case 'd':
                        endString += "dee ";
                        break;
                    case 'e':
                        endString += "ee ";
                        break;
                    case 'f':
                        endString += "eff ";
                        break;
                    case 'g':
                        endString += "gee ";
                        break;
                    case 'h':
                        endString += "aich ";
                        break;
                    case 'i':
                        endString += "eye ";
                        break;
                    case 'j':
                        endString += "jay ";
                        break;
                    case 'k':
                        endString += "kay ";
                        break;
                    case 'l':
                        endString += "ell ";
                        break;
                    case 'm':
                        endString += "emm ";
                        break;
                    case 'n':
                        endString += "enn ";
                        break;
                    case 'o':
                        endString += "oh ";
                        break;
                    case 'p':
                        endString += "pee ";
                        break;
                    case 'q':
                        endString += "cue ";
                        break;
                    case 'r':
                        endString += "are ";
                        break;
                    case 's':
                        endString += "ess ";
                        break;
                    case 't':
                        endString += "tee ";
                        break;
                    case 'u':
                        endString += "you ";
                        break;
                    case 'v':
                        endString += "vee ";
                        break;
                    case 'w':
                        endString += "double-you ";
                        break;
                    case 'x':
                        endString += "ecks ";
                        break;
                    case 'y':
                        endString += "why ";
                        break;
                    case 'z':
                        endString += "zee ";
                        break;
                }
            }
            File.WriteAllText(args[0], endString);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Success!");
            Console.WriteLine("New file is " + endString.Length + " characters long");
            Console.ReadKey();
        }
    }
}
