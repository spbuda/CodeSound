namespace CodeSound.Utilities {
	public static class MathM {
		/// <summary>
		/// C#'s Mod operator handles negative numbers in an unintuitive way.
		/// This mod function treats them in a more reasonable manner.
		/// </summary>
		/// <param name="self"></param>
		/// <param name="other"></param>
		/// <returns>value of self % other</returns>
		public static int Mod(this int self, int other) {
			if (other == 0) {
				return 0;
			}
			return ((self % other) + other) % other;
		}

		/// <summary>
		/// C#'s Mod operator handles negative numbers in an unintuitive way.
		/// This mod function treats them in a more reasonable manner.
		/// </summary>
		/// <param name="self"></param>
		/// <param name="other"></param>
		/// <returns>value of self % other</returns>
		public static float Mod(this float self, float other) {
			if (other == 0) {
				return 0f;
			}
			return ((self % other) + other) % other;
		}

		public static bool InRange(this float value, float center, float range) {
			return center - range <= value && value <= center + range;
		}

		public static bool Between(this float value, float min, float max) {
			return min <= value && value <= max;
		}

		public static bool InRange(this int value, int center, int range) {
			return center - range <= value && value <= center + range;
		}

		public static bool Between(this int value, int min, int max) {
			return min <= value && value <= max;
		}

		public static bool IsReal(this float f) {
			return !float.IsInfinity (f) && !float.IsNaN (f);
		}
	}
}