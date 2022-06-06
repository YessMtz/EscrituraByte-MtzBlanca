using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EscrituraByte
{
    class Program
    {
        //MARTINEZ NAVA BLANCA YESSENIA
        //21211990
        static void Main(string[] args)
        {
            FileStream fs = null;
            byte[] buffer = new byte[81];
            int nbytes = 0, car;

            try
            {
                //crear el flujo del archivo
                fs = new FileStream("EscrituraByte.txt", FileMode.Append, FileAccess.Write);
                Console.WriteLine("Escriba el texxto que desea almacenar en el archivo");
                while ((car = Console.Read()) !='\r'&& (nbytes <buffer.Length));
                {
                    //constante que se va incrementando en cada iteracion
                    buffer[nbytes] = (byte)car;
                    nbytes++;
                }
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }
        }
    }
}
