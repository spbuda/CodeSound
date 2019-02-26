using System;
using System.Diagnostics;
using System.IO;

namespace CodeSound.Utilities {

	//0    1    2    3    4    5    6    7    8    9    10   11   12   13   14   15   16   17   18   19   20   21   22   23
	//G+1, G+2, G+3, A+0, A+1, A+2, A+3, B+0, B+1, C+0, C+1, C+2, C+3, D+0, D+1, D+2, D+3, E+0, E+1, F+0, F+1, F+2, F+3, G+0
	//A-3, A-2, A-1, A+0, B-3, B-2, B-1, B+0, C-1, C+0, D-3, D-2, D-1, D+0, E-3, E-2, E-1, E+0, F-1, F+0, G-3, G-2, G-1, G+0
	public enum BaseNote {
		A = 0, B = 1, C = 2, D = 3, E = 4, F = 5, G = 6
	}

	public enum Accidental {
		Natural = 0, HalfFlat = -1, Flat = -2, FlatAndHalf = -3, DoubleFlat = -4, HalfSharp = 1, Sharp = 2, SharpAndHalf = 3, DoubleSharp = 4
	}

	public static class NoteHelper {
		private const string Natural = "";
		private const string HalfFlat = "d";
		private const string Flat = "b";
		private const string FlatAndHalf = "db";
		private const string DoubleFlat = "bb";
		private const string HalfSharp = "]";
		private const string Sharp = "#";
		private const string SharpAndHalf = "]#";
		private const string DoubleSharp = "x";


		public static string ToString(Accidental self) {
			switch (self) {
			case Accidental.Natural:
				return Natural;
			case Accidental.HalfFlat:
				return HalfFlat;
			case Accidental.Flat:
				return Flat;
			case Accidental.FlatAndHalf:
				return FlatAndHalf;
			case Accidental.DoubleFlat:
				return DoubleFlat;
			case Accidental.HalfSharp:
				return HalfSharp;
			case Accidental.Sharp:
				return Sharp;
			case Accidental.SharpAndHalf:
				return SharpAndHalf;
			case Accidental.DoubleSharp:
				return DoubleSharp;
			default:
				throw new NotImplementedException ("Unknown Accidental of " + self);
			}
		}

		public static string ToString(BaseNote self) {
			switch (self) {
			case BaseNote.A:
				return "A";
			case BaseNote.B:
				return "B";
			case BaseNote.C:
				return "C";
			case BaseNote.D:
				return "D";
			case BaseNote.E:
				return "E";
			case BaseNote.F:
				return "F";
			case BaseNote.G:
				return "G";
			default:
				throw new NotImplementedException ("Unknown BaseNote of " + self);
			}
		}

		public static Accidental ParseAccidental(string text) {
			switch (text) {
			case Natural:
				return Accidental.Natural;
			case HalfFlat:
				return Accidental.HalfFlat;
			case Flat:
				return Accidental.Flat;
			case FlatAndHalf:
				return Accidental.FlatAndHalf;
			case DoubleFlat:
				return Accidental.DoubleFlat;
			case HalfSharp:
				return Accidental.HalfSharp;
			case Sharp:
				return Accidental.Sharp;
			case SharpAndHalf:
				return Accidental.SharpAndHalf;
			case DoubleSharp:
				return Accidental.DoubleSharp;
			default:
				throw new InvalidDataException ("Unable to parse text '" + text + "' to an accidental.");
			}
		}

		public static BaseNote ParseBaseNote(string text) {
			Debug.Assert (text.Length == 1, "Unable to parse text string " + text + " to single character");
			return ParseBaseNote (text[0]);
		}

		public static int ParseOctave(char text) {
			int octave = text - '0';
			if (octave < 0 || octave > 8) {
				throw new InvalidDataException ("Unable to parse text '" + text + "' to an octave. Value must between 0 and 8.");
			}
			return octave;
		}

		public static BaseNote ParseBaseNote(char text) {
			switch (text) {
			case 'A':
				return BaseNote.A;
			case 'B':
				return BaseNote.B;
			case 'C':
				return BaseNote.C;
			case 'D':
				return BaseNote.D;
			case 'E':
				return BaseNote.E;
			case 'F':
				return BaseNote.F;
			case 'G':
				return BaseNote.G;
			default:
				throw new InvalidDataException ("Unable to parse text '" + text + "' to a base note.");
			}
		}

		
	}
}