using System.Collections.Generic;

namespace prjDictionary
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Dictionary<int, Student> dic = new Dictionary<int, Student>();
            dic.Add(1, new Student("Koko", "Nojoko", "Male", "20"));
            dic.Add(2, new Student("Nicole", "Kelsey", "Female", "21"));
            dic.Add(3, new Student("Luke", "Dirsuwei", "Other", "22"));

            print(dic);
            dic.Add(5555, new Student("Chad", "Andrews", "ummm", "23"));
            print(dic);
            int iPos = FindLocation(dic, "Chad");
            if (iPos >= -1)
            {
                dic.Remove(iPos);
                Console.WriteLine("student removed");
            }
            else
            {
                Console.WriteLine("student not found");
            }
            Console.ReadLine();    
        }

        private static int FindLocation(Dictionary<int, Student> dic, string name)
        {
            int iPos = -1;
            foreach (var i in dic)
            {
                if(i.Value.StrName.Equals(name))
                {
                    iPos = i.Key;
                    return iPos;
                }
            }

            return -1;
        }

        private static void print(Dictionary<int, Student> dic)
        {
            foreach (var i in dic)
            {
                Console.Write(i.Value.ToString() + " ");
                Console.WriteLine(i.Key);
            }
        }
    }
}