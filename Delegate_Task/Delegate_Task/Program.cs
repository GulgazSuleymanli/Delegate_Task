using Delegate_Task.Models;
using System.Threading.Channels;

namespace Delegate_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task1
            //List<Person> People = new List<Person>();

            //Person person = new Person("Durnisa", "Shahidli", 27);
            //Person person1 = new Person("Maryam", "Aliyeva", 21);
            //Person person2 = new Person("Gulgaz", "Suleymanli", 20);
            //Person person3 = new Person("Konul", "Qasimova", 33);
            //Person person4 = new Person("Daniz", "Suleymanli", 3);
            //Person person5 = new Person("Asif", "Safarov", 20);

            //People.Add(person);
            //People.Add(person1);
            //People.Add(person2);
            //People.Add(person3);
            //People.Add(person4);
            //People.Add(person5);

            //GetPeopleByName("Maryam", People).ForEach(person => Console.WriteLine(person));
            //Console.WriteLine("----------------------------------");

            //People.FindAll(person => person.Surname.Contains("ov") || person.Surname.Contains("ova")).ForEach(person => Console.WriteLine(person));
            //Console.WriteLine("----------------------------------");

            //People.FindAll(person => person.Age >= 20).ForEach(person => Console.WriteLine(person));
            //Console.WriteLine("----------------------------------"); 
            #endregion

            #region Task2
            //List<Exam> exams = new List<Exam>();

            //DateTime dateTime = new DateTime(2020, 03, 18, 15, 35, 13);
            //TimeSpan timeSpan = new TimeSpan(3, 0, 0);
            //Exam exam = new Exam("EtoH", dateTime, timeSpan);

            //DateTime dateTime1 = new DateTime(2023, 10, 24, 10, 46, 18);
            //TimeSpan timeSpan1 = new TimeSpan(1, 45, 0);
            //Exam exam1 = new Exam("MM", dateTime1, timeSpan1);

            //DateTime dateTime2 = new DateTime(2023, 10, 23, 8, 30, 0);
            //TimeSpan timeSpan2 = new TimeSpan(71, 59, 59);
            //Exam exam2 = new Exam("Programming", dateTime2, timeSpan2);

            //exams.Add(exam);
            //exams.Add(exam1);
            //exams.Add(exam2);

            ////exams.ForEach(exam => Console.WriteLine(exam));
            ////Console.WriteLine("------------------------------");

            //exams.FindAll(exam => exam.StartDate > DateTime.Now.AddDays(-7)).ForEach(exam => Console.WriteLine(exam));
            //Console.WriteLine("------------------------------");

            //exams.FindAll(exam => exam.ExamDuration.Hours > 2).ForEach(exam => Console.WriteLine(exam));
            //Console.WriteLine("------------------------------");

            //exams.FindAll(exam => exam.EndDate > DateTime.Now).ForEach(exam => Console.WriteLine(exam));
            //Console.WriteLine("------------------------------");
            #endregion

        }

        //public static List<Person> GetPeopleByName(string name, List<Person> list)
        //{
        //    return list.FindAll(person => person.Name == name);
        //}
    }
}