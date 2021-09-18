using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

namespace ApeGaming.MathGame
{
	public static class Util
	{
		private static System.Random Random = new System.Random();

		public static float RandomValue()
		{
			return (float)Random.NextDouble();
		}

		public static float RandomRange(float min, float max)
		{
			return min + ((float)Random.NextDouble() * (max - min));
		}

		public static int RandomRange(int min, int max)
		{
			return Random.Next(min, max);
		}
	}
}