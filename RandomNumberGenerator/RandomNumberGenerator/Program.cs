using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGenerator
{
    class Program
    {
        static StreamWriter Yaz = null;
        static void Main(string[] args)
        {            
            try
            {
                Yaz = new StreamWriter(@"C:\Users\ensar\Desktop\RandomNumberGenerator\Data8.txt");
                for (int i = 0; i < 1000000; i++)
                {
                   Yaz.Write(RandomNumberGenerator.Instance.Generate(0, 1) + "\r\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
            }
            finally
            {
                Yaz.Flush();
                Yaz.Close();
            }                                 
        }
    }
}
