using System;
using System.Collections.Generic;
using System.IO;

namespace MatchCalendar
{
    class Program
    {
        public static void Main(string[] args)
        {
            string dirs = @""; // Type the path where you want the folder to be created
           if(Directory.Exists(dirs))
            {

            }else if(!Directory.Exists(dirs))
            {
                Directory.CreateDirectory(dirs);
            }
                
            
            
            

            CreateFile();

            
            
                
                
                Console.ReadLine();
                Console.WriteLine("Press Enter to shut down!");

            


            Console.ReadLine();
        }

        public static void CreateFile()
        {

            string filePath = @"";
            

            
            Console.ReadKey();
            TextProcessor textProcessor = new TextProcessor();

            textProcessor.OriginalProcessor();






        }
        public List<Person> PopulateList()
        {
            
            var personlogs = new List<Person>();
            
            //personlogs.Add(new Person { DateOfMatch = new DateTime(2020, 4, 21, 4, 30, 0), TeamName = "England   VS   India", UserName = "Alex Louis"});
            personlogs.Add(new Person { DateOfMatch = new DateTime(2020, 5, 20, 6, 45, 0), TeamName = "Bangladesh   VS   Australia", UserName = "Louise"});



            return personlogs;
            
            

            

        }
        


        

    }
}
