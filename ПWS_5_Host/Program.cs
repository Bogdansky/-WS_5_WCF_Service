using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ПWS_5_Host
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(ПWS_5_WCF_Service.Service1));
            host.Open();
            Console.WriteLine("Хост запущен. Чтобы остановить, нажмите любую клавишу...");
            Console.Read();
            host.Close();
        }
    }
}
