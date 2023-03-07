using CMS.MVVM.Model;
using desktop_translator.Core;

namespace CMS.MVVM.ViewModel
{
    class AddViewModel : ObservableObject
    {
        public double AddViewWidth { get; internal set; }

        private AddModel _addModel;

        public AddModel AddModel
        {
            get { return _addModel; }
            set
            {
                _addModel = value;
                OnPropertyChanged(nameof(AddModel));
            }
        }

        public AddViewModel()
        {
            _addModel = new AddModel();
        }

    }
}
