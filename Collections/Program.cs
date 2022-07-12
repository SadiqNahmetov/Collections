using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Collections1
            //List<int> nums = new List<int>();

            //nums.Add(11);
            //nums.Add(4);
            //nums.Add(8);
            //nums.Add(15);

            //List<string> words = new List<string>();

            //words.Add("Sadiq");
            //words.Add("Ramil");
            //words.Add("Esqin");
            //words.Add("Mirsamir");


            //foreach (var item in words)
            //{
            //    Console.WriteLine(item);
            //}


            //Console.WriteLine(nums[0]);

            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}

            //for (int i = 0; i < nums.Count; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
            //if (nums.Count == 4)
            //{
            //    Console.WriteLine("List cont is {0}", nums.Count);
            //}

            //List<Person> people = new List<Person>();
            //Person person1 = new Person();
            //person1.Name = "Orxan";
            //person1.Id = 5;
            //person1.Email = "orxan@gmail.com";


            //Person person2 = new Person
            //{
            //    Id = 6,
            //    Name = "Ilkin",
            //    Email = "ilkin@gmail.com"
            //};

            //people.Add(person2);
            //people.Add(person1);

            //people.Add(new Person { Id = 1, Name = "Sadiq", Email = "sadigfn@code.edu.az" });
            //people.Add(new Person { Id = 2, Name = "Esqin", Email = "esginj@code.edu.az" });
            //people.Add(new Person { Id = 3, Name = "Ramil", Email = "ramilbn@code.edu.az" });
            //people.Add(new Person { Id = 4, Name = "Mirsamir", Email = "mirsamir@code.edu.az" });

            //GetStudents(people);

            ////GetNumbers(nums);
            ///

            //var result = GetPersonByname(people, "Orxan");

            //Console.WriteLine(result.Name + "_" + result.Email + result.Id);

            //var result = GetPersonByname(people, "Orxan");
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Name + "_" + item.Email + item.Id);
            //}
            #endregion


            //SortedList<int, string> datas = new SortedList<int, string>();
            //datas.Add(5, "Sadiq");
            //datas.Add(3, "Ramil");

            //foreach (KeyValuePair<int,string> item in datas)
            //{
            //    Console.WriteLine(item.Key+ "-"+ item.Value);
            //}

            //ArrayList datas = new ArrayList();
            //datas.Add("Hello P130");
            //datas.Add(11);
            //datas.Add(true);

            //foreach (var item in datas)
            //{
            //    Console.WriteLine(item);
            //}

            //HashSet<int> datas = new HashSet<int>();

            //datas.Add(1);
            //datas.Add(2);
            //datas.Add(1);

            //foreach (var item in datas)
            //{
            //    Console.WriteLine(item);

            //}

            //Stack<int> datas = new Stack<int>();

            //datas.Push(1);
            //datas.Push(55);
            //datas.Push(33);

            //foreach (var item in datas)
            //{
            //    Console.WriteLine(item);
            //}

            //Queue<int> datas = new Queue<int>();

            //datas.Enqueue(22);
            //datas.Enqueue(44);
            //datas.Enqueue(11);


            //foreach (var item in datas)
            //{
            //    Console.WriteLine(item);
            //}

            Dictionary<string, string> datas = new Dictionary<string, string>();

            datas.Add("Admin", "Sadiq");
            datas.Add("Member", "Esqin");
            datas.Add("Superadmin", "Cavid");


            foreach (KeyValuePair<string,string> item in datas)
            {
                // Console.WriteLine($" Name : {item.Value}, Role : {item.Key}");
                if (item.Key == "Admin")
                {
                    Console.WriteLine($" Name : {item.Value}, Role : {item.Key}");
                    break;
                }
            }

        }

         

        #region Collections
        //public static Person GetPersonByname(List<Person> peaple, string name)
        //{
        //    var  person = peaple.Find(m => m.Name == name);
        //    return person;
        //}
        //public static void GetStudents(List<Person> students)
        //{
        //    foreach (var stu in students)
        //    {
        //        Console.WriteLine("Students : Id -{0}, Name-{1}, Email-{2}", stu.Id, stu.Name, stu.Email);
        //    }
        //}


        //public static void GetNumbers(List<int> numbers)
        //{
        //    foreach (var item in numbers)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}


    }

    //public class Person
    //    {
    //        public int Id { get; set; }
    //        public string Name { get; set; }
    //        public string Email { get; set; }
    //        #endregion
    //    }
    #endregion

}
