// See https://aka.ms/new-console-template for more information
using Core.Models;

Console.WriteLine("Hello, World!");

#region MyClass - string 
MyClass foodMenu = new MyClass();
foodMenu.Add("Hamburger");
foodMenu.Add("Pizza");
foodMenu.Add("Spaghetti");
foodMenu.Add("Doner");
//foodMenu.ShowAll();
foodMenu.Remove("Pizza");
foodMenu.ShowAll();
int findIndex = foodMenu.FindIndexOf("Spaghetti");
Console.WriteLine(findIndex);
#endregion

#region GenericClass 
//GenericClass<int> numbers = new();
//numbers.Add(1);
//numbers.Add(2);
//numbers.Add(3);
//numbers.Add(4);
//numbers.Add(5);
////numbers.ShowAll();
//numbers.Remove(6);
//numbers.Remove(3);
//numbers.ShowAll();
//int findIndex = numbers.FindIndexOf(4);
//Console.WriteLine(findIndex);
#endregion