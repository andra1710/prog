using System;
using static System.Console;
using static System.Math;


public class cmdline{

public static void Main(string[] args){
	WriteLine("Reading from input...");
	WriteLine("This writes out\n x  sin(x)  cos(x):");
	foreach(var arg in args){
	double x = double.Parse(arg);
	WriteLine($"{x} {Sin(x)} {Cos(x)}");
	}
}
}
