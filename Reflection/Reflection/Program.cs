using System;
using System.Reflection;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly assemble = Assembly.LoadFrom("SqlServerDB.dll");
            Type type = assemble.GetType("SqlServerDB.PropertyClass");
            object obj = Activator.CreateInstance(type);
            foreach (var item in type.GetProperties())//get all properties
            {
                Console.WriteLine(item.Name);
                if (item.Name.Equals("Id"))
                {
                    item.SetValue(obj, 1);
                }
                else if (item.Name.Equals("Name"))
                {
                    item.SetValue(obj, "帅气");
                }
                else if (item.Name.Equals("Phone"))
                {
                    item.SetValue(obj, "12345435");

                }
                Console.WriteLine(item.GetValue(obj));
            }
        }
    }
}
