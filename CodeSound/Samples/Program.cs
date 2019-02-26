using CodeSound;
using CodeSound.Pitch;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Threading;

namespace CodeSound.Samples {
	internal class Program {
		private static void Main(string[] args) {
			ScaleTuning scale = Scale.BuildQuarterTone ();
			var test = new SignalGenerator () {
				Frequency = scale[Note.A(4)],
				Type = SignalGeneratorType.Sin
			};
			using (var wo = new WaveOutEvent ()) {
				Thread.Sleep (5000);
				wo.Init (test.Take (TimeSpan.FromSeconds (10)));
				wo.Play ();
				test.Frequency = scale[Note.A (4)];
				Thread.Sleep (500);
				test.Frequency = scale[Note.A (4, Accidental.HalfSharp)];
				Thread.Sleep (500);
				test.Frequency = scale[Note.A (4, Accidental.Sharp)];
				Thread.Sleep (500);
				test.Frequency = scale[Note.A (4, Accidental.SharpAndHalf)];
				Thread.Sleep (500);
				test.Frequency = scale[Note.B (4, Accidental.Natural)];
				Thread.Sleep (500);
				test.Frequency = scale[Note.B (4, Accidental.HalfSharp)];
				Thread.Sleep (500);
				test.Frequency = scale[Note.C (5, Accidental.Natural)];
				Thread.Sleep (500);
			}
		}
	}
}