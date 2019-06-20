using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWinApp.Repository;

namespace MyWinApp.BLL
{
    public class StudentManager
    {
        private StudentRepository _studentRepository = new StudentRepository();
        public DataTable LoadDistrict()
        {
            return _studentRepository.LoadDistrict();
        }
    }
}
