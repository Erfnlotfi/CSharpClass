using Model.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ServiceModel
{
    class PersonServiceModel
    {
        public List<Person> SelectAll()
        {
            using (var Context = new AppDbConnection())
            {
                try
                {
                    var People = Context.Person.ToList();
                    return People;
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (Context != null)
                        Context.Dispose();
                }
            }

        }
    }
}

