using System;
using System.Collections.Generic;
using System.IO;

namespace TestIO
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Employee Name, Employee Salary \n");
            GetValue();
            WriteValue();
        }



        private static List<Employee> GetValue()
        {
            List<Employee>EmployeeList = new List<Employee>(); //create a new list for employees

            string fileLocation = "../../DataFile.txt"; //create variable to set file location
            StreamReader reader = new StreamReader(fileLocation);
            //the streamreader reads the contents of the file at that location
            // Console.WriteLine(reader.ReadToEnd());

            string Data = reader.ReadToEnd().Trim(); //read the whole file
            var Records = Data.Split('\n'); //split lines in data file into records by specifying a delimiter

            foreach (var record in Records) //loop through the records and create list items
            {
                var rc = record.Split(','); //separate fields by using the Split method
                EmployeeList.Add(new Employee(rc[0], float.Parse(rc[1]))); //add employee to the list
                Console.WriteLine(record);
            }
            reader.Close();
            Console.WriteLine();
            return EmployeeList;
        }
        private static void WriteValue()
        {
            StreamWriter sw = new StreamWriter("../../DataFile.txt", true);
            sw.Write("\nTommy, 10000");
            sw.Close();
        }
    }
}

/* ways to print the records in the employee list
             foreach (Employee emp in EmployeeList)
            {
                Console.WriteLine(emp.getName() + "=>" + emp.getSalary());
                Console.WriteLine($"Name: {emp.getName()} , Salary:{emp.getSalary()}");
                Console.WriteLine("Name: {0}, Salary: {1}", emp.getName(), emp.getSalary());
            } 
*/