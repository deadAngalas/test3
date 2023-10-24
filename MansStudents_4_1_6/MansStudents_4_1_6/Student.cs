using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MansStudents_4_1_6
{
    public class Student
    {
        // lauki
        private string Name;
        private string Nr;
        private string Fac;
        private int Year;
        private double Av;

        //konstruktors
        public Student(string aName, string aNr, string aFac, int aYear, double aAv)
        {
            Name = aName;
            Nr = aNr;
            Fac = aFac;
            Year = aYear;
            Av = aAv;
        }

        // metodes
        public override string ToString()
        {
            return "\nName: " + Name + "\nSt.apl.nr.: " + Nr + "\nFacultate: " + Fac +
                "\nCourse: " + Year + "\nAv. Grade: " + Av;
        }
        public void Sesija(params int[] a)
        {
            double s = 0;
            for(int k = 0; k < a.Length; k++)
            {
                s += a[k];
            }
            Av = s * 1.0 / a.Length;
        }
        public static Student operator ++(Student a)
        {
            a.Year++;
            return a;
        }
    }

    /*
    Operācija ++ „pārcel” studentu nākamajā kursā (bez pārbaudēm). 
    */
}
