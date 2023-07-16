using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project_1
{
    public partial class MWindowVM:ObservableObject
    {
        public string Message { get; set; }

        public MWindowVM(string message)
        {
            Message = message;
        }
        public MWindowVM()
        {

        }
    }
}
