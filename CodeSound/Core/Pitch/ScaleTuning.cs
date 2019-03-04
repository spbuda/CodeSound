using System;
using System.Collections.Generic;

namespace CodeSound.Pitch {
	public abstract class ScaleTuning {
		protected readonly Dictionary<NoteIndex, float> frequencies = new Dictionary<NoteIndex, float> ();
		protected int TopOctave => 8;
		protected int RawSubdivisions => 24;

		public ScaleTuning() {
		}

		public virtual float this[Note note] {
			get {
				return frequencies[new NoteIndex (note)];
			}
			protected set {
				frequencies[new NoteIndex (note)] = value;
			}
		}

		public virtual float this[int octave, int index] {
			get {
				return frequencies[new NoteIndex (octave, index)];
			}
			protected set {
				frequencies[new NoteIndex (octave, index)] = value;
			}
		}

		public virtual float this[NoteIndex index] {
			get {
				return frequencies[index];
			}
			protected set {
				frequencies[index] = value;
			}
		}

		/// http://pages.mtu.edu/~suits/NoteFreqCalcs.html
		protected float CalculateEqualTemprementFrequency(float fixedCenter, int stepsFromFixedCenter, int octaveSubdivisions) {
			float subdivisionRoot = 1f / octaveSubdivisions;
			float a = MathF.Pow (2f, subdivisionRoot);
			return fixedCenter * MathF.Pow(a, stepsFromFixedCenter);
		}
	}

	public class FrequencyOutOfOctaveException : System.Exception {
		public FrequencyOutOfOctaveException(string message) : base (message) {
		}
	}
}