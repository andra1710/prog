using System;
using static System.Console;
using static System.Math;
using static vec;

class main{
	static void Main(){
			vec v1 = new vec(1, 2, 3);
			vec v2 = new vec(2, 0, 1);

			v1.print("v1 =");
			v2.print("v2 =");

		WriteLine($"Part C: Testing the approx method between our vectors form Part A");
		WriteLine($"Testing approx(v1, v1), expecting true:");
		WriteLine($"v1.approx(v1) = {v1.approx(v1)}");
		WriteLine($"approx(v1,v1) = {approx(v1,v1)}");
		WriteLine($"Testing approx(v1, v2), expecting false:");
		WriteLine($"v1.approx(v2) = {v1.approx(v2)}");
		WriteLine($"approx(v1,v2) = {approx(v1,v2)}");
	}

}