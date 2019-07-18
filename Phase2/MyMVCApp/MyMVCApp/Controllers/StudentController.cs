using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMVCApp.BLL.BLL;
using MyMVCApp.Models.Models;

namespace MyMVCApp.Controllers
{
    public class StudentController : Controller
    {
        StudentManager _studentManager =new StudentManager();
        private Student _student = new Student();
        
        // GET: Student
        [HttpGet]
        public ActionResult  Show()
        {


            List<Student> students = _studentManager.GetAll(_student).ToList();

            return View("Show",students);
        }

        public ActionResult Delete(int id)
        {
            //_student.ID = id;
            //bool falg =   _studentManager.Delete(_student);
            _student.ID = id;
            return View(_studentManager.GetByID(_student));
        }
        
        [HttpPost, ActionName("Delete")]
        public ActionResult ComfoemDelete(int id)
        {
            _student.ID = id;
            bool falg = _studentManager.Delete(_student);
            return RedirectToAction("Insert");
        }
        
        [HttpGet]
        public ActionResult Update(int id)
        {
            _student.ID = id;

            return View(_studentManager.GetByID(_student));
        }
        [HttpPost,ActionName("Update")]
        public ActionResult UpdateDone(Student student)
        {
           bool x = _studentManager.Update(student);

            return View();
        }
        public ActionResult GetByID(int id)
        {
            _student.ID = id;
          Student studentRes =  _studentManager.GetByID(_student);
            return View(studentRes);
        }




        public ActionResult Insert()
        {

            return View();
        }



        [HttpPost]
        public ActionResult Insert(Student student)
        {

            _student.ID = student.ID;
            _student.Name = student.Name;
            _studentManager.Add(_student);
            return RedirectToAction("Insert");
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            _student.ID = id;

            return View(_studentManager.GetByID(_student));
        }
    }
}