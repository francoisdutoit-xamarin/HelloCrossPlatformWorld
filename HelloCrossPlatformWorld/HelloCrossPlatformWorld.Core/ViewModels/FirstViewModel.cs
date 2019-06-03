using MvvmCross.Core.ViewModels;
using Plugin.TextToSpeech.Abstractions;
using System.Windows.Input;

namespace HelloCrossPlatformWorld.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        string name = "";
        public string Name { get { return name; } set { SetProperty(ref name, value); }}
        readonly ITextToSpeech textToSpeech;
        public ICommand SayHelloCommand { get; private set; }

        public FirstViewModel(ITextToSpeech textToSpeech) {

            this.textToSpeech = textToSpeech;
            SayHelloCommand = new MvxCommand(SayHello);
        }
        void SayHello() {
            textToSpeech.Speak($"Hello {Name}");
        }
    }
}
