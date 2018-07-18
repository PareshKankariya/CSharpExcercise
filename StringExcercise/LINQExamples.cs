using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExcercise
{
    class LINQExamples
    {

        public void StudentCollection()
        {
            Dictionary<int, string> students = new Dictionary<int, string>();

            students.Add(1, "John");
            students.Add(2, "Jill");
            students.Add(3, "Sam");

            var findStudent = from student in students
                              where student.Key > 1
                              select student;

            var findStudentNew = students.Where(i => i.Key > 1);

            Console.WriteLine("LINQ Query Syntax");
            foreach (var list in findStudent)
            {
                Console.WriteLine("StudentID: {0}   StudentName: {1}", list.Key, list.Value);
            }

            Console.WriteLine("\nLINQ Method Syntax");
            foreach (var list in findStudentNew)
            {            
                Console.WriteLine("StudentID: {0}   StudentName: {1}", list.Key, list.Value);
            }


        }
        //split the string into words order by words length 
        public void StringIntoWords()
        {
            string input = "This    is   a String";
            var splitString = from str in input.Split(' ')
                              where str.Length > 0
                              orderby str.Length
                              select str;
            foreach(string output in splitString)
            {
                Console.WriteLine(output);
            }
        }

        //find the distinct words in the string order by words
        public void distinctWords ()
        {
            string input = "hi my name hi is name my";
            var distWords = from w in input.ToLower().Split(' ').Distinct()
                            select w;
            Console.WriteLine("Distinct words in {0}", input);
            foreach (var output in distWords)
            {
                Console.WriteLine(output);
            }
        }

        public void duplicateWords()
        {
            string input = "hi my name hi is name my";
            var duplicateWords = from dups in input.ToLower().Split(' ')
                                 group dups by dups into temp
                                 orderby temp.Key
                                 where temp.Count() > 1
                                 select temp;

            Console.WriteLine("Duplicate words in {0}", input);
            foreach (var output in duplicateWords)
            {
                Console.WriteLine(output.Key+" "+output.Count());
            }
        }

        public void stringFind()
        {
            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "July", "Aug",
                                "Sept", "Oct", "Nov", "Dec"};

            var monthJ = from j in months
                         where j.StartsWith("J")
                         select j;

            Console.WriteLine("Months starting with J ");
            foreach (var output in monthJ)
            {
                Console.WriteLine(output);
            }

            var monthConJ = from j in months
                            where j.Contains("a")
                            select j;
            Console.WriteLine("Months contains a ");
            foreach (var output in monthConJ)
            {
                Console.WriteLine(output);
            }

        }
        //Find minimum maximum 3 values from int array
        public void IntResult()
        {
            int[] input = {2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var topThree = from five in input
                               orderby (int)five descending
                               select five.ToString();


            Console.WriteLine("Top 3");
            foreach (var output in topThree.Take(3))
            {
                Console.WriteLine(output);
            }

            var bottomThree = from bThree in input
                              orderby bThree ascending
                              select bThree.ToString();

            Console.WriteLine("Top 3");
            foreach (var output in bottomThree.Take(3))
            {
                Console.WriteLine(output);
            }

            var numBetween = from betw in input
                             where betw >= 4 && betw <= 8
                             select betw;

            Console.WriteLine("Number between 3 and 9");
            foreach(var output in numBetween)
            {
                Console.WriteLine(output.ToString());
            }

            var evenNum = from evenum in input
                          where evenum % 2 == 0
                          select evenum;

            Console.WriteLine("Even Number");
            foreach (var output in evenNum)
            {
                Console.WriteLine(output.ToString());
            }

            var oddNum = from oddnum in input
                          where oddnum % 2 != 0
                          select oddnum;

            Console.WriteLine("Odd Number");
            foreach (var output in oddNum)
            {
                Console.WriteLine(output.ToString());
            }


        }


    }
}
