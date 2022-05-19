namespace PRN.SE1629;
public class Employee:Person
{
    /*fields/data*/
    private int _id;

    /*properties*/
    public double Salary { get; init; } //.NET 6 + /*init only properties*/
    public int Id { get => _id; set => _id = value; }

    public string NameOfCompany { get; } = "FPT Education"; /*Read only properties*/

    /*constructors no param*/
    public Employee()
    {

    }

    /*constructors with params*/
    public Employee(int id, string name, double salary, DateOnly dob, Address address):base(name, dob, address)
    {
        this._id = id;
        this.Salary = salary;
    }

    public override string? ToString()
    {
        return $"[Id = {this._id}, Name = {this.Name}, Salary = {Salary}, Address = {Address}]";
    }
}