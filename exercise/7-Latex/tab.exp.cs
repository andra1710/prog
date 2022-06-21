using System;
using static System.Console;
using static System.Math;
using System.Collections.Generic;
// This file makes os a table of the Math.Exp(x) as a list
// for x between -n and n with stepsize of dx
class expData{
	public static void Main(){
		double n = 4;
		double dx = 0.5;
		for(double i = -n; i <= n; i+= dx) {  
			WriteLine($"{i} {Math.Exp(i)}");
		}
	}

}