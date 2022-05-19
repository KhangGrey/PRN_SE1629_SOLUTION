namespace PRN.SE1629;

    public class Person
{
    public string Name { get; set; }
    public DateOnly dob { get; set; }
    public Address Address { get; set;  } //Has-A
    
    public Person()
    {

    }

    public Person(string name, DateOnly dob, Address address)
    {
        Name = name;
        dob = dob;
        Address = address;
    }
}