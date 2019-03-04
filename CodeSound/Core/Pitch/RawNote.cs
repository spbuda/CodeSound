using CodeSound.Utilities;
using System;

namespace CodeSound.Pitch {
	public struct RawNote {
		public readonly BaseNote note;
		public readonly Accidental accidental;
		public readonly int index;

		private RawNote(int i, BaseNote n, Accidental a = Accidental.Natural) {
			index = i;
			note = n;
			accidental = a;
		}

		public static RawNote Create(BaseNote n, Accidental a = Accidental.Natural) {
			switch (n) {
			case BaseNote.A:
				return RawNote.A (a);
			case BaseNote.B:
				return RawNote.B (a);
			case BaseNote.C:
				return RawNote.C (a);
			case BaseNote.D:
				return RawNote.D (a);
			case BaseNote.E:
				return RawNote.E (a);
			case BaseNote.F:
				return RawNote.F (a);
			case BaseNote.G:
				return RawNote.G (a);
			default:
				throw new NotImplementedException ("Missing note " + n);
			}
		}

		public static RawNote A(Accidental a = Accidental.Natural) {
			switch (a) {
			case Accidental.Natural:
				return new RawNote (Index.A, BaseNote.A, a);
			case Accidental.HalfFlat:
				return new RawNote (Index.Ad, BaseNote.A, a);
			case Accidental.Flat:
				return new RawNote (Index.Ab, BaseNote.A, a);
			case Accidental.FlatAndHalf:
				return new RawNote (Index.Adb, BaseNote.A, a);
			case Accidental.DoubleFlat:
				return new RawNote (Index.Abb, BaseNote.A, a);
			case Accidental.HalfSharp:
				return new RawNote (Index.At, BaseNote.A, a);
			case Accidental.Sharp:
				return new RawNote (Index.As, BaseNote.A, a);
			case Accidental.SharpAndHalf:
				return new RawNote (Index.Ats, BaseNote.A, a);
			case Accidental.DoubleSharp:
				return new RawNote (Index.Ass, BaseNote.A, a);
			default:
				throw new NotImplementedException ("Missing accidental " + a);
			}
		}

		public static RawNote B(Accidental a = Accidental.Natural) {
			switch (a) {
			case Accidental.Natural:
				return new RawNote (Index.B, BaseNote.B, a);
			case Accidental.HalfFlat:
				return new RawNote (Index.Bd, BaseNote.B, a);
			case Accidental.Flat:
				return new RawNote (Index.Bb, BaseNote.B, a);
			case Accidental.FlatAndHalf:
				return new RawNote (Index.Bdb, BaseNote.B, a);
			case Accidental.DoubleFlat:
				return new RawNote (Index.Bbb, BaseNote.B, a);
			case Accidental.HalfSharp:
				return new RawNote (Index.Bt, BaseNote.B, a);
			case Accidental.Sharp:
				return new RawNote (Index.Bs, BaseNote.B, a);
			case Accidental.SharpAndHalf:
				return new RawNote (Index.Bts, BaseNote.B, a);
			case Accidental.DoubleSharp:
				return new RawNote (Index.Bss, BaseNote.B, a);
			default:
				throw new NotImplementedException ("Missing accidental " + a);
			}
		}

		public static RawNote C(Accidental a = Accidental.Natural) {
			switch (a) {
			case Accidental.Natural:
				return new RawNote (Index.C, BaseNote.C, a);
			case Accidental.HalfFlat:
				return new RawNote (Index.Cd, BaseNote.C, a);
			case Accidental.Flat:
				return new RawNote (Index.Cb, BaseNote.C, a);
			case Accidental.FlatAndHalf:
				return new RawNote (Index.Cdb, BaseNote.C, a);
			case Accidental.DoubleFlat:
				return new RawNote (Index.Cbb, BaseNote.C, a);
			case Accidental.HalfSharp:
				return new RawNote (Index.Ct, BaseNote.C, a);
			case Accidental.Sharp:
				return new RawNote (Index.Cs, BaseNote.C, a);
			case Accidental.SharpAndHalf:
				return new RawNote (Index.Cts, BaseNote.C, a);
			case Accidental.DoubleSharp:
				return new RawNote (Index.Css, BaseNote.C, a);
			default:
				throw new NotImplementedException ("Missing accidental " + a);
			}
		}

