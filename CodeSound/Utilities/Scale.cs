using CodeSound.Pitch;

namespace CodeSound.Utilities {
	public static class Scale {
		public static QuarterToneScaleTuning BuildQuarterTone() {
			return new QuarterToneScaleTuning (Note.A (4), 440f, RawNote.C ());
		}
	}
}