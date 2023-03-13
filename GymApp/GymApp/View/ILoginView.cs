using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.View
{
    public interface ILoginView
    {
        //Fields and Properties
        string Username { get; set; }
        string Password { get; set; }
        string Message { get; set; }
        bool IsSuccessful { get; set; }
        bool IsAdmin { get; set; }

        //Events
        event EventHandler LoginEvent;

        //Methods
        void ShowPassword();
        void ClearFields();
        void Show();
    }
}