		public static RawNote D(Accidental a = Accidental.Natural) {
			switch (a) {
			case Accidental.Natural:
				return new RawNote (Index.D, BaseNote.D, a);
			case Accidental.HalfFlat:
				return new RawNote (Index.Dd, BaseNote.D, a);
			case Accidental.Flat:
				return new RawNote (Index.Db, BaseNote.D, a);
			case Accidental.FlatAndHalf:
				return new RawNote (Index.Ddb, BaseNote.D, a);
			case Accidental.DoubleFlat:
				return new RawNote (Index.Dbb, BaseNote.D, a);
			case Accidental.HalfSharp:
				return new RawNote (Index.Dt, BaseNote.D, a);
			case Accidental.Sharp:
				return new RawNote (Index.Ds, BaseNote.D, a);
			case Accidental.SharpAndHalf:
				return new RawNote (Index.Dts, BaseNote.D, a);
			case Accidental.DoubleSharp:
				return new RawNote (Index.Dss, BaseNote.D, a);
			default:
				throw new NotImplementedException ("Missing accidental " + a);
			}
		}

		public static RawNote E(Accidental a = Accidental.Natural) {
			switch (a) {
			case Accidental.Natural:
				return new RawNote (Index.E, BaseNote.E, a);
			case Accidental.HalfFlat:
				return new RawNote (Index.Ed, BaseNote.E, a);
			case Accidental.Flat:
				return new RawNote (Index.Eb, BaseNote.E, a);
			case Accidental.FlatAndHalf:
				return new RawNote (Index.Edb, BaseNote.E, a);
			case Accidental.DoubleFlat:
				return new RawNote (Index.Ebb, BaseNote.E, a);
			case Accidental.HalfSharp:
				return new RawNote (Index.Et, BaseNote.E, a);
			case Accidental.Sharp:
				return new RawNote (Index.Es, BaseNote.E, a);
			case Accidental.SharpAndHalf:
				return new RawNote (Index.Ets, BaseNote.E, a);
			case Accidental.DoubleSharp:
				return new RawNote (Index.Ess, BaseNote.E, a);
			default:
				throw new NotImplementedException ("Missing accidental " + a);
			}
		}

		public static RawNote F(Accidental a = Accidental.Natural) {
			switch (a) {
			case Accidental.Natural:
				return new RawNote (Index.F, BaseNote.F, a);
			case Accidental.HalfFlat:
				return new RawNote (Index.Fd, BaseNote.F, a);
			case Accidental.Flat:
				return new RawNote (Index.Fb, BaseNote.F, a);
			case Accidental.FlatAndHalf:
				return new RawNote (Index.Fdb, BaseNote.F, a);
			case Accidental.DoubleFlat:
				return new RawNote (Index.Fbb, BaseNote.F, a);
			case Accidental.HalfSharp:
				return new RawNote (Index.Ft, BaseNote.F, a);
			case Accidental.Sharp:
				return new RawNote (Index.Fs, BaseNote.F, a);
			case Accidental.SharpAndHalf:
				return new RawNote (Index.Fts, BaseNote.F, a);
			case Accidental.DoubleSharp:
				return new RawNote (Index.Fss, BaseNote.F, a);
			default:
				throw new NotImplementedException ("Missing accidental " + a);
			}
		}

