using Gatonini.BaseVM;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gatonini.Models
{
    public class UploadDetails : BaseViewModel
    {
        private int percenage;
        public int Percentage
        {
            get => percenage;
            set
            {
                if (percenage == value)
                    return;
                percenage = value;
                OnPropertyChanged();
            }
        }

        private string url;
        public string Url
        {
            get => url;
            set
            {
                if (url == value)
                    return;
                url = value;

                OnPropertyChanged();
            }
        }
        public ExecptionModel Execption { get; set; }
    }
}
