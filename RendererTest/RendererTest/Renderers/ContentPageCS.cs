using Xamarin.Forms;

namespace RendererTest.Renderers {
    public class ContentPageCS : ContentPage {

        public static readonly BindableProperty DownKeyProperty =
            BindableProperty.Create(nameof(DownKey), //名前
                                    typeof(string),　//型
                                    typeof(ContentPageCS), //自クラス
                                    string.Empty,    //初期値
                                    propertyChanged: (bindable, oldValue, newValue) => //変更があったことを感知するイベントハンドラ
                                    {
                                        ((ContentPageCS)bindable).DownKey = newValue;
                                    },
                                    defaultBindingMode: BindingMode.TwoWay); //初期バインディング方向
        public object DownKey {
            get => GetValue(DownKeyProperty);
            set => SetValue(DownKeyProperty, value);
        }

        public void OnKeyDown(string key) {
            DownKey = key;
            DownKey = string.Empty;
        }
    }
}
