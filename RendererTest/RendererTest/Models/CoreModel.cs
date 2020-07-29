using Prism.Mvvm;

namespace RendererTest.Models {
    public class CoreModel : BindableBase {
        public string KeyHistory { get => keyHistory; set => SetProperty(ref keyHistory, value); }
        private string keyHistory;

        public string MethodHistory { get => methodHistory; set => SetProperty(ref methodHistory, value); }
        private string methodHistory;


        public void SetKeyHistory(string key) {
            KeyHistory += key;
            if (key == "A") MethodA();
            if (key == "B") MethodB();
            if (key == "C") MethodC();
        }

        public void MethodA() => MethodHistory += "Method A を実行しました。\n";
        public void MethodB() => MethodHistory += "Method B を実行しました。\n";
        public void MethodC() => MethodHistory += "Method C を実行しました。\n";
    }
}
