using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjDictionary
{
    public class Student
    {

        string strName, strSurname, StrGender, strAge;

        public String ToString()
        {
            return "Name "+ this.StrName + "\nSurname " + this.strSurname;
        }

        public Student(string strName, string strSurname, string strGender, string strAge)
        {
            this.strName = strName;
            this.strSurname = strSurname;
            StrGender = strGender;
            this.strAge = strAge;
        }

        public Student()
        { }

        public string StrName { get => strName; set => strName = value; }
        public string StrSurname { get => strSurname; set => strSurname = value; }
        public string StrGender1 { get => StrGender; set => StrGender = value; }
        public string StrAge { get => strAge; set => strAge = value; }
    }
}
