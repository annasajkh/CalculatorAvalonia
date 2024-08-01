using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace CalculatorAvalonia.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public Stack<string> CurrentEquation { get; } = new();
        
        public string CurrentEquationStr
        {
           get => string.Join("", CurrentEquation.Reverse());
        }
        
        public string CurrentEquationStrDisplay
        {
            get => CurrentEquationStr.Replace("*", "x");
        }
        
        public string ResultEquationStr { get; set; }

        public void ResetResultEquation()
        {
            ResultEquationStr = "";
            ChangeResultEquation();
        }

        public void BeforeChangeEquation()
        {
            if (ResultEquationStr == "Error")
            {
                ResetResultEquation();
                return;
            }
            
            if (ResultEquationStr != "")
            {
                CurrentEquation.Push(ResultEquationStr);
                ResultEquationStr = "";
                ChangeResultEquation();
            }
        }
        
        public void ChangeEquation()
        {
            OnPropertyChanged(nameof(CurrentEquationStrDisplay));
        }
        
        public void ChangeResultEquation()
        {
            OnPropertyChanged(nameof(ResultEquationStr));
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
    }
}