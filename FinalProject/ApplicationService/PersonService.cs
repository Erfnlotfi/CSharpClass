using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.DomainModel;
using Model.ServiceModel;
using ApplicationService.DTOs;
namespace ApplicationService
{
    public class PersonService
    {
     private readonly PersonServiceModel _personServiceModel;
        public PersonService()
        {
            _personServiceModel = new PersonServiceModel();
        }
        public List<Person> GetAll()
        {
            var persons = _personServiceModel.SelectAll();
            var getPersonDto=new List<GetPersonDTO>();
            foreach (var item in persons)
            {
                var gpd = new GetPersonDTO()
                {
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    NationalId = item.NationalId,
                };
                getPersonDto.Add(gpd);
            }
            return persons;
        }

    }
}
