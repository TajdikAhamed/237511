using OnlineShopWebApp.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopWebApp.DAL.Repository
{
    public class CustomerRepository
    {
        private OnlineShopManagementContext db = new OnlineShopManagementContext();
        public List<Customer> GetAll()
        {
            return db.Customers.ToList();
        }

        public Customer GetById(int id)
        {
            Customer category = new Customer();
            category = db.Customers.SingleOrDefault(x => x.ID == id);

            /*
            var x = from c in db.Categories
                where c.Id == id
                select c;
            */
            return category;
        }

        public int Create(Customer category)
        {
            db.Customers.Add(category);
            int executed = db.SaveChanges();
            return executed;
        }

        public int update(Customer category)
        {
            Customer upCategory = this.GetById(category.ID);
            upCategory.Name = category.Name;
            upCategory.Address = category.Address;
            upCategory.Code = category.Code;
            upCategory.Contact = category.Contact;
            upCategory.Email = category.Email;
            upCategory.Point = category.Point;
            upCategory.Image = category.Image;
           
            int executed = db.SaveChanges();
            return executed;
        }

        public int Delete(int id)
        {
            Customer category = new Customer();
            category = db.Customers.SingleOrDefault(x => x.ID == id);
            db.Customers.Remove(category);
            int executed = db.SaveChanges();

            return executed;
        }

    }
}
