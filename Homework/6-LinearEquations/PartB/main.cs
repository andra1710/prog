using System;
using static System.Console;
using static System.Random;
public class main{
	public static void Main(){
		int n = 5;

		var rand = new Random();

		matrix A = new matrix(n,n);
		matrix R = new matrix(n,n);
		matrix Q = new matrix(n,n);		
		for(int i=0; i<n; i++){
			for(int j=0; j<n; j++){
				int num = rand.Next(1,10); 
				A[i,j] = num;
				Q[i,j] = num;
			}
		}
		A.print(); // Randomly generated square matrix A (5x5)
		QRGS.QRGSdecomp(Q,R);

		matrix A_inv = QRGS.QRGSinverse(Q,R);

		A_inv.print(); // Inverse of matrix A

		matrix A_A_inv = A*A_inv;
		matrix I = new matrix(n,n);
		A_A_inv.print(); // printing A*A^-1 to check if it is close to the idenity matrix
		WriteLine($"A*A^-1 is approximately equal to I: {A_A_inv.approx(I)}"); // using approx to check
	}
}