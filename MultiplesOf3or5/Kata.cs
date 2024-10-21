using System;
using System.Linq;

namespace MultiplesOf3or5;

public static class Kata
{
	public static int Solution(int value) => Enumerable
			.Range(1, Math.Max(0, value  - 1))
			.Where(i => i % 3 == 0 || i % 5 == 0)
			.Sum();
}