using CodeSound.Pitch;
using NUnit.Framework;

namespace CodeSound.Tests {
	[TestFixture]
	public class MathMTest {
		[TestCase (1f, 1f, 0f)]
		[TestCase (5f, 2f, 1f)]
		[TestCase (2f, 8f, 2f)]
		[TestCase (10f, 8f, 2f)]
		[TestCase (-5f, 8f, 3f)]
		[TestCase (6f-24f, 24f, 6f)]
		public void Mod(float val1, float val2, float expected) {
			Assert.That (val1.Mod (val2), Is.EqualTo (expected));
		}
	}
}