using CodeSound.Pitch;

namespace CodeSound.Utilities {
	public static class Scale {
		public static QuarterToneScaleTuning CreateQuarterTone() {
			return new QuarterToneScaleTuning (Note.A (4), 440f, RawNote.C ());
		}
	}
}