using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class BezierCurve {

	static int Factorial(int n) {
		if (n < 0) { return 0; }
		if (n == 0 || n == 1) { return 1; }
		int prod = 1;
		for (int i = 2; i <= n; i++) {
			prod *= i;
		} return prod;
	}

	static int Choose(int n, int k) {
		return Factorial(n)/(Factorial(k)*Factorial(n-k));
	}

	public static Vector3 Path(float t, Vector3[] points) {
		Vector3 sum = Vector3.zero;
		for (int i = 0; i < points.Length; i++) {
			sum += Choose(points.Length, i)*Mathf.Pow(1-t, points.Length-i)*Mathf.Pow(t, i)*points[i];
		} return sum;
	}
}
