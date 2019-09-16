using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace FinanceTrackerLib.Model
{
    public class FinanceAccount : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private double _currentBalance;

        public double CurrentBalance
        {
            get { return _currentBalance; }
            set
            {
                _currentBalance = value;
                NotifyPropertyChanged();
            }
        }

        public string Name { get; set; }


        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
