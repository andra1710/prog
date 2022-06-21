using System;
using static System.Console;
using static System.Math;

class main{
	public static double erf(double z){
		Func<double,double> f = delegate(double x){return Exp(-x*x);};
		double result = integrate.quad(f:f,a:0,b:z,acc:1e-6,eps:0);
		return result*2/Sqrt(PI);
	}
	
	public static void Main(){
			int Ncalls=0; // Ncalls is equal the the nummber of calls we use to get the answer.
			Func<double,double> f = delegate(double x){
				Ncalls++; 
				return Log(x)/Sqrt(x);
			};
			/* calling the quad function made by Dmitri 
			with certain accuracies  of 1e-7*/
			double result = integrate.quad(f,a:0,b:1,acc:1e-7,eps:1e-7);  
			WriteLine($"Integral of ln(x)/sqrt(x): Result = {result}, Ncalls = {Ncalls}");

			WriteLine($"\n");
			for(double x=-5; x<=5; x+=1.0/8){
				WriteLine($"{x} {erf(x)}");
			}
	}
}
