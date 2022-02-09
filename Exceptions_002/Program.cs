using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_002
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker[] workers = new Worker[2];
            try
            {
                for (int i = 0; i < workers.Length; i++)
                {
                    workers[i] = new Worker();
                    Console.WriteLine("Enter the name");
                    workers[i].Name = Console.ReadLine();
                    Console.WriteLine("Enter the Job title");
                    workers[i].JobTitle = Console.ReadLine();
                    Console.WriteLine("Enter the year");
                    workers[i].Year = int.Parse(Console.ReadLine());
                    if(workers[i].Year > 2022)
                    {
                        throw new Exception("year must be < or == 2022!!");
                    }
                }
                var res = from w in workers
                          orderby w.Name
                          select w;
                foreach (var item in res)
                {
                    Console.WriteLine($"{item.Name} - {item.JobTitle} - {item.Year}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
