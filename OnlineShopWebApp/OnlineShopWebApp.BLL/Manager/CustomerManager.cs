using OnlineShopWebApp.DAL.Repository;
using OnlineShopWebApp.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopWebApp.BLL.Manager
{
    public class CustomerManager
    {

        private CustomerRepository db = new CustomerRepository();
        public List<Customer> GetAll()
        {
            return db.GetAll();
        }

        public Customer GetById(int id)
        {
            return db.GetById(id);
        }

        public int Create(Customer category)
        {
            return db.Create(category);
        }

        public int update(Customer category)
        {
            return db.update(category);
        }

        public int Delete(int id)
        {
            return db.Delete(id);
        }

    }
}
