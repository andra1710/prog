using System;
using static System.Console;
using static System.Random;
public class main{
	public static void Main(){
		double[] ts = new double[] {1,2,3,4,6,9,10,13,15}; // time
		double[] ys = new double[] {117,100,88,72,53,29.5,25.2,15.2,11.1}; // activity
		double[] dy = new double[] {5,5,5,5,5,1,1,1,1};
		
		
		var func = new Func<double,double>[] { z => 1.0, z => z }; // our function
		
		using(var outfile = new System.IO.StreamWriter("data_points.txt")){
			for(int i = 0; i<ts.Length; i++){
				outfile.WriteLine($"{ts[i]} {ys[i]} {dy[i]}");
			}
		}

		for(int i=0; i<ys.Length; i++){
			dy[i] = dy[i]/ys[i];
			ys[i] = Math.Log(ys[i]);
		}
		
		double[] cs = lsfit.fit(ts, ys, dy, func);

		using(var outfile = new System.IO.StreamWriter("best_fit.txt")){
			for(double t=0; t<=16; t+=1.0/16){
				double res = 0;
				for(int j=0; j<func.Length; j++){
					res += cs[j]*func[j](t);
				}
				outfile.WriteLine($"{t} {Math.Exp(res)}");
			}
		}

		WriteLine(" ");
		WriteLine($"The fit parameters are: a = {cs[0]} and lambda = {cs[1]}");
		WriteLine($"The half-life is Ln(2)/-lambda = {Math.Log(2)/(-cs[1])} days");
		WriteLine("This is not close to the table value of 3.6319 days (Wikipedia)");
	}
}