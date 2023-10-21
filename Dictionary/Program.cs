namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary <string, int> studentList = new Dictionary<string, int> ();
            studentList.Add("Stefan", 1);
            studentList.Add("Stephan", 2);
            studentList.Add("Luke", 3);
            studentList.Add("Ethan", 4);

            Console.WriteLine("Count: {0}", studentList.Count);

            //finds key
            if (studentList.ContainsKey("Derik"))
            {
                Console.WriteLine("Student found");
            }
            else
            {
                Console.WriteLine("Student not found and created");
                studentList["Derik"] = 1;
            }

            //finds value
            if (studentList.ContainsValue(5))
            {
                Console.WriteLine("item found");
            }
            else
            {
                Console.WriteLine("item not found");
            }

            //print all items
            Console.WriteLine("All Students:");
            foreach (KeyValuePair<string, int> student in studentList)
            {
                Console.WriteLine("Key: {0}, Value: {1}", student.Key, student.Value);
            }

            Console.ReadLine();
        }
    }
}