		public static RawNote G(Accidental a = Accidental.Natural) {
			switch (a) {
			case Accidental.Natural:
				return new RawNote (Index.G, BaseNote.G, a);
			case Accidental.HalfFlat:
				return new RawNote (Index.Gd, BaseNote.G, a);
			case Accidental.Flat:
				return new RawNote (Index.Gb, BaseNote.G, a);
			case Accidental.FlatAndHalf:
				return new RawNote (Index.Gdb, BaseNote.G, a);
			case Accidental.DoubleFlat:
				return new RawNote (Index.Gbb, BaseNote.G, a);
			case Accidental.HalfSharp:
				return new RawNote (Index.Gt, BaseNote.G, a);
			case Accidental.Sharp:
				return new RawNote (Index.Gs, BaseNote.G, a);
			case Accidental.SharpAndHalf:
				return new RawNote (Index.Gts, BaseNote.G, a);
			case Accidental.DoubleSharp:
				return new RawNote (Index.Gss, BaseNote.G, a);
			default:
				throw new NotImplementedException ("Missing accidental " + a);
			}
		}

		public override bool Equals(object obj) {
			if (!(obj is RawNote)) {
				return false;
			}

			var note = (RawNote) obj;
			return this.note == note.note &&
				   accidental == note.accidental;
		}

		public override int GetHashCode() {
			return HashCode.Combine (note, accidental);
		}

		public override string ToString() {
			return note.ToString () + accidental.ToString ();
		}

		public const int Subdivisions = 24;
		public static RawNote Create(int index) {
			switch (index) {
			case 0:
				return Const.Adb;
			case 1:
				return Const.Ab;
			case 2:
				return Const.Ad;
			case 3:
				return Const.A;
			case 4:
				return Const.Bdb;
			case 5:
				return Const.Bb;
			case 6:
				return Const.Bd;
			case 7:
				return Const.B;
			case 8:
				return Const.Cd;
			case 9:
				return Const.C;
			case 10:
				return Const.Ddb;
			case 11:
				return Const.Db;
			case 12:
				return Const.Dd;
			case 13:
				return Const.D;
			case 14:
				return Const.Edb;
			case 15:
				return Const.Eb;
			case 16:
				return Const.Ed;
			case 17:
				return Const.E;
			case 18:
				return Const.Fd;
			case 19:
				return Const.F;
			case 20:
				return Const.Bdb;
			case 21:
				return Const.Gb;
			case 22:
				return Const.Bd;
			case 23:
				return Const.G;
			default:
				throw new IndexOutOfRangeException ("Requested index " + index + " must be between 0 and 23.");
			}
		}

		public static class Const {
			public static readonly RawNote Adb = RawNote.A (Accidental.FlatAndHalf);
			public static readonly RawNote Ab = RawNote.A (Accidental.Flat);
			public static readonly RawNote Ad = RawNote.A (Accidental.HalfFlat);
			public static readonly RawNote A = RawNote.A ();
			public static readonly RawNote Bdb = RawNote.B (Accidental.FlatAndHalf);
			public static readonly RawNote Bb = RawNote.B (Accidental.Flat);
			public static readonly RawNote Bd = RawNote.B (Accidental.HalfFlat);
			public static readonly RawNote B = RawNote.B ();
			public static readonly RawNote Cd = RawNote.C (Accidental.HalfFlat);
			public static readonly RawNote C = RawNote.C ();
			public static readonly RawNote Ddb = RawNote.D (Accidental.FlatAndHalf);
			public static readonly RawNote Db = RawNote.D (Accidental.Flat);
			public static readonly RawNote Dd = RawNote.D (Accidental.HalfFlat);
			public static readonly RawNote D = RawNote.D ();
			public static readonly RawNote Edb = RawNote.E (Accidental.FlatAndHalf);
			public static readonly RawNote Eb = RawNote.E (Accidental.Flat);
			public static readonly RawNote Ed = RawNote.E (Accidental.HalfFlat);
			public static readonly RawNote E = RawNote.E ();
			public static readonly RawNote Fd = RawNote.F (Accidental.HalfFlat);
			public static readonly RawNote F = RawNote.F ();
			public static readonly RawNote Gdb = RawNote.G (Accidental.FlatAndHalf);
			public static readonly RawNote Gb = RawNote.G (Accidental.Flat);
			public static readonly RawNote Gd = RawNote.G (Accidental.HalfFlat);
			public static readonly RawNote G = RawNote.G ();

