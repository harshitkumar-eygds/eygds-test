using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int addition(int a, int b);

        [OperationContract]
        int subtraction(int a, int b);

        [OperationContract]
        int multiplication(int a, int b);

        [OperationContract]
        int division(int a, int b);

    }

    
    
}
