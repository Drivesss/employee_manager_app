using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_manager_app.Models
{
    internal class applicant : INotifyPropertyChanged
    {
        private string _lastname;

        public string LastName
        {
            get { return _lastname; }
            set
            {
                if (_lastname == value)
                {
                    return;
                }
                _lastname = value;
                OnPropertyChanged("LastName");
            }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                if (_name == value)
                {
                    return;
                }
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        private string _middleName;

        public string MiddleName
        {
            get { return _middleName; }
            set
            {
                if (_middleName == value)
                {
                    return;
                }
                _middleName = value;
                OnPropertyChanged("MiddleName");
            }
        }

        private DateTime _dateOfBirth;

        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set
            {
                if (_dateOfBirth == value)
                {
                    return;
                }
                _dateOfBirth = value;
                OnPropertyChanged("DateOfBirth");
            }
        }

        private string _education;

        public string Education
        {
            get { return _education; }
            set
            {
                if (_education == value)
                {
                    return;
                }
                _education = value;
                OnPropertyChanged("Education");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

        }
    }

}
