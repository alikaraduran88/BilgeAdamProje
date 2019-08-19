using OkulProjesi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OkulProjesi.Models;

namespace OkulProjesi.Manager
{
    public interface MainPageService
    {
        List<Data.AlinanDersler> GetAlinanDersler(int Student_Number);
        bool SetAlinanDersler(AlinanDersler alinanDersler);
        List<Data.Duyurular> GetDuyurular();
        List<Data.Duyurular> SetDuyurular(Models.Duyurular duyurular);
        List<Data.Lesson> GetLesson();
        List<Data.Lesson> SetLesson();
        List<Data.Student> GetStudent();
        List<Data.Student> SetStudent();
        List<Data.Teacher> GetTeacher();
        List<Data.Teacher> SetTeacher();
        List<Data.Yoklama> GetYoklama();
        List<Data.Yoklama> SetYoklama();
    }
}