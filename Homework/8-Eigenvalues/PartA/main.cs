using System;
using static System.Console;
using static System.Random;
public class main{
	public static void Main(){
		var rand = new Random();
		int n = 5;
		matrix A = new matrix(n,n);
		matrix V = new matrix(n,n); // To hold the eigenvectors
		
		/* Generating random symmetric matrix A */
		for(int i=0; i<n; i++){
			for(int j=0; j<n; j++){
				int num = rand.Next(1,10);
				A[i,j] = num;
				A[j,i] = num;
			}
		}

		matrix D = A.copy(); // Keeping the eigenvalues


		WriteLine("Generating a random {n} x {n} symmetric Matrix:");
		A.print();
		WriteLine("\n");



		WriteLine("Making the Jacobi EVD:");
		int sweeps = eig.jacobi_diag(D, V); // D contains eigenvalues on the diagonal, V contains eigenvectors
		WriteLine($"The number of sweeps required was: {sweeps}");
		WriteLine("\n The matrix containing eigenvalues on its diagonal is:");
		D.print();
		WriteLine("\n The matrix V containing the normalized eigenvectors in its columns:");
		V.print();
		WriteLine("\n");


		WriteLine("Checking if V^T*A*V=D:");
		matrix ans1 = V.transpose()*A*V;
		ans1.print();
		WriteLine($"\n Using the approx. method, this is {ans1.approx(D)} \n");


		WriteLine("Checking if V*D*V^T=A:");
		matrix ans2 = V*D*V.transpose();
		ans2.print();
		WriteLine($"\n Using the approx. method, this is {ans2.approx(A)}\n");


		WriteLine("Checking if V^T*V=I:");
		matrix ans3 = V.transpose()*V;
		matrix I = new matrix(n,n);
		I.set_unity();
		ans3.print();
		WriteLine($"\n Using the approx. method, this is {ans3.approx(I)}\n");


		WriteLine("Checking if V*V^T=I");
		matrix ans4 = V.transpose()*V;
		ans4.print();
		WriteLine($"\n Using the approx. method, this is {ans4.approx(I)}"\n);




	}
}