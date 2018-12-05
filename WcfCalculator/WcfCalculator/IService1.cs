using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using WcfCalculator.Model;
namespace WcfCalculator
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

       [OperationContract]
        int Addition(int a, int b);

        [OperationContract]
       int Multiplication(int a, int b);

        [OperationContract]
        DataSet GetEmpByid(int i);

        [OperationContract]
        int InsertEmpData(Student std);

        [OperationContract]
        int UpdateEmpData(Student std);

        // TODO: Add your service operations here
    }


   
}
