using System.Collections;
using static System.Console;
namespace PRN.SE1629;

public class Program
{
    public static void Main(string[] args)
    {
        /*1. create a new object Employee*/
        /*
        Employee e = new Employee();
        e.Id = 1;
        e.Name = "Dong";
        e.Salary = 150.55d;
        */

        //Employee emp = new Employee(1, "Nguyen Van A", 160d);
        //emp.Name = "Nguyen Cong Phuong";
        //WriteLine(emp);

        /*2. create a list of employees and display them */
        /*
        ArrayList lstEmps = new ArrayList();
        lstEmps.Add(new Employee(1, "Dong", 100));
        lstEmps.Add(new Employee(2, "Minh", 500));
        lstEmps.Add(new Employee(3, "Nam", 300));
        lstEmps.Add(new Employee(4, "Binh", 240));
        lstEmps.Add(new Employee(5, "Dat", 360));
        lstEmps.Add(new Employee(6, "Thanh", 700));
        lstEmps.Add(new Employee(7, "Khang", 530));
        lstEmps.Add("Park Han Seo");
        */
        Employee a = new Employee(1, "Khang", 152d, new DateOnly(), new Address(493, "CMT8", "P.13", "Quan 10", "HCM"));
      
        WriteLine(a);
        WriteLine(a.NameOfCompany);
        
        //display
       // Display(lstEmps);
        ReadLine();
    }

    private static void Display(ArrayList lstEmps)
    {   
        /*
        foreach (Employee e in lstEmps)
        {
            WriteLine(e);
        }
        */
        for(int i = 0; i < lstEmps.Count; i++)
        {
            WriteLine(lstEmps[i]);
        }    
    }
}