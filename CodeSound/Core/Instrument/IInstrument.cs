using CodeSound.Pitch;
using CodeSound.Utilities;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;

namespace CodeSound.Core.Instrument {
	public static class Instrument {
		private static ScaleTuning _tuning;
		private static ScaleTuning Tuning {
			get {
				if (_tuning == null) {
					_tuning = Scale.CreateQuarterTone ();
				}
				return _tuning;
			}
		}

		public static IInstrument CreatePanFlute() {
			return new PanFluteInstrument (Tuning);
		}
	}

	public interface IInstrument {
		WaveOutEvent Play(Note note, float duration);
	}

	public abstract class AbstractPolyphonicInstrument : AbstractInstrument {
		protected readonly Queue<SignalGenerator> voices;

		protected override SignalGenerator Voice {
			get {
				SignalGenerator signal = this.voices.Dequeue ();
				this.voices.Enqueue (signal);
				return signal;
			}
		}

		public AbstractPolyphonicInstrument(ScaleTuning scale, int voices, SignalGeneratorType waveType) : base (scale) {
			this.voices = new Queue<SignalGenerator> (voices);
			for (int i = 0; i < voices; i++) {
				this.voices.Enqueue (new SignalGenerator () {
					Type = waveType
				});
			}
		}
	}

	public abstract class AbstractMonophonicInstrument : AbstractInstrument {
		protected SignalGenerator voice;
		protected override SignalGenerator Voice => voice;

		public AbstractMonophonicInstrument(ScaleTuning scale, SignalGeneratorType waveType) : base (scale) {
			voice = new SignalGenerator () {
				Type = waveType
			};
		}

	}

	public abstract class AbstractInstrument : IInstrument {
		protected ScaleTuning scale;

		protected abstract SignalGenerator Voice { get; }

		public AbstractInstrument(ScaleTuning scale) {
			this.scale = scale;
		}

		public virtual WaveOutEvent Play(Note note, float duration = 100f) {
			WaveOutEvent wo = new WaveOutEvent ();
			try {
				SignalGenerator signal = Voice;
				signal.Frequency = scale[note];
				wo.Init (signal.Take (TimeSpan.FromMilliseconds (duration)));
				wo.Play ();
				return wo;
			} catch (Exception e) {
				throw e;
			} finally {
				if (wo != null) {
					wo.Dispose ();
				}
			}
		}
	}

	public class SignalPlayer {
		public SignalGenerator Signal { get;}
		public WaveOutEvent Event { get; }
		public SignalPlayer(SignalGenerator generator, WaveOutEvent evnt) {
			Signal = generator;
			Event = evnt;
		}

		public void Play() {
			if(Event.PlaybackState == PlaybackState.Stopped) {

			}
		}
	}
}