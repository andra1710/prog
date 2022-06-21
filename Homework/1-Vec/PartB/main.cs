using System;
using static System.Console;
using static System.Math;
using static vec;

class main{
	static void Main(){
			WriteLine($"Part B: We will be using v1 and v2 from Part A.");
			// Making the same vectors as in part A
			vec v1 = new vec(1, 2, 3);
			vec v2 = new vec(2, 0, 1);

			v1.print("v1 =");
			v2.print("v2 =");

			// Testing the  norm function, dot 
			// and cross product functions:

			// The Norm:			
			WriteLine($"norm of v1, |v1| = {v1.norm()}");
			WriteLine($"This should be 3.741657394");

			// The dot product
			WriteLine($"The dot produckt of v1 and v2 = {dot(v1, v2)}");
			WriteLine($"This should be 5");

			// The Cross product
			Write($"The cross produckt of ");
			cross(v1, v2).print("v1 x v2 =");
			WriteLine($"This should be (2, -5, -4)");

			// The overwriting ToString:
			WriteLine($"Overriden ToString method for vector v1: {v1.ToString()}, standard just states \"vec\""); 

	}

}