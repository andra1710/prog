using System;
using static System.Console;
using static System.Math;
public class main{

	public static void Main(){
		WriteLine("--------------------------------- Part A ---------------------------------\n");
		WriteLine("Testing the implemented Monte-Carlo integrator on some interesting integrals\n");
		/* variables we used in all integrales */
		double acc = 1E-6;
		double eps = 1E-6;
		int old_N = 0;
		double old_sum = 0;
		double old_sum2 = 0;

		WriteLine($"Integrating sin(x)^2 from {0} to {PI}");
		Func<double,double> f1 = x => Sin(x)*Sin(x);
		double a1 = 0;
		double b1 = PI;
		double res1 = radapt.rad(f1, a1, b1, acc, eps, old_N, old_sum, old_sum2, 16);
		double diff1 = Abs(PI/2.0-res1);
		WriteLine($"Result is {res1} and it should be {PI/2}");
		WriteLine($"The difference is {diff1}");


		// testing a new integral
		WriteLine($"Integrating exp(-x**2) from {-PI} to {PI}");
		Func<double,double> f2 = x => Exp(-x*x);
		double a2 = -PI;
		double b2 = PI;
		double res2 = radapt.rad(f2, a2, b2, acc, eps, old_N, old_sum, old_sum2, 16);
		double diff2 = Abs(1.0/2.0-res1);
		WriteLine($"Result is {res2} and it should be around {1.77244}");
		WriteLine($"The difference is {diff2}");

		// testing a new integral
		WriteLine("Integrating 1/sqrt(x) from 1 to 10");
		Func<double,double> f3 = x => 1/Sqrt(x);
		double a3 = 1;
		double b3 = 10;
		double res3 = radapt.rad(f3, a3, b3, acc, eps, old_N, old_sum, old_sum2, 16);
		double diff3 = Abs(2.0/3.0-res3);
		WriteLine($"Result is {res3} and it should be {2.0/3.0}");
		WriteLine($"The difference is {diff3}");

		WriteLine("--------------------------------- Part B ---------------------------------\n");
		WriteLine("Finding the optimum number of new points thrown at each iteration\n");
		/*we try with N =1, 2,4,8, 16, 64, 128 and 256 */
		WriteLine($"We use the untegration of sin(x)^2 from {0} to {PI}, which should be equal to {PI/2}\n");
		double N1 = radapt.rad(f1, a1, b1, acc, eps, old_N, old_sum, old_sum2, 1);
		double N2 = radapt.rad(f1, a1, b1, acc, eps, old_N, old_sum, old_sum2, 2);
		double N4 = radapt.rad(f1, a1, b1, acc, eps, old_N, old_sum, old_sum2, 4);
		double N8 = radapt.rad(f1, a1, b1, acc, eps, old_N, old_sum, old_sum2, 8);
		double N16 = radapt.rad(f1, a1, b1, acc, eps, old_N, old_sum, old_sum2, 16);
		double N64 = radapt.rad(f1, a1, b1, acc, eps, old_N, old_sum, old_sum2, 64);
		double N128 = radapt.rad(f1, a1, b1, acc, eps, old_N, old_sum, old_sum2, 128);
		double N256 = radapt.rad(f1, a1, b1, acc, eps, old_N, old_sum, old_sum2, 256);
		WriteLine($"Result for 1 new points thrown at each iterration is {N1}\n");
		WriteLine($"Result for 2 new points thrown at each iterration is {N2}\n");
		WriteLine($"Result for 4 new points thrown at each iterration is {N4}\n");
		WriteLine($"Result for 8 new points thrown at each iterration is {N8}\n");
		WriteLine($"Result for 16 new points thrown at each iterration is {N16}\n");
		WriteLine($"Result for 64 new points thrown at each iterration is {N64}\n");
		WriteLine($"Result for 128 new points thrown at each iterration is {N128}\n");
		WriteLine($"Result for 256 new points thrown at each iterration is {N256}\n");
		/* trying with a new integral */
		WriteLine($"We use the untegration of exp(-x²) from -{PI} to {PI}, which should be equal to {1.77244}\n");
		double N1_2 = radapt.rad(f2, a2, b2, acc, eps, old_N, old_sum, old_sum2, 1);
		double N2_2 = radapt.rad(f2, a2, b2, acc, eps, old_N, old_sum, old_sum2, 2);
		double N4_2 = radapt.rad(f2, a2, b2, acc, eps, old_N, old_sum, old_sum2, 4);
		double N8_2 = radapt.rad(f2, a2, b2, acc, eps, old_N, old_sum, old_sum2, 8);
		double N16_2 = radapt.rad(f2, a2, b2, acc, eps, old_N, old_sum, old_sum2, 16);
		double N64_2 = radapt.rad(f2, a2, b2, acc, eps, old_N, old_sum, old_sum2, 64);
		double N128_2 = radapt.rad(f2, a2, b2, acc, eps, old_N, old_sum, old_sum2, 128);
		double N256_2 = radapt.rad(f2, a2, b2, acc, eps, old_N, old_sum, old_sum2, 256);
		WriteLine($"Result for 1 new points thrown at each iterration is {N1_2}\n");
		WriteLine($"Result for 2 new points thrown at each iterration is {N2_2}\n");
		WriteLine($"Result for 4 new points thrown at each iterration is {N4_2}\n");
		WriteLine($"Result for 8 new points thrown at each iterration is {N8_2}\n");
		WriteLine($"Result for 16 new points thrown at each iterration is {N16_2}\n");
		WriteLine($"Result for 64 new points thrown at each iterration is {N64_2}\n");
		WriteLine($"Result for 128 new points thrown at each iterration is {N128_2}\n");
		WriteLine($"Result for 256 new points thrown at each iterration is {N256_2}\n");
		WriteLine($"With our first integrals we found that more than one new points give us the right answer to the 3th decimal.\n");
		WriteLine($"In this project I have run the code multiply times and see some get most accurate answer with 64 or 124 points,\n");
		WriteLine($"while other runs shows the more points wer throw, the more accurate our result gets.\n");
		WriteLine($"Depending on what we need, and how much time our program must take up, since more points thrown gives us more calculations.\n");
		WriteLine("--------------------------------- Part C ---------------------------------\n");
		/* We compare with Recursive adaptive integrator from quadratures Part A */
		WriteLine("We calculate our results from Part A using our integrator from the quadratures homework Part A:\n");
		double ans1 = integrator.integrate(f1, a1, b1);
		double ans2 = integrator.integrate(f2, a2, b2);
		double ans3 = integrator.integrate(f3, a3, b3);
		double delta1 = Abs(ans1-res1);
		double delta2 = Abs(ans2-res2);
		double delta3 = Abs(ans3-res3);
		WriteLine($"Result from our radapt {res1} and the result from our quadratures integrator is {ans1}.\n");
		WriteLine($"The difference is {delta1}.\n");
		WriteLine($"Result from our radapt {res2} and the result from our quadratures integrator is {ans2}.\n");
		WriteLine($"The difference is {delta2}.\n");
		WriteLine($"Result from our radapt {res3} and the result from our quadratures integrator is {ans3}.\n");
		WriteLine($"The difference is {delta3}.\n");
		WriteLine($"We see our difference is order or 10^⁻4 or less, so our random approch is just fine.");

	}

}