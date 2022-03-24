using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryKeyVlauePair
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Employee> employeeDictionary = new Dictionary<string, Employee>();

            Employee [] employeesTelstra = new Employee[]
                {   new Employee ("CEO","Marry",43,299),
                    new Employee ("Technician","Jackey",23,29),
                    new Employee ("Sale","Machel",21,24),
                    new Employee ("Developer","Henry",23,99),
                    new Employee ("Analyst","Kate",36,43),
                    new Employee ("Accountant","Lorry",53,59),
                    new Employee ("IT support","Niol",40,65),
                    new Employee ("Logeistics","Tom",63,105)
                };

            foreach (Employee employee in employeesTelstra)
            {
                employeeDictionary.Add(employee.Position, employee);
            }
            //Update
            string DicKey = "Analyst";
            if (employeeDictionary.ContainsKey(DicKey))
            {
                employeeDictionary[DicKey] = new Employee("Analyst", "Laura", 22, 18);
                Console.WriteLine("Employee with Role/Key {0} was updated!",DicKey);
            }
            else
            {
                Console.WriteLine("No employee found with this Key {0}", DicKey);
            }
            //Remove
            string removeKey = "Logeistics";
            if (employeeDictionary.Remove(removeKey))
            {
                Console.WriteLine("Employee with position/Key {0} was removed!",removeKey);
            }
            else
            {
                Console.WriteLine("No employee found with this Key {0}", removeKey);
            }


            string key = "CEO";
            if (employeeDictionary.ContainsKey(key))
            {
                Employee emp1 = employeeDictionary["CEO"];
                Console.WriteLine("This is {0}, the {1}, age is {2}, rate is: {3}", emp1.Name, emp1.Position, emp1.Age, emp1.Rate);
            }
            else
            {
                Console.WriteLine("No employee found with the key {0}",key);
            }



            Employee result = null;
            if (employeeDictionary.TryGetValue("Sale", out result))
            {
                Console.WriteLine("Value retrieved!");

                Console.WriteLine(result.Name);
                Console.WriteLine(result.Position);
                Console.WriteLine(result.Age);
                Console.WriteLine(result.Rate);
            }
            for (int i = 0; i < employeeDictionary.Count; i++)
            {
                //using ElementAt(i) to return the key-value pair stored at index i
                KeyValuePair<string, Employee> employDic = employeeDictionary.ElementAt(i);// ElementAt() comes from 'using System. Linq;'
                //print the key
                Console.WriteLine("-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0-0");
                Console.WriteLine("Key: {0}",employDic.Key);
                //store the value in an employee object
                Employee employeee = employDic.Value;
                //print the properties of the employee object;

                Console.WriteLine("Employee Name: {0}",employeee.Name);
                Console.WriteLine("Employee Position: {0}", employeee.Position);
                Console.WriteLine("Employee Age: {0}", employeee.Age);
                Console.WriteLine("Employee Rate: {0}", employeee.Rate);
            }
            


            KeyValuePair<string,Employee> haha = employeeDictionary.ElementAt(0);
        }
    }
}
