using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ПWS_5_WCF_Service
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService1" в коде и файле конфигурации.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(int value);

        // TODO: Добавьте здесь операции служб
        [OperationContract]
        int Add(int x, int y);
        [OperationContract]
        string Concat(string first, double second);
        [OperationContract]
        A Sum(A first, A second);
    }

    // Используйте контракт данных, как показано на следующем примере, чтобы добавить сложные типы к сервисным операциям.
    // В проект можно добавлять XSD-файлы. После построения проекта вы можете напрямую использовать в нем определенные типы данных с пространством имен "ПWS_5_WCF_Service.ContractType".
    [DataContract]
    public class A
    {
        string s;
        int k;
        float f;

        [DataMember]
        public string S
        {
            get { return s; }
            set { s = value; }
        }

        [DataMember]
        public int K
        {
            get { return k; }
            set { k = value; }
        }

        [DataMember]
        public float F
        {
            get { return f; }
            set { f = value; }
        }
    }
}
