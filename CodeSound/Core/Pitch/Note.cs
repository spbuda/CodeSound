using System;

namespace CodeSound.Pitch {
	public struct Note {
		public BaseNote Base => rawNote.note;
		public Accidental Accidental => rawNote.accidental;
		public int Index => rawNote.index;
		public int Octave { get; }
		public const int TopOctave = 8;

		public readonly RawNote rawNote;

		private Note(RawNote n, int o) {
			rawNote = n;
			Octave = o;
		}

		public static Note Build(int index, int octave) {
			return new Note (RawNote.Build (index), octave);
		}

		public static Note Build(int o, BaseNote n, Accidental a = Accidental.Natural) {
			return Build (o, RawNote.Build (n, a));
		}

		public static Note Build(int o, RawNote n) {
			return new Note (n, o);
		}

		public static Note A(int o, Accidental a = Accidental.Natural) {
			return new Note (RawNote.A (a), o);
		}

		public static Note B(int o, Accidental a = Accidental.Natural) {
			return new Note (RawNote.B (a), o);
		}

		public static Note C(int o, Accidental a = Accidental.Natural) {
			return new Note (RawNote.C (a), o);
		}

		public static Note D(int o, Accidental a = Accidental.Natural) {
			return new Note (RawNote.D (a), o);
		}

		public static Note E(int o, Accidental a = Accidental.Natural) {
			return new Note (RawNote.E (a), o);
		}

		public static Note F(int o, Accidental a = Accidental.Natural) {
			return new Note (RawNote.F (a), o);
		}

		public static Note G(int o, Accidental a = Accidental.Natural) {
			if(a == Accidental.Sharp || a == Accidental.SharpAndHalf || a == Accidental.HalfSharp || a == Accidental.DoubleSharp) {
				//In this situation, we have gone up to the next octave.
				o++;
			}
			return new Note (RawNote.G (a), o);
		}

		public static Note Parse(string text) {
			text = text.Trim ();
			char first = text[0];
			string accidentalText = text.Substring (1, text.Length - 1);
			char last = text[text.Length - 1];

			return new Note (RawNote.Build (NoteHelper.ParseBaseNote (text[0]), NoteHelper.ParseAccidental (accidentalText)), NoteHelper.ParseOctave (last));
		}

		public override bool Equals(object obj) {
			if (!(obj is Note)) {
				return false;
			}

			var note = (Note) obj;
			return this.Base == note.Base &&
				   Accidental == note.Accidental &&
				   Octave == note.Octave;
		}

		public override int GetHashCode() {
			return HashCode.Combine (Base, Accidental, Octave);
		}

		public override string ToString() {
			return NoteHelper.ToString(Base) + NoteHelper.ToString (Accidental) + Octave;
		}

		public int QuarterStepsBetween(Note other) {
			int octaveDifference = other.Octave - Octave;
			int indexDifference = other.Index - Index;

			return (octaveDifference * RawNote.Subdivisions) + indexDifference;
		}
	}
}