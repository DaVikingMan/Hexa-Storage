using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;
using System;
using System.IO;

namespace MatchCalendar
{
    public class TextProcessor
    {
        public void OriginalProcessor()
        {
            var f = new Program();
            List<Person> p = f.PopulateList();

           

            string filePath = @""; // Type the path of folder and write the file name with its appropriate file extension







           

            


            

            foreach (var l in p)
            {



                var k = Convert.ToString(l.DateOfMatch);

               

                var Team = l.TeamName;

                var def = l.UserName;



                string[] Match = new string[4] { def, "    ", k, Team };

                
                if(File.Exists(filePath))
                {
                    var fileRead = File.ReadAllText(filePath);
                    Console.WriteLine(fileRead);
                }else if(!File.Exists(filePath))
                {
                    FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate);


                    fileStream.Close();
                    File.WriteAllLines(filePath, Match);
                    var StartfileRead = File.ReadAllText(filePath);
                    Console.WriteLine(StartfileRead);

                }

                Console.ReadKey();
                









            }
                

                

                
                






            

            


        }
    }
}
