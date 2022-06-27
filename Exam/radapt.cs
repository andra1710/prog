using System;
using static System.Math;
public class radapt{
	public static object[] rad(Func<double, double> f, double a, double b, double acc, double eps, int old_N, double old_sum, double old_sum2, int N){
		/* The int N is the number of new points thrown at each iteration
		The next variables are used when we split of our recursive*/
		int N_left = 0;
		double sum_left = 0;
		double sum2_left = 0;
		int N_right = 0;
		double sum_right = 0;
		double sum2_right = 0;
		// the following variables are used when we do not split up our recursive
		var rand = new Random(); // we used this to generate our random points
		double width = b-a; // the interval we work within for x
		double c = (a+b)/2.0; // the middle of our interval 
		double sum = 0;
		double sum2 = 0;

		for(int i=0; i<N; i++){
			double x = a + rand.NextDouble()*width; // in a <= x <= b 
			double fx = f(x);
			sum += fx;
			sum2 += fx*fx;
			if (x<c){ // if the point is in the left half of our interval
				N_left += 1;
				sum_left += fx;
				sum2_left += fx*fx;
			}
			else{ // if the point is in the right half of our interval
				N_right += 1;
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
			object[] ResArray = new object[2];
			ResArray[0] = integral;
			ResArray[1] = old_N;
			return ResArray; // make it a vector with Integral and the N??
		}
		else{ // making the recursive calls til we have the err < tol.
			object[] Left = rad(f, a, c,acc/Sqrt(2),eps, N_left,sum_left, sum2_left, N);
			object[] Right = rad(f, c, b,acc/Sqrt(2),eps,N_right,sum_right, sum2_right, N);
			double Left_integral = Convert.ToDouble(Left[0]);
			int Left_N = (int) Left[1];
			double Right_integral = Convert.ToDouble(Right[0]);
			int Right_N = (int) Right[1];
			object[] ResArray = new object[2];
			ResArray[0] = Left_integral+Right_integral;
			ResArray[1] = Left_N+Right_N;
			return ResArray;
		}
	} 
}