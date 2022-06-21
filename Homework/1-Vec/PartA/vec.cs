using System;
using static System.Console;
using static System.Math;
public class vec{
	public double x, y, z;
	//constructors:
	public vec(){
	// makes the vector a null vector when not givin any inputs
		x=y=z=0;
	}
	public vec(double a, double b, double c){
	// Defining the non zero vector
		x=a;
		y=b;
		z=c;
	}
	//print method
	public void print(string s){
		WriteLine($"{s}({x} {y} {z})");
	}
	public void print(){
		this.print("");
	}
   // public static void print(vec v){
    //	v.print("");
    //}
	//Defining operators to use with vectors
	// plus
	public static vec operator+(vec u, vec v){
		return new vec(u.x+v.x, u.y+v.y, u.z+v.z);
	}
	// multiplying a scaler
	public static vec operator*(vec u, double c){
	return new vec(c*u.x, c*u.y, c*u.z);
	}
	public static vec operator*(double c, vec u){
	return u*c;
	}
	// minus
	public static vec operator-(vec u, vec v){
		return new vec(u.x-v.x, u.y-v.y, u.z-v.z);
	}
	public static vec operator-(vec u) {
		return new vec(-u.x, -u.y, -u.z);
	}
	// Dot product
	public static double dot(vec u, vec v){
	return (u.x*v.x+u.y*v.y+u.z*v.z);
	}
	// Cross product
	public static vec cross(vec u, vec v){
		double x = u.y*v.z-u.z*v.y; // x value of cross product
		double y = u.z*v.x-u.x*v.z; // y value of cross product
		double z = u.x*v.y-u.y*v.x; // z value of cross product
		return new vec(x, y, z);
	}
	// norm of the vector
	public double norm(){
		return Sqrt(this.x*this.x+this.y*this.y+this.z*this.z);
	}
	public override string ToString(){
    	return (this.x).ToString() + (this.y).ToString() + (this.z).ToString();
    }
	//Approx method: 
	public bool approx(vec other) {
		double tau = 1e-9; double eps = 1e-9;
		if (Abs(this.x-other.x) < tau && Abs(this.y-other.y) < tau && Abs(this.z-other.z) < tau) {
			return true;
		}
		if (Abs(this.x-other.x)/(Abs(this.x)+Abs(other.x)) < eps && Abs(this.y-other.y)/(Abs(this.y)+Abs(other.y)) < eps && Abs(this.z-other.z)/(Abs(this.z)+Abs(other.z)) < eps) {
			return true;
		}
		else {
			return false;
		}
	}
	public static bool approx(vec u, vec v) {
		return u.approx(v);
	        }
}
