using Prism.Mvvm;

namespace RendererTest.Models {
    public class CoreModel : BindableBase {
        public string KeyHistory { get => keyHistory; set => SetProperty(ref keyHistory, value); }
        private string keyHistory;

        public void SetKeyHistory(string key) {
            KeyHistory += key;
        }
    }
}
