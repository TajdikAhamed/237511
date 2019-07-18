using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseContext.DataBaseContext;
using MyMVCApp.Models.Models;

namespace MyMVCApp.Repository.Repository
{
    public class StudentRepository
    {
         StudentDBContext db = new StudentDBContext();

        public bool Add(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
            return false;
        }
        public bool Delete(Student student)
        {
            Student findStudent = this.GetByID(student);
            db.Students.Remove(findStudent);
            db.SaveChanges();
            return true;
        }
        public bool Update(Student student)
        {

            Student findStudent = this.GetByID(student);

            findStudent.Name = student.Name;
            db.SaveChanges();
            return false;
        }
        public List<Student> GetAll(Student student)
        {

            return this.db.Students.ToList();
        }
        public Student GetByID(Student student)
        {
            Student studentRes = db.Students.FirstOrDefault(x => x.ID == student.ID);
            
            return studentRes;
        }
    }
}
