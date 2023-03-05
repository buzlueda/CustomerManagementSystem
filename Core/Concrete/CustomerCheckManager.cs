using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Abstract;
using Core.Entities;

namespace Core.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        bool ICustomerCheckService.CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}