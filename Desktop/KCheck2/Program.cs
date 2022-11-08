using System;
using System.Collections.Generic;
using System.Drawing;

namespace KCheck2
{

	class Animal //parent
	{
		public string Vertibrites = "Warm-Blooded"; // Animal Type
		public void whistle() //method
		{
			Console.WriteLine("Tweet, tweet!");
		}
		public int fur = x;
		public int feet = false;
	
	}

	class Bird: Animal //child
	{
		public string birdType = "Cardinal"; // Bird Type
	}
	class Program
	{ 
		static void Main(string[] args) 
		{ 

    Console.WriteLine("How many Birds do you want to add? ");
	var numberOfRecords = int.Parse(Console.ReadLine());

	var recordList = new List<Bird>();
	for (int i = 0; i < numberOfRecords; i++)
{
	Console.ReadLine(recordList);
	var Bird = new Bird();

	Console.WriteLine("Enter the value for ");
	Bird.birdType = Console.ReadLine();
    
// forr every bird in list "(cat name) has (tail amount) and (feather)
	recordList.Add(Bird);

}
            Console.WriteLine("This");

    }
    }
	}


