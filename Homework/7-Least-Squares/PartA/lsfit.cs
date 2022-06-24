using System;
using static System.Math;
public class lsfit{
	/* this is used to optain the coefficients for the linear combination of functions obtained
		from an ordinary least-squares fit */


	public static double[] fit(double[] ts, double[] ys, double[] dy, Func<double,double>[] func){
		int n = ts.Length;
		int m = func.Length;
		matrix A = new matrix(n, m);
		matrix R = new matrix(m, m);
		vector b = new vector(n);
		for(int i=0; i<n; i++){
			b[i] = ys[i]/dy[i];
			for(int j=0; j<A.size2; j++){
				A[i,j] = func[j](ts[i])/dy[i];
			}
		}


		
		matrix Q = A;
		QRGS.QRGSdecomp(Q,R);
		vector ans = QRGS.solve(R, Q.transpose()*b);
		return ans;
		}
		

	}
