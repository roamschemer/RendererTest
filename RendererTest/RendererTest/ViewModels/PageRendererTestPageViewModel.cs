using Prism.Commands;
using Prism.Mvvm;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using Xamarin.Forms;

namespace RendererTest.ViewModels {
    public class PageRendererTestPageViewModel : BindableBase {

        public ReactiveCommand<string> KeyDownCommand { get; }
        public ReactiveProperty<string> Key { get; } = new ReactiveProperty<string>();

        public PageRendererTestPageViewModel() {
            KeyDownCommand = new ReactiveCommand<string>().WithSubscribe(x => Key.Value = Key.Value + x);

        }
    }
}
