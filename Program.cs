using myFirstClass.math;

var a = 2;
var b = 3;
var person1 = new Person("Mike", "Chapman");
person1.setFirstName("notMike");
Console.WriteLine(person1.getFirstName());
Console.WriteLine(person1.getLastName());
var person2 = new Person("Jane","Doe");
person1.Introduce();
person2.Introduce();
Console.WriteLine(Person.goodbye());

Console.WriteLine($"{a} + {b} = {Calculator.add(2,3)}");
