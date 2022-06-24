using System;
using static System.Console;
using static System.Math;
public class main{

	public static void Main(){
		WriteLine("Testing the implemented Monte-Carlo integrator on some interesting integrals\n");
		/* variables we used in all integrales */
		double acc = 1E-5;
		double eps = 0;
		int old_N = 0;
		double old_sum = 0;
		double old_sum2 = 0;

		WriteLine("Integrating sin(x)^2 from 0 to pi");
		Func<double,double> f1 = x => Sin(x)*Sin(x);
		double a1 = 0;
		double b1 = PI;
		double res1 = radapt.rad(f1, a1, b1, acc, eps, old_N, old_sum, old_sum2);
		double diff1 = Abs(PI/2.0-res1);
		WriteLine($"\tResult is {res1} and it should be {PI/2.0}");
		WriteLine($"\tThe difference is {diff1}");


		// testing a new integral
		WriteLine("Integrating x from 0 to 1");
		Func<double,double> f2 = x => x;
		double a2 = 0;
		double b2 = 1;
		double res2 = radapt.rad(f2, a2, b2, acc, eps, old_N, old_sum, old_sum2);
		double diff2 = Abs(1.0/2.0-res1);
		WriteLine($"\tResult is {res2} and it should be {1.0/2.0}");
		WriteLine($"\tThe difference is {diff2}");

		// testing a new integral
		WriteLine("Integrating sqrt(x) from 0 to 1");
		Func<double,double> f3 = x => Sqrt(x);
		double a3 = 0;
		double b3 = 1;
		double res3 = radapt.rad(f3, a3, b3, acc, eps, old_N, old_sum, old_sum2);
		double diff3 = Abs(2.0/3.0-res3);
		WriteLine($"\tResult is {res3} and it should be {2.0/3.0}");
		WriteLine($"\tThe difference is {diff3}");

	}

}