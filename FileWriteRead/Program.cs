using FileWriteRead;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FileWriteRead
{
    public class Program
    {
        public static string FilePath = 
            "C:\\Users\\FORMATION\\Desktop\\Formation .NET DM\\FirstProject\\FileWriteRead\\";
        public static string FileName = "FileManagement1.csv";
        public static List<Person> Persons = new List<Person>();
        public static List<Person> Students = new List<Person>();

        public static void Main()
        {
            InitializeData();
            WriteFile(FilePath, FileName, Persons);
            //Console.ReadLine();
            //ReadFile(FilePath, FileName);
            //ListData(Students);
        }

        private static void ReadFile(string FilePath, string FileName)
        {
            Console.WriteLine("Lecture du fichier");

            StreamReader? MyStream = new StreamReader(FilePath+FileName);
            string Result = MyStream.ReadLine();
            while (Result != null)
            {
                string[] StudentData = Result.Split(";");
                Students.Add(new Person(StudentData[0], StudentData[1], StudentData[2], Convert.ToInt32(StudentData[3])));
                Result = MyStream.ReadLine();
            }
            MyStream.Close();
            MyStream.Dispose();
        }

        private static void WriteFile(
            string FilePath, 
            string FileName, 
            List<Person> Data) 
        {
            StreamWriter? MyStream = new StreamWriter(
                FilePath + FileName,
                false,
                Encoding.UTF8);

            foreach (var Person in Persons)
            {
                MyStream.WriteLine(
                    $"{Person.LastName};"+
                    $"{Person.FirstName};" +
                    $"{Person.sex};" +
                    $"{Person.BirthYear}" 
                    );
            }
            MyStream.Close();
            MyStream.Dispose();
            Console.WriteLine("Le fichier {FileName} était écrit!"); 
        }

        private static void ListData(List<Person> MyList)
        {
            foreach (Person person in MyList)
            {
                Console.WriteLine(
                    $"{person.LastName},"+
                    $"{person.FirstName}," +
                    $"{person.sex}," +
                    $"{person.BirthYear}," 
                    );
            }
        }
        private static void InitializeData()
        {
            Persons.Add(new Person("Micalaudie", "Alain", "M", 1967));
            Persons.Add(new Person("qeg", "Alain", "M", 1967));
            Persons.Add(new Person("eergqe", "Alain", "M", 1967));
            Persons.Add(new Person("rger", "Alain", "M", 1967));
            Persons.Add(new Person("gu,kjyu", "Alain", "M", 1967));
            Persons.Add(new Person("yj,", "Alain", "M", 1967));
            Persons.Add(new Person("egheh", "Alain", "M", 1967));
            Persons.Add(new Person("Mictrhhalaudie", "Alain", "M", 1967));
            Persons.Add(new Person("qerg", "Alain", "M", 1967));
            Persons.Add(new Person("Micrynjalaudie", "Alain", "M", 1967));
            Persons.Add(new Person("Micalsrthaudie", "Alain", "M", 1967));
            Persons.Add(new Person("Mictrhhalaudie", "Alain", "M", 1967));
        }


    }
}