			public static RawNote Bbb => A;
			public static RawNote Cb => B;
			public static RawNote Cdb => Bd;
			public static RawNote Cbb => Bb;
			public static RawNote Dbb => C;
			public static RawNote Ebb => D;
			public static RawNote Abb => G;
			public static RawNote Fbb = Eb;
			public static RawNote Fdb = Ed;
			public static RawNote Fb => E;
			public static RawNote Gbb => F;
			public static RawNote At => Bdb;
			public static RawNote As => Bb;
			public static RawNote Ats => Bd;
			public static RawNote Ass => B;
			public static RawNote Bt => Cd;
			public static RawNote Bs => C;
			public static RawNote Bts => Edb;
			public static RawNote Bss => Db;
			public static RawNote Ct => Ddb;
			public static RawNote Cs => Db;
			public static RawNote Cts => Dd;
			public static RawNote Css => D;
			public static RawNote Dt => Edb;
			public static RawNote Ds => Eb;
			public static RawNote Dts => Ed;
			public static RawNote Dss => E;
			public static RawNote Et => Fd;
			public static RawNote Es => F;
			public static RawNote Ets => Gdb;
			public static RawNote Ess => Gb;
			public static RawNote Ft => Gdb;
			public static RawNote Fs => Gb;
			public static RawNote Fts => Gd;
			public static RawNote Fss => G;
			public static RawNote Gt => Adb;
			public static RawNote Gs => Ab;
			public static RawNote Gts => Ad;
			public static RawNote Gss => A;
		}

		public static class Index {
			public const int Adb = 0;
			public const int Gt = Adb;

			public const int Ab = 1;
			public const int Gs = Ab;

			public const int Ad = 2;
			public const int Gts = Ad;

			public const int A = 3;
			public const int Bbb = A;
			public const int Gss = A;

			public const int Bdb = 4;
			public const int At = Bdb;

			public const int Bb = 5;
			public const int As = Bb;
			public const int Cbb = Bb;

			public const int Bd = 6;
			public const int Ats = Bd;
			public const int Cdb = Bd;

			public const int B = 7;
			public const int Ass = B;
			public const int Cb = B;

			public const int Cd = 8;
			public const int Bt = Cd;

			public const int C = 9;
			public const int Bs = C;
			public const int Dbb = C;

			public const int Ddb = 10;
			public const int Ct = Ddb;

			public const int Db = 11;
			public const int Bss = Db;
			public const int Cs = Db;

			public const int Dd = 12;
			public const int Cts = Dd;

			public const int D = 13;
			public const int Css = D;
			public const int Ebb = D;

			public const int Edb = 14;
			public const int Bts = Edb;
			public const int Dt = Edb;

			public const int Eb = 15;
			public const int Fbb = Eb;
			public const int Ds = Eb;

			public const int Ed = 16;
			public const int Dts = Ed;
			public const int Fdb = Ed;

			public const int E = 17;
			public const int Dss = E;
			public const int Fb = E;

			public const int Fd = 18;
			public const int Et = Fd;

			public const int F = 19;
			public const int Es = F;
			public const int Gbb = F;

			public const int Gdb = 20;
			public const int Ets = Gdb;
			public const int Ft = Gdb;

			public const int Gb = 21;
			public const int Ess = Gb;
			public const int Fs = Gb;

			public const int Gd = 22;
			public const int Fts = Gd;

			public const int G = 23;
			public const int Abb = G;
			public const int Fss = G;
		}
	}
}