using System;
using static System.Console;
using static System.Math;
public class math{
	static void Main() {
		double sqrt2 = Sqrt(2.0);
		Write($"sqrt(2) = {sqrt2}\n");
		Write($"sqrt2*sqrt2 = {sqrt2*sqrt2} (should be equal 2)\n");

		double exp_pi = Exp(PI); 
		Write($"exp(pi) = {exp_pi} (should be approximately 23.14)\n");

		double pow_pi_e = Pow(PI, E);
		Write($"the power of pi to e = {pow_pi_e} (should be approximately 22.45)\n");
	}

}
