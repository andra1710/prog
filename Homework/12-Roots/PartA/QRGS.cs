using static System.Console;
using static System.Math;
public class QRGS{

	public static void QRGSdecomp(matrix A, matrix R){
		int m = A.size2;
		for(int i=0; i<m; i++){
			R[i,i] = A[i].norm();
			A[i] = A[i]/R[i,i]; // qi = ai/Rii, i.e. change the ai vector
			for(int j=i+1; j<m; j++){
				R[i,j] = A[i].dot(A[j]);
				A[j] = A[j] - A[i]*R[i,j];
			}
		}
	}

	public static vector solve(matrix Q, matrix R, vector b){ /* solve vector */
		matrix Q_trans = Q.transpose(); // Q transpose
		vector x = Q_trans*b; // calculates the solotion
		backsub(R,x);
		return x;
	}

	public static void backsub(matrix U, vector c){
		for(int i = c.size-1; i>=0; i--){
			double sum = 0;
			for(int k = i+1; k<c.size; k++){
				sum += U[i,k]*c[k];
			}
		c[i] = (c[i]-sum)/U[i,i];
		}
	}
	
		public static matrix QRGSinverse(matrix Q, matrix R){
		int n = Q.size1;
		matrix I = new matrix(n,n);
		I.set_identity();

		matrix inv = new matrix(n,n);
		for(int i=0; i<n; i++){
			vector e = I[i];
			vector inv_i = solve(Q, R, e);
			inv[i] = inv_i;
		}
		return inv;
	}
	
	

}