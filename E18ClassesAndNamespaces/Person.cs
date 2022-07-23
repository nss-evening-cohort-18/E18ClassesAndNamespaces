using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E18ClassesAndNamespaces;

public enum Options 
{
    Rock,
    Paper,
    Scissors
}

//accessibility modifiers - private, internal, public
public class Person
{
    //classes have members; specifically Properties, Fields, and Methods/Constructors
    public Person()
    {

    }

    public Person(string firstName, string lastName, int age)
    {
        _firstName = firstName;
        _lastName = lastName;
        Age = age;
    }

    private string _firstName;
    private string _lastName;

    //properties need access modifier, type, name
    public int Age { get; set; }
    public bool LikesCilantro
    {
        get => LikesCilantro;
        set => Age = value ? 1 : 0;
    }

    //readonly property, has a getter but no setter, so can only be set in the constructor
    public string Name => $"{_firstName} {_lastName}";
    public Job Job { get; set; }
    
    //Fields are private, inaccessible outside of this class
    private string _ssn;

    ////old version of properties
    //private string _ssn; //private backing field
     
    //public string SSN //property
    //{
    //    get { return _ssn; }
    //    set { _ssn = value; }
    //}

    //methods - what you call a function when it's a class member
    //describing behavior
    public int AddNumbers(int num1, int num2)
    {
        return num1 + num2;
    }

    public void SayHello()
    {
        Console.WriteLine("Hello");
    }

}


