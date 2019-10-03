using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ПWS_5_WCF_Service
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class Service1 : IService1
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public string Concat(string first, double second)
        {
            return string.Concat(first, second);
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public A Sum(A first, A second)
        {
            return new A
            {
                S = string.Concat(first.S, second.S),
                K = first.K + second.K,
                F = first.F + second.F
            };
        }
    }
}
