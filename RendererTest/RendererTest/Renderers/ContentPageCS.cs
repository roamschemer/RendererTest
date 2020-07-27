using System;
using Xamarin.Forms;

namespace RendererTest.Renderers {

    public class OnKeyDownEventArgs : EventArgs {
        /// <summary>押されたキー</summary>
        public string key;
    }

    public class ContentPageCS : ContentPage {

        public delegate void OnKeyDownEventHandler(object sender, OnKeyDownEventArgs e);
        public event OnKeyDownEventHandler KeyDown;

        public void OnKeyDown(OnKeyDownEventArgs e) {
            KeyDown?.Invoke(this, e);
        }
    }
}
