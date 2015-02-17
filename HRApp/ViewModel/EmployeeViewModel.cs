using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using HRApp.Data;
using HRApp.Model;

namespace HRApp.ViewModel
{
    class EmployeeViewModel : ViewModelBase
    {


        private EmployeeModel _employeeModel;

        public EmployeeViewModel(EmployeeModel employeeModel)
        {
            _employeeModel = employeeModel;
        }

        public int SliderValue
        {
            get { return _sliderValue; }
            set
            {
                _sliderValue = value;
                OnPropertyChanged("SliderValue");
            }
        }

        public bool IsUserNotLogged
        {
            get { return _isUserNotLogged; }
            set
            {
                _isUserNotLogged = value;
                OnPropertyChanged("IsUserNotLogged");
            }
        }


        public bool IsUserLogged
        {
            get { return _isUserLoged; }
            set
            {
                _isUserLoged = value;
                OnPropertyChanged("IsUserLogged");
            }
        }

        public KeyValuePair<String, int>[] ChartValuePairs
        {
            get { return _chartKeyValuePairs; }
            set
            {
                _chartKeyValuePairs = value;
                OnPropertyChanged("ChartValuePairs");
            }
        }





        public string Nick
        {
            get { return Login.NickName; }
            set
            {
                Login.NickName = value;
                OnPropertyChanged("Nick");
            }
        }

        public string Password
        {
            get { return Login.Password; }
            set
            {
                Login.Password = value;
                OnPropertyChanged("Password");
            }
        }

        public int UserId
        {
            get { return Login.UserId; }
            set
            {
                Login.UserId = value;
                OnPropertyChanged("UserId");
            }
        }

        #region Commands

        #region




        private void LogIn(string login, string password)
        {

            if (UserId != -1)
            {
                IsUserLogged = false;
                IsUserNotLogged = true;
            }
            else
            {


                Password = "";
            }
        }

        #endregion












        #endregion



    }
}
