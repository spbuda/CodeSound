using CodeSound.Core;
using CodeSound.Pitch;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace CodeSound.Tests {
	[TestFixture]
	public class QuarterToneScaleTuningTest {
		private readonly QuarterToneScaleTuning scale;

		public QuarterToneScaleTuningTest() {
			scale = Scale.BuildQuarterTone ();
		}

		[TestCase(4, BaseNote.A, Accidental.Natural, 440f)]
		[TestCase (4, BaseNote.C, Accidental.Natural, 261.63f)]
		[TestCase (4, BaseNote.C, Accidental.Sharp, 277.18f)]
		[TestCase (0, BaseNote.C, Accidental.Natural, 16.35f)]
		[TestCase (8, BaseNote.B, Accidental.Natural, 7902.13f)]
		public void QuarterToneScale_NoteTest(int octave, BaseNote note, Accidental accidental, float expectedFrequency) {
			float test = scale[Note.Build(octave, note, accidental)];
			Assert.That (test, Is.EqualTo(expectedFrequency).Within(.01f));
		}

		[TestCase (-1, BaseNote.C, Accidental.HalfFlat)]
		[TestCase (9, BaseNote.C, Accidental.Natural)]
		public void QuarterToneScale_OutOfScale(int octave, BaseNote note, Accidental accidental) {
			Note n = Note.Build (octave, note, accidental);
			try {
				float test = scale[n];
				Assert.Fail ("Expected value " + n.ToString() + " to be out of range but found frequency of " + test);
			} catch(KeyNotFoundException) {
				Assert.Pass ();
			}
		}

		[TestCase (0, BaseNote.C, Accidental.Natural)]
		[TestCase (8, BaseNote.B, Accidental.HalfSharp)]
		public void QuarterToneScale_InScale(int octave, BaseNote note, Accidental accidental) {
			Note n = Note.Build (octave, note, accidental);
			try {
				float test = scale[n];
				Assert.Pass ();
			} catch (KeyNotFoundException) {
				Assert.Fail ("Expected value " + n.ToString () + " found out of range instead.");
			}
		}

		//[TestCase (1)]
		//public void Test1(int i) {
		//	Assert.Pass ();
		//}
	}
}