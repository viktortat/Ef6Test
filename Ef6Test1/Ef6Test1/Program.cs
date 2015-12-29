using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef6Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (EFDbFirstEntities db = new EFDbFirstEntities())
            {
                var list = db.Agents.ToList();
                foreach (Agent ag in list)
                {
                    Console.WriteLine("{0} - {1} - {2} - {3} - {4}",ag.Id,ag.FirstName,ag.LastName,ag.Age,ag.Descr);
                }
                Console.ReadLine();
            }
        }
    }
}
