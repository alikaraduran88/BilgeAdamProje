using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OkulProjesi.Models
{
    public class models
    {
        public string LessonID { get; set; }
        public string LessonName { get; set; }
        public int Student_Number { get; set; }
        public string Enstitutu_Adi { get; set; }
        public string Icerik { get; set; }
        public string Aciklama { get; set; }
        public int Teacher_SicilNo { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public DateTime Student_Birtdate { get; set; }
        public Int64 Student_TC_NO { get; set; }
        public string TeacherName { get; set; }
        public string TeacherSurname { get; set; }
        public Int64 Teacher_TC_NO { get; set; }
        public DateTime Date { get; set; }
        public string Geldimi { get; set; }
        public int YoklamaID { get; set; }
    }
}