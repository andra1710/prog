using System;
using static System.Console;
using static System.Math;
using static vec;

class main{
	static void Main(){
			WriteLine($"Part A: Testing the basic math on our vectors");
			// we make three vecs, one without any arguments, which should 
			// return the null vector and two with argument.
			vec v0 = new vec(); // Should be the null vector
			vec v1 = new vec(1, 2, 3);
			vec v2 = new vec(2, 0, 1);

			WriteLine($"Testing the print function:");		
			v0.print("v0 =");
			v1.print("v1 =");
			v2.print("v2 =");

			// Testing the operators:
			(-v1).print("-v1 =");
			WriteLine($"This should be (-1, -2, -3)");
			(v1+v2).print($"v1+v2 =");
			WriteLine($"This should be (3, 2, 4)");
			(v1-v2).print($"v1-v2 =");
			WriteLine($"This should be (-1, 2, 2)");
			(3*v1).print($"3*v1 =");
			WriteLine($"This should be (3, 6, 9)");
			vec v13 = (v1*3); // I sadly cannot call (v1*3).print...
			(v13).print($"v1*3 =");
			WriteLine($"This should also be (3, 6, 9)");
	}

}