using System;
using System.Diagnostics;
using CodeSound.Utilities;

namespace CodeSound.Pitch {
	public struct NoteIndex {
		public int Index { get; }
		public int Octave { get; }

		public NoteIndex(int octave, int index) {
			Index = index;
			Octave = octave;
		}

		public NoteIndex(Note note) {
			Index = note.Index;
			Octave = note.Octave;
		}

		public NoteIndex Next(int centerIndex, int interval) {
			Debug.Assert (interval != 0);

			int nextIndex = Index + interval;
			int nextOctave = Octave;
			if (Index < centerIndex && nextIndex >= centerIndex) {
				nextOctave++;
			}else if(Index >= centerIndex && nextIndex < centerIndex) {
				nextOctave--;
			}
			nextIndex = nextIndex.Mod (RawNote.Subdivisions);

			return new NoteIndex (nextOctave, nextIndex);
		}

		public override bool Equals(object obj) {
			if (!(obj is NoteIndex)) {
				return false;
			}

			var index = (NoteIndex) obj;
			return Index == index.Index &&
					Octave == index.Octave;
		}

		public override int GetHashCode() {
			return HashCode.Combine (Index, Octave);
		}

		public override string ToString() {
			return "I) " + Index + ", O) " + Octave;
		}
			
		public static bool operator ==(NoteIndex self, NoteIndex other) => self.Equals (other);
		public static bool operator !=(NoteIndex self, NoteIndex other) => !self.Equals (other);

		public static bool operator >=(NoteIndex self, NoteIndex other) => self > other || self == other;
		public static bool operator <= (NoteIndex self, NoteIndex other) => self < other || self == other;

		public static bool operator <(NoteIndex self, NoteIndex other) {
			if (self.Octave < other.Octave) {
				return true;
			} else if (self.Octave > other.Octave) {
				return false;
			} else {
				return self.Index < other.Index;
			}
		}

		public static bool operator >(NoteIndex self, NoteIndex other) {
			if (self.Octave > other.Octave) {
				return true;
			} else if (self.Octave < other.Octave) {
				return false;
			} else {
				return self.Index > other.Index;
			}
		}
	}
}