using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OkulProjesi.Data;
using OkulProjesi.Models;
namespace OkulProjesi.Manager
{
    public class MainPageManager : MainPageService
    {
        PROJEEntities1 db = new PROJEEntities1();
        public List<AlinanDersler> GetAlinanDersler(int Student_Number)
        {
            var query = db.AlinanDerslers.Where(q => q.Student_Number == Student_Number).ToList();
            return query;
        }

        public List<Data.Duyurular> GetDuyurular()
        {
            throw new NotImplementedException();
        }

        public List<Lesson> GetLesson()
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudent()
        {
            throw new NotImplementedException();
        }

        public List<Teacher> GetTeacher()
        {
            throw new NotImplementedException();
        }

        public List<Yoklama> GetYoklama()
        {
            throw new NotImplementedException();
        }

        public bool SetAlinanDersler(AlinanDersler alinanDersler)
        {
            try
            {
                db.AlinanDerslers.Add(alinanDersler);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

       

        public List<Data.Duyurular> SetDuyurular(Models.Duyurular duyurular)
        {
            throw new NotImplementedException();
        }

        public List<Lesson> SetLesson()
        {
            throw new NotImplementedException();
        }

        public List<Student> SetStudent()
        {
            throw new NotImplementedException();
        }

        public List<Teacher> SetTeacher()
        {
            throw new NotImplementedException();
        }

        public List<Yoklama> SetYoklama()
        {
            throw new NotImplementedException();
        }

        
    }
}