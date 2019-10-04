using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПWS_5_Client
{
    class B : ServiceReference1.A
    {    }

    class Program
    {
        static string AToString(ServiceReference1.A a)
        {
            return $"F: {a.F}, K: {a.K}, S: {a.S}";
        }
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client httpClient = new ServiceReference1.Service1Client("BasicHttpBinding_IService1");
            ServiceReference1.Service1Client tcpClient = new ServiceReference1.Service1Client("NetTcpBinding_IService1");
            httpClient.Open();
            tcpClient.Open();

            int x = 10, y = 5;
            ServiceReference1.A first = new ServiceReference1.A
            {
                F = 1.323F,
                K = 3,
                S = "Hello "
            };
            ServiceReference1.A second = new ServiceReference1.A
            {
                F = 3.677F,
                K = 2,
                S = "world"
            };

            Console.WriteLine($"Сумма {x} и {y} равна {httpClient.Add(x, y)}");
            Console.WriteLine($"Конкатенация {first.S} и {(double)second.F}: {httpClient.Concat(first.S, second.F)}");
            Console.WriteLine($"Результат операции Sum объекта first - {AToString(first)} - и объекта second - {AToString(second)}: \n{AToString(tcpClient.Sum(first, second))}");

            httpClient.Close();
            tcpClient.Close();
            Console.ReadLine();
        }
    }
}
