Name: Anders Kragh Bali
Student ID: 201205979
ends with 79, 79%23 =10: Adaptive 1D integrator with random nodes
Implement an adaptive division-by-two one-dimensional integrator with random abscissas. Reuse points (note that you don't need to pass the points to the next level of recursion, only the statistics).
Something like

static double radapt(
	double a, double b, Func<double,double> f,
	double acc, double eps,
	double noldpoints, double oldaveragef, double oldaveragef2
	int N /* the number of new points to throw at each iteration */
	)
Find the optimum N by experimenting with your favourite integrals.

Compare with our predefined-nodes adaptive integrators.