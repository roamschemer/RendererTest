using Xamarin.Forms;

namespace RendererTest.Renderers {
    public class ContentPageCS : ContentPage {
        public void OnKeyDown(string key) {
            switch (key) {
                case "A":
                    // Aを入力した時の処理
                    break;
                case "B":
                    // Bを入力した時の処理
                    break;
            }
        }
    }
}
