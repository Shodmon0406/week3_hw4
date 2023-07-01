namespace Domain.Models;

public class Person
{
    string _name;
    string _address;
    public Person(string name, string address)
    {
        _name = name;
        _address = address;
    }
    public string Name { get => _name; set => _name = value; }
    public string Address { get => _address; set => _address = value; }
    public override string ToString()
    {
        return $"{_name}({_address})";
    }
}
