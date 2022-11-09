using System;
using System.Collections.Generic;
using System.Drawing;

namespace KCheck2
{

	class Animal //parent
	{
		//test code
		public string name;
		public string noise;
		
		public void display(){
			Console.WriteLine("I am an animal ");
		}
		public int fur = x;
		public int feet = false;
	
	}

	class warmBlooded: Animal //child
	{
		public string traits;
		public void getName(){
			Console.WriteLine("I am a " + name);
		}
		public void getNoise(){
			Console.WriteLine("I make this sound " + noise);
		}
	}

	class Program
	{ 
		static void Main(string[] args) 
		{ 
			//object of derived class
			warmBlooded bird = new warmBlooded();

			//access field and method of base class
			bird.name = "Cardinal";
			bird.noise = "Tweet Tweet";
			bird.display();

	bird.getName();	
	bird.getNoise();
		//Code Louisville Code
		// forr every warmBlooded in list "(cat name) has (tail amount) and (feather)

		Console.WriteLine("How many traits do you want to add? ");
		var numberOfTraits = int.Parse(Console.ReadLine());

		var traitsList = new List<warmBlooded>();
		for (int i = 0; i < numberOfTraits; i++)
{
		// In this loop, populate the object's properties using Console.ReadLine()
		var warmBlooded = new warmBlooded();

	Console.WriteLine("Enter the value for ");
		string traits = Console.ReadLine();
    

    
		Console.WriteLine ("birds also have " + traits);

		Console.ReadLine();
}

// Print out the list of records using Console.WriteLine()

    }

// Print out the list of records using Console.WriteLine()
// forr every warmBlooded in list "(cat name) has (tail amount) and (feather)



    }
	}



