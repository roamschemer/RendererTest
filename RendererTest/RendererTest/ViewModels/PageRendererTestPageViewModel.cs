using Prism.Navigation;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using RendererTest.Models;
using System;

namespace RendererTest.ViewModels {
    public class PageRendererTestPageViewModel : ViewModelBase {

        public ReactiveCommand<string> KeyDownCommand { get; }
        public ReadOnlyReactiveProperty<string> KeyHistory { get; }
        public ReactiveCommand CommandA { get; } = new ReactiveCommand();
        public ReactiveCommand CommandB { get; } = new ReactiveCommand();
        public ReactiveCommand CommandC { get; } = new ReactiveCommand();
        public ReadOnlyReactiveProperty<string> MethodHistory { get;}

        public PageRendererTestPageViewModel(INavigationService navigationService, CoreModel coreModel) : base(navigationService) {
            KeyHistory = coreModel.ObserveProperty(x => x.KeyHistory).ToReadOnlyReactiveProperty();
            KeyDownCommand = new ReactiveCommand<string>().WithSubscribe(x => coreModel.SetKeyHistory(x));

            MethodHistory = coreModel.ObserveProperty(x => x.MethodHistory).ToReadOnlyReactiveProperty();
            CommandA.Subscribe(_ => coreModel.MethodA());
            CommandB.Subscribe(_ => coreModel.MethodB());
            CommandC.Subscribe(_ => coreModel.MethodC());
        }
    }
}
