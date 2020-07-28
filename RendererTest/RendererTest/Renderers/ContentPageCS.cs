using System;
using Xamarin.Forms;

namespace RendererTest.Renderers {

    public class KeyDownEventArgs : EventArgs {
        /// <summary>押されたキー</summary>sya
        public string Key { get; set; }
    }

    public class ContentPageCS : ContentPage {

        public delegate void KeyDownEventHandler(object sender, KeyDownEventArgs e);
        public event KeyDownEventHandler KeyDown;

        public void OnKeyDown(KeyDownEventArgs e) => KeyDown?.Invoke(this, e);

    }
}
