using E18ClassesAndNamespaces;
using E18ClassesAndNamespaces.Models;

//Classes - blueprint for an object of some type
string nameOfPerson = "Brian";
Address address = new Address();

//List<type> collection of same type of thing

//Dictionary<> collection of key value pairs
/*const dog = {
 * name: "Fido",
 * age: 3,
 * 
 *} 
 *dog.name
 *dog.age
 *dog[name]
*/
Person myPeep = new Person("Brian", "Neal", 41);
Dictionary<string, Person> peopleDictionary = new Dictionary<string, Person>();
peopleDictionary["Brian"] = myPeep;
string rockArt = @"_______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)";





//maybe use an enum instead of string for the key?  hmmmm.....
Dictionary<string, string> graphics = new Dictionary<string, string>()
{
    {"rock", rockArt },
    {"Paper",  "paper ascii art"},
    {"Scissors",  "scissor ascii art"}

};

List<string> options = new List<string> { "Rock", "Paper", "Scissors" };

string userSelection = "Rock";

string artworkToUse = graphics["Rock"];

Console.WriteLine(artworkToUse);

if (options[0] == "Rock")
{

}

Person otherPerson = new Person();
Console.WriteLine(otherPerson.Name);


//myPeep.Name = "Brian";
myPeep.Age = 30;
int otherVariable = myPeep.Age;
int sum = myPeep.AddNumbers(3, 7);
Console.WriteLine(myPeep.Name);





Console.ReadLine();
