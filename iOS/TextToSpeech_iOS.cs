using Xamarin.Forms;
using MasterDetail.iOS;
using MonoTouch.AVFoundation;

[assembly: Dependency(typeof(TextToSpeech_iOS))]

namespace MasterDetail.iOS
{
	public class TextToSpeech_iOS : ITextToSpeech
	{

		public void Speak(string text)
		{
			var speechSynthesizer = new AVSpeechSynthesizer();

			var speechUtterance = new AVSpeechUtterance(text)
			{
				Rate = AVSpeechUtterance.MaximumSpeechRate / 4,
				Voice = AVSpeechSynthesisVoice.FromLanguage("en-US"),
				Volume = 0.5f,
				PitchMultiplier = 1.0f
			};

			speechSynthesizer.SpeakUtterance(speechUtterance);
		}
	}
}

