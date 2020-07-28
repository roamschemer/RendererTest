using System;
using Xamarin.Forms;

namespace RendererTest.Renderers {

    public class ContentPageCS : ContentPage {

        public delegate void KeyDownEventHandler(object sender, KeyDownEventArgs e);
        public event KeyDownEventHandler KeyDown;

        public void OnKeyDown(KeyDownEventArgs e) => KeyDown?.Invoke(this, e);

    }
    public class KeyDownEventArgs : EventArgs {
        public string Key { get; set; }
    }

}
