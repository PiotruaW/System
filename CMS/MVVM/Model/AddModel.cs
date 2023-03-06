using desktop_translator.Core;
using System;

namespace CMS.MVVM.Model
{
    class AddModel : ObservableObject
    {
        private string _owner;
        public string Owner
        {
            get { return _owner; }
            set
            {
                _owner = value;
                OnPropertyChanged(nameof(Owner));
                Console.WriteLine("Owner value = " + Owner);
            }
        }

        private string _department;
        public string Department
        {
            get { return _department; }
            set
            {
                _department = value;
                OnPropertyChanged(nameof(Department));
                Console.WriteLine("Department value = " + Department);
            }
        }

        private string _type;
        public string Type
        {
            get { return _type; }
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
                Console.WriteLine("Type value = " + Type);
            }
        }

        private string _mark;
        public string Mark
        {
            get { return _mark; }
            set
            {
                _mark = value;
                OnPropertyChanged(nameof(Mark));
                Console.WriteLine("Mark value = " + Mark);
            }
        }

        private string _model;
        public string Model
        {
            get { return _model; }
            set
            {
                _model = value;
                OnPropertyChanged(nameof(Model));
                Console.WriteLine("Model value = " + Model);
            }
        }

        private string _registrationPlate;
        public string RegistrationPlate
        {
            get { return _registrationPlate; }
            set
            {
                _registrationPlate = value;
                OnPropertyChanged(nameof(RegistrationPlate));
                Console.WriteLine("RegistrationPlate value = " + RegistrationPlate);
            }
        }

        private string _prodYear;
        public string ProdYear
        {
            get { return _prodYear; }
            set
            {
                _prodYear = value;
                OnPropertyChanged(nameof(ProdYear));
                Console.WriteLine("ProdYear value = " + ProdYear);
            }
        }

        private string _mileage;
        public string Mileage
        {
            get { return _mileage; }
            set
            {
                _mileage = value;
                OnPropertyChanged(nameof(Mileage));
                Console.WriteLine("MileAge value = " + Mileage);
            }
        }
    }
}