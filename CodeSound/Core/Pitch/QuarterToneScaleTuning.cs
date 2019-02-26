namespace CodeSound.Pitch {
	//http://pages.mtu.edu/~suits/notefreqs.html
	public class QuarterToneScaleTuning : ScaleTuning {
		private static readonly int scaleSubdivisions = 24;

		public QuarterToneScaleTuning(Note frequencyPivot, float pivotFrequency, RawNote octaveRoot) : base () {
			int centerOctave = frequencyPivot.Octave,
				octaveRootIndex = octaveRoot.index,
				octaveRolloverIndex = frequencyPivot.Index;

			int stepSize = RawNote.Subdivisions / scaleSubdivisions;
			NoteIndex centerIndex = new NoteIndex (frequencyPivot);
			NoteIndex maxIndex = new NoteIndex (Note.TopOctave + 1, octaveRoot.index);
			NoteIndex minIndex = new NoteIndex (0, octaveRoot.index).Next (octaveRootIndex, stepSize - RawNote.Subdivisions);

			frequencies[centerIndex] = pivotFrequency;

			NoteIndex nextIndex = centerIndex.Next (octaveRootIndex, -stepSize);
			int i = -stepSize;
			do {
				frequencies[nextIndex] = CalculateEqualTemprementFrequency (pivotFrequency, i, RawNote.Subdivisions);

				nextIndex = nextIndex.Next (octaveRootIndex, -stepSize);
				i -= stepSize;
			} while (nextIndex > minIndex);

			nextIndex = centerIndex.Next (octaveRootIndex, stepSize);
			i = stepSize;
			do {
				frequencies[nextIndex] = CalculateEqualTemprementFrequency (pivotFrequency, i, RawNote.Subdivisions);

				nextIndex = nextIndex.Next (octaveRootIndex, stepSize);
				i += stepSize;
			} while (nextIndex < maxIndex);
		}
	}
}