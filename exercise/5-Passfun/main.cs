using System;
using static System.Console;
using static System.Math; // We use math in the fun
using static table; // We use the make_table fubktion
public class main{
	public static void Main() {
		for(int i = 1; i <= 3; i++){ 
		// I use i instead of k for the counting, since I use i>j>k.
			WriteLine("");
			WriteLine($"Table for sin({i}x):");
			make_table(x => Sin(i*x), 0, 2*PI, 0.1);
		}
	}
}