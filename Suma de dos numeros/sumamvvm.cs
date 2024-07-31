using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace Suma_de_dos_numeros
{
    partial class sumamvvm : ObservableObject
    {
        [ObservableProperty]
        public string number1;

        [ObservableProperty]
        public string number2;

        [ObservableProperty]
        public string result;

        [RelayCommand]
        private void OnSuma()
        {
            if (double.TryParse(Number1, out double num1) && double.TryParse(Number2, out double num2))
            {
                Result = (num1 + num2).ToString();
            }
            else
            {
                Result = "Entrada no válida";
            }
        }



    }
}