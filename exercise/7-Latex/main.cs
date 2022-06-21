using System;
using static System.Console;
using static System.Math;
public static class main{ 
// We need it to be public in order to call it
	static double exp(double x){
		if(x<0)return 1/exp(-x);
		if(x>1.0/8)return Pow(exp(x/2),2); // explained in the PDF
		return 1+x*(1+x/2*(1+x/3*(1+x/4*(1+x/5*(1+x/6*(1+x/7*(1+x/8*(1+x/9*(1+x/10)))))))));
}
	public static void Main(){
		double n = 4; // The  range for -n to n
		double dx = 1.0/128; 
		// 1.0/128 is due to we need to use 2 bits and 128 gives us
		// a smooth graph
		for(double x=-n; x<=n; x+=1.0/128){ 
			WriteLine($"{x} {exp(x)}");
		}
	}
}