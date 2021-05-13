/*
 * lufer
 * LP2
 * Lambda Expressions
 * Ver: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions
 * 
 * LINQ
 * Ver: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/
 * 
 *  A partir de C# 7
 *  Lambda Expressions and Tuplos
 *  Func<(int, int, int), (int, int, int)> doubleThem = ns => (2 * ns.Item1, 2 * ns.Item2, 2 * ns.Item3);
 *  var numbers = (2, 3, 4);
 *  var doubledNumbers = doubleThem(numbers);
 *  Console.WriteLine($"The set {numbers} doubled: {doubledNumbers}");
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace _LINQ
{
    class Program
    {
        //declara delegates
        delegate bool IsYoungerThan(Student stud, int youngAge);
        delegate void NumberChanger(int n);

        static void Main(string[] args)
        {
            #region Lambda Functions

            //Func<input,output>
            Func<int, int> square = x => x * x;
            Console.WriteLine(square(5));

            Func<double, double> cube = x => x * x * x;

            string message1 = "O Benfica é o maior...";
            string message2 = "O Portinho é quase....";
            //Action<string, string> concat;
            Action<string, string> concat = new Action<string, string>(WriteToConsole);
            //ou
            //concat = WriteToConsole;
            concat(message1, message2);

            //Action
            Action<Student> PrintStudentDetail = s => Console.WriteLine("Name: {0}, Age: {1} ", s.Name, s.Age);
            PrintStudentDetail(new Student("Aluno", 20));

            //Function
            Func<int, string, bool> isTooLong = (int x, string s) => s.Length > x;
            Console.WriteLine("'Olamundo' tem mais que 12 caracteres? " + isTooLong(12,"Olamundo"));

            Func<int, int, bool> testForEquality = (x, y) => x == y;
            Console.WriteLine("{0} = {1} ? {2}", 12, 12, testForEquality(12, 12));

            //Outro
            Func<Student, bool> isStudentTeenAger = s => s.Age > 12 && s.Age < 20;
            Student std = new Student() { Age = 21 };
            bool isTeen = isStudentTeenAger(std);   //devolve False

            //Action
            //Action<Student> PrintStudentDetail = s => Console.WriteLine("Name: {0}, Age: {1} ", s.Name, s.Age);
            //ou
            Action<Student> StudentDetail = s => Console.WriteLine(s.ToString());
            Student std1 = new Student() { Name = "Bill", Age = 21 };
            StudentDetail(std);//output: Name: Bill, Age: 21
            #endregion  

            #region Lambda and Delegates

            #region Caso 1

            //Instancia de Delegate
            //Lambda expression com uma só ação
            IsYoungerThan aux1 = (s, youngAge) => s.Age < youngAge;
            //ou
            //IsYoungerThan nc = delegate (Student s, int a) {
            //    return s.Age < a;
            //};

            //Instância de Delegate
            //Lambda expression com várias ações
            IsYoungerThan aux2 = (s, youngAge) => {
                Console.WriteLine("Lambda expression com várias ações");
                return s.Age < youngAge;
            };

            Student stud = new Student("André", 25);
            Console.WriteLine(aux2(stud, 26));          //Método anónimo

            #endregion

            #region Caso 2

            //instância de delegate
            NumberChanger nc = delegate (int x)
            {
                Console.WriteLine("Anonymous Method: {0}", x);
            };

            //chama delegate com método anónimo
            nc(10);

            //instância de delegate com método 
            nc = new NumberChanger(TestDelegate.AddNum);

            //chama o delegate com o método associado 
            nc(5);

            //instância de delegate com outro método 
            nc = new NumberChanger(TestDelegate.MultNum);

            //chama o delegate com o método associado 
            nc(2);

            Console.ReadKey();
            #endregion

            #endregion

            #region LINQ

            #region Caso 1

            string[] clubes = { "Benfica", "Porto", "Sporting", "Braguinha", "Gil Vicente" };

            //Get only short words
            var shortClubs = from s in clubes where s.Length <= 5 select s;

            //Print each word out
            foreach (string word in shortClubs)
            {
                Console.WriteLine(word);
            }
            #endregion

            #region Caso 2
            
            IList<Student> studentList = new List<Student>() {
                new Student() { Id = 1, Name = "André", Age = 13} ,
                new Student() { Id = 2, Name = "Joana",  Age = 21 } ,
                new Student() { Id = 3, Name = "João",  Age = 18 } ,
                new Student() { Id = 4, Name = "Paula" , Age = 20} ,
                new Student() { Id = 5, Name = "Joaquim" , Age = 15 }
            };

            //usa delegate
            var teenAgerStudent = studentList.Where(isStudentTeenAger);
            Console.WriteLine("Lindinhos:");
            foreach (Student s in teenAgerStudent)
            {
                Console.WriteLine(s.Name);
            }

            //Compreensão
            var students =  from s in studentList
                            where (s.Age < 20 && s.Age>12)
                            select s;

            //Lambda expression
            List<Student> students1 = studentList.Where(s => (s.Age < 20 && s.Age>12)).ToList<Student>();

            //Usa Delegate
            var students2 = from s in studentList
                            where isStudentTeenAger(s)
                            select s.Name;

            //Extension Methods
            var filteredResult = studentList.Where((s, i) => {
                        if (i % 2 == 0) // if even element
                            return true;      
                        return false;
            });

            foreach (var s in filteredResult)
                Console.WriteLine(s.Name);

            //multiple where
            var filteredResult1 = from s in studentList
                                 where s.Age > 12
                                 where s.Age < 20
                                 select s;

            foreach (var s in filteredResult1)
                Console.WriteLine(s.Name);

            //Order by

            var orderByResult = from s in studentList
                                orderby s.Name descending                   
                                select s;
            //ou
            var studentsInAscOrder = studentList.OrderBy(s => s.Name);

            var orderByResult2 = from s in studentList
                                 where s.Age < 20
                                 orderby s.Name, s.Age
                                 select s;// new { s.Name, s.Age };

            //Average
            int[] fibNum = { 1, 1, 2, 3, 5, 8, 13, 21, 34 };
            double averageValue = fibNum.Where(num=> num % 2 !=0).Average();
            Console.WriteLine(averageValue);
            Console.ReadLine();

            //All - Se todos verificam
            bool areAllStudentsTeenAger = studentList.All(s => s.Age > 12 && s.Age < 20);
            Console.WriteLine(areAllStudentsTeenAger);

            //Any - Se pelo menos um verifica
            bool areAllStudentsTeenAger1 = studentList.Any(s => s.Age > 12 && s.Age < 20);


            //Contains
            IList<int> intList = new List<int>() { 1, 2, 3, 4, 5 };
            bool result = intList.Contains(10);  // returns false

            //Contains Student
            Student st = new Student() { Id = 3, Name = "Seis" };
            bool result1 = studentList.Contains(st, new StudentComparer());
            Console.WriteLine(result1);

            #endregion

            #endregion
        }

        /// <summary>
        /// auxiliar
        /// </summary>
        /// <param name="string1"></param>
        /// <param name="string2"></param>
        private static void WriteToConsole(string string1, string string2)
        {
            Console.WriteLine("{0}\n{1}", string1, string2);
        }
       
    }

    /// <summary>
    /// Auxiliar
    /// </summary>
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student() { }
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1} ", Name, Age);
        }
    }

    /// <summary>
    /// Compara students
    /// </summary>
    class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if (x.Id == y.Id &&
                        x.Name.ToLower() == y.Name.ToLower())
                return true;

            return false;
        }

        public int GetHashCode(Student obj)
        {
            return obj.GetHashCode();
        }
    }
}
