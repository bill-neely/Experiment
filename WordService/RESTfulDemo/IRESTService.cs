using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.ServiceModel.Web;


namespace RESTfulDemo
{
    [ServiceContract]
    public interface IRestSerivce
    {
        //POST operation
        [OperationContract]
        [WebInvoke(UriTemplate = "", Method = "POST")]
        Person CreatePerson(Person createPerson);

        //Get Operation
        [OperationContract]
        [WebGet(UriTemplate = "")]
        List<Person> GetAllPerson();
        [OperationContract]
        [WebGet(UriTemplate = "{id}")]
        Person GetAPerson(string id);

        //PUT Operation
        [OperationContract]
        [WebInvoke(UriTemplate = "{id}", Method = "PUT")]
        Person UpdatePerson(string id, Person updatePerson);

        //DELETE Operation
        [OperationContract]
        [WebInvoke(UriTemplate = "{id}", Method = "DELETE")]
        void DeletePerson(string id);
    }

}