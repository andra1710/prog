using System;
using static System.Math;
public class radapt{
	public static double rad(Func<double, double> f, double a, double b, double acc, double eps, int old_N, double old_sum, double old_sum2){
		int N = 16; // number of random nodes
		/* The next variables are used when we split of our recursive*/
		int N_left = 0;
		double sum_left = 0;
		double sum2_left = 0;
		int N_right = 0;
		double sum_right = 0;
		double sum2_right = 0;
		// the following variables are used when we do not split up our recursive
		var rand = new Random();
		double width = (b-a); 
		double sum = 0;
		double sum2 = 0;

		for(int i=0; i<N; i++){
			double x = a + rand.NextDouble()*(b - a); // in a <= x <= b 
			double fx = f(x);
			sum += fx;
			sum2 += fx*fx;
			if (x<(a+b)/2.0){
				N_left += 1;
				sum_left += fx;
				sum2_left += fx*fx;
			}
			else{
				N_right += 1 ;
				sum_right += fx;
				sum2_right += fx*fx;
			}
		}
		old_N += N;
		old_sum += sum;
		old_sum2 += sum2;
		double mean_f = old_sum / old_N;
		double mean_f2 = old_sum2 / old_N;
		double sigma = Sqrt(mean_f2 - mean_f*mean_f); // the varians
		double integral = mean_f*width;  // the integral
		double err = sigma*width/Sqrt(old_N); // the error
		double tol = acc + Abs(integral)*eps; // calculating our tolerance
		if (err < tol){ // if our error is less than the integral, we will return our integral, error and number of points
			return integral; // make it a vector with Integral and the N??
		}
		else{ // making the recursive calls til we have the err < tol.
			double Left = rad(f, a,(a+b)/2.0,acc/Sqrt(2),eps, N_left,sum_left, sum2_left);
			double Right = rad(f, (a+b)/2.0, b,acc/Sqrt(2),eps,N_right,sum_right, sum2_right);
			return Left+Right;
		}
	} 
}