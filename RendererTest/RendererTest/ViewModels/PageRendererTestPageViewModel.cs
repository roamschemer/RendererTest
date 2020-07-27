using Prism.Commands;
using Prism.Mvvm;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace RendererTest.ViewModels {
    public class PageRendererTestPageViewModel : BindableBase {

        public ReactiveProperty<string> DownKey { get; } = new ReactiveProperty<string>(mode: ReactivePropertyMode.RaiseLatestValueOnSubscribe);
        public ReactiveProperty<string> DownKeyLabel { get; } = new ReactiveProperty<string>();

        public PageRendererTestPageViewModel() {
            DownKey.Subscribe(x => {
                if (!string.IsNullOrEmpty(x)) {
                    DownKeyLabel.Value = DownKeyLabel.Value + x;
                }
            });
        }
    }
}
