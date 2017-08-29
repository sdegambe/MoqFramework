using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqFramework
{
    public class ManagePersons : IManagePersons
    {
        private IPerson person { get; set; }
        public IPerson AddPerson(IPerson person)
        {
            var addedPerson = person;
            if (addedPerson.VerifyAge() && addedPerson.PersonAddress.Verify(person.PersonAddress))
            {
                return addedPerson;
            }
            else
            {
                throw new Exception("Validate failed");
            }
        }
        public bool VerifyAge()
        {
            return person.Age > 18;
        }
    }
}
