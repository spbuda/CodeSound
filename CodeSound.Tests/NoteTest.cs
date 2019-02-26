using CodeSound.Pitch;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSound.Tests {
	[TestFixture]
	public class NoteTest {

		[TestCase (4, BaseNote.A, Accidental.Natural, 
			4, BaseNote.A, Accidental.Natural, 0)]
		[TestCase (4, BaseNote.A, Accidental.Natural,
			4, BaseNote.A, Accidental.HalfSharp, 1)]
		[TestCase (4, BaseNote.A, Accidental.Natural,
			4, BaseNote.A, Accidental.HalfFlat, -1)]
		[TestCase (4, BaseNote.A, Accidental.Natural,
			4, BaseNote.A, Accidental.Sharp, 2)]
		[TestCase (4, BaseNote.A, Accidental.Natural,
			3, BaseNote.A, Accidental.Natural, -RawNote.Subdivisions)]
		[TestCase (3, BaseNote.A, Accidental.Natural,
			4, BaseNote.A, Accidental.Natural, RawNote.Subdivisions)]
		[TestCase (0, BaseNote.A, Accidental.FlatAndHalf,
			8, BaseNote.G, Accidental.Natural, RawNote.Subdivisions * (Note.TopOctave+1) - 1)]
		public void NoteInterval(int octave1, BaseNote n1, Accidental a1,
			int octave2, BaseNote n2, Accidental a2, int expectedDifference) {
			Note note1 = Note.Build (octave1, n1, a1);
			Note note2 = Note.Build (octave2, n2, a2);

			Assert.That (note1.QuarterStepsBetween (note2), Is.EqualTo (expectedDifference));
		}

		[TestCase (4, BaseNote.A, 
			Accidental.Natural, RawNote.Index.A, 4)]
		[TestCase (3, BaseNote.C,
			Accidental.Natural, RawNote.Index.C, 3)]
		public void NoteIndexValue(int octave, BaseNote n1, Accidental a1, 
			int expectedIndex, int expectedOctave) {
			Note note1 = Note.Build (octave, n1, a1);
			ScaleTuning.NoteIndex index1 = new ScaleTuning.NoteIndex (note1);
			ScaleTuning.NoteIndex expected = new ScaleTuning.NoteIndex (expectedOctave, expectedIndex);

			Assert.That (index1, Is.EqualTo (expected));
		}

		[TestCase (4, 1, 1,
			BaseNote.A, Accidental.Natural,
			BaseNote.C, Accidental.Natural,
			RawNote.Index.At, 4)]
		[TestCase (4, 8, 1,
			BaseNote.A, Accidental.Natural,
			BaseNote.C, Accidental.Natural,
			RawNote.Index.Cs, 5)]
		[TestCase (4, 1, 8,
			BaseNote.A, Accidental.Natural,
			BaseNote.C, Accidental.Natural,
			RawNote.Index.Cs, 5)]
		[TestCase (4, 8, -1,
			BaseNote.A, Accidental.Natural,
			BaseNote.C, Accidental.Natural,
			RawNote.Index.F, 4)]
		[TestCase (4, 1, -8,
			BaseNote.A, Accidental.Natural,
			BaseNote.C, Accidental.Natural,
			RawNote.Index.F, 4)]
		[TestCase (4, 24, -1,
			BaseNote.A, Accidental.Natural,
			BaseNote.C, Accidental.Natural,
			RawNote.Index.A, 3)]
		[TestCase (4, 18, -1,
			BaseNote.A, Accidental.Natural,
			BaseNote.C, Accidental.Natural,
			RawNote.Index.C, 4)]
		[TestCase (4, 5, 1,
			BaseNote.A, Accidental.Natural,
			BaseNote.C, Accidental.Natural,
			RawNote.Index.Cd, 4)]
		[TestCase (4, 6, 1,
			BaseNote.A, Accidental.Natural,
			BaseNote.C, Accidental.Natural,
			RawNote.Index.C, 5)]
		[TestCase (4, 7, 1,
			BaseNote.A, Accidental.Natural,
			BaseNote.C, Accidental.Natural,
			RawNote.Index.Ct, 5)]
		public void NoteIndexIncrements(int octave, int stepCount, int stepSize,
			BaseNote n1, Accidental a1, BaseNote nRoot, Accidental aRoot,
			int expectedIndex, int expectedOctave) {
			Note note1 = Note.Build (octave, n1, a1);
			Note note2 = Note.Build (octave, nRoot, aRoot);

			ScaleTuning.NoteIndex index1 = new ScaleTuning.NoteIndex (note1);
			int center = note2.Index;

			ScaleTuning.NoteIndex nextIndex = index1;
			for (int i = 0; i < stepCount; i++) {
				nextIndex = nextIndex.Next (center, stepSize);
			}

			ScaleTuning.NoteIndex expected = new ScaleTuning.NoteIndex (expectedOctave, expectedIndex);

			Assert.That(nextIndex, Is.EqualTo(expected));
		}
	}
}
