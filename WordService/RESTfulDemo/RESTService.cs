using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.ServiceModel.Activation;

namespace RESTfulDemo
{
    [AspNetCompatibilityRequirements
    (RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]

    public class RestSerivce : IRestSerivce
    {
        List<Person> persons = new List<Person>();
        int personCount = 0;

        public Person CreatePerson(Person createPerson)
        {
            createPerson.ID = (++personCount).ToString();
            persons.Add(createPerson);
            return createPerson;
        }

        public List<Person> GetAllPerson()
        {
            return persons.ToList();
        }

        public Person GetAPerson(string id)
        {
            return persons.FirstOrDefault(e => e.ID.Equals(id));
        }

        public Person UpdatePerson(string id, Person updatePerson)
        {
            Person p = persons.FirstOrDefault(e => e.ID.Equals(id));
            p.Name = updatePerson.Name;
            p.Age = updatePerson.Age;
            return p;
        }

        public void DeletePerson(string id)
        {
            persons.RemoveAll(e => e.ID.Equals(id));
        }
    }
}