using CodeSound.Pitch;
using NAudio.Wave.SampleProviders;

namespace CodeSound.Core.Instrument {
	public class PanFluteInstrument : AbstractMonophonicInstrument {
		public PanFluteInstrument(ScaleTuning scale, SignalGeneratorType waveType = SignalGeneratorType.Sin) : base(scale, waveType) {
		}
	}
}