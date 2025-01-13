// Abstraction

// Objects and Classes
// public class Person
// {
//   public string _givenName = "";
//   public string _familyName - "";

//   public Person()
//   {
//   }

//   public void ShowEasternName()
//   {
//     Console.WriteLine($"{_familyName}, {givenName}");
//   }

//   public void ShowWesternName()
//   {
//     Console.WriteLine($"{_givenName} {_familyName}");
//   }
// }

// Class Diagram:
// Class: Person
// Attributes:
// * _givenName: string
// * _familyName: string

// Behaviors (methods):
// * ShowEasternName() : void
// * ShowWesternName() : void

// Person person = new Person();
// person._givenName = "Joseph";
// person._familyName = "Smith";
// person.ShowWesternName();
// person.ShowEasternName();

// Expected Output:
// Joseph Smith
// Smith, Joseph

// person1 = new Person();
// person1._givenName = "Emma";
// person1._familyName = "Smith";
// person1.ShowWesternName();

// person2 = new Person();
// person2._givenName = "Joseph";
// person2._familyName = "Smith";
// person2.ShowWesternName();

// Expected Output:
// Emma Smith
// Joseph Smith

// public class Blind
// {
//   public double _width;
//   public double _height;
//   public string _color;
// }

// Blind kitchen = new Blind();

// kitchen._width = 60;
// kitchen._height = 48;
// kitchen._color = "white";

// Console.WriteLine(kitchen._width);

// public class Blind
// {
//   public double _width;
//   public double _height;
//   public string _color;

//   public double GetArea()
//   {
//     return _width * _height;
//   }
// }

// Blind kitchen = new Blind();

// kitchen._width = 60;
// kitchen._height = 48;
// kitchen._color = "white";

// double materialAmount = kitchen.GetArea();

// public class House
// {
//   public string _owner;
//   public Blind _kitchen;
//   public Blind _livingRoom;
// }

// House johnsonHouse = new House();

// johnsonHouse._kitchen = new Blind();
// johnsonHouse._livingRoom = new Blind();

// or

// public class House
// {
//   public string _owner = "";
//   public Blind _kitchen = new Blind();
//   public Blind _livingRoom = new Blind();
// }

// House johnsonHome = new House();
// johnsonHome._owner = "Johnson Family";
// johnsonHome._kitchen._width = 60;

// public class House
// {
//   public string _owner;
//   public List<Blind> _blinds = new List<Blind>();
// }

// johnsonHome._blinds.Add(kitchen);

// // or

// double amount = jonhsonHome._blinds[0].GetArea();

// // or

// foreach (Blind b in johnsonHome._blinds)
// {
//   double amount = b.GetArea();
// }

