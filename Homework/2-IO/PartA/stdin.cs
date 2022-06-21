using System;
using static System.Console;
using static System.Math;


public class stdin{

public static void Main() {
	WriteLine("Reading from input...");
	WriteLine("This writes out\n x  sin(x)  cos(x):");
	char[] delimiters = {' ','\t','\n'};
	var options = StringSplitOptions.RemoveEmptyEntries;
	for( string line = ReadLine(); line != null; line = ReadLine() ){
	var words = line.Split(delimiters,options);
	foreach(var word in words){
		double x = double.Parse(word);
		WriteLine($"{x} {Sin(x)} {Cos(x)}");
                }
        }
}
}
