using System;
using static System.Console;
using static System.Random;
/*The matrix and vectors is made by Fedorov */
public class main{
	public static void Main(){
		// Testing the decomposition routine
		int n = 5;
		int m = 4;

		matrix A = new matrix(n,m);
		matrix R = new matrix(m,m);
		matrix Q = new matrix(n,m);
		var rand = new Random();

		for(int i=0; i<n; i++){
			for(int j=0; j<m; j++){
				int num = rand.Next(1,10);
				A[i,j] = num;
				Q[i,j] = num;
			}
		}
		
		A.print(); // printing A.

		QRGS.QRGSdecomp(Q, R);

		
		Q.print(); // printing Q after the decomposition.
		R.print(); // printing R after the decomposition.
		
		
		WriteLine("Checking that Q^T*Q is the identity matrix (1).");
		matrix Q_T_Q = Q.transpose()*Q;
		Q_T_Q.print(); // printing it out to see if it is the identity matrix

		WriteLine("Checking that Q*R = A:");
		matrix QR = Q*R;
		QR.print();


		/* Testing the linear solver routine = 5 */
		matrix A2 = new matrix(n,n);
		matrix R2 = new matrix(n,n);
		vector b = new vector(n);
		for(int i=0; i<n; i++){
			b[i] = rand.Next(1,10);
			for(int j=0; j<n; j++){
				A2[i,j] = rand.Next(1,10);
			}
		}

		/* printing matrix and vector */
		A2.print(); 
		b.print();



		WriteLine("Factorizing A into QR:");
		matrix C2 = A2.copy(); // copy of A2
		QRGS.QRGSdecomp(A2, R2);
		/* printing matrix and vector */
		A2.print();
		R2.print();


		WriteLine("Solving the system of equations. The solution (x) is:");
		matrix Q2 = A2.copy();
		vector x = QRGS.solve(Q2, R2, b);
		x.print();
		
		WriteLine("Checking that A*x=b\n");
		vector A_x = C2*x;
		A_x.print();
		b.print();
		WriteLine($"Is A*x approximately equal to b? {A_x.approx(b)}");
	}
}