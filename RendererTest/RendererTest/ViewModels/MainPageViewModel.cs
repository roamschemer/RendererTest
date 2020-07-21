using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RendererTest.ViewModels {
    public class MainPageViewModel : ViewModelBase {
        public ReactiveCommand<string> Navigation { get; }
        public MainPageViewModel(INavigationService navigationService) : base(navigationService) {
            Navigation = new ReactiveCommand<string>().WithSubscribe(async x => await navigationService.NavigateAsync(x));
        }
    }
}
