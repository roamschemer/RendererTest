using Prism.Navigation;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using RendererTest.Models;

namespace RendererTest.ViewModels {
    public class PageRendererTestPageViewModel : ViewModelBase {

        public ReactiveCommand<string> KeyDownCommand { get; }
        public ReadOnlyReactiveProperty<string> KeyHistory { get; }

        public PageRendererTestPageViewModel(INavigationService navigationService, CoreModel coreModel) : base(navigationService) {
            KeyHistory = coreModel.ObserveProperty(x => x.KeyHistory).ToReadOnlyReactiveProperty();
            KeyDownCommand = new ReactiveCommand<string>().WithSubscribe(x => coreModel.SetKeyHistory(x));
        }
    }
}
