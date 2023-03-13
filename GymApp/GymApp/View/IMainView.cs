using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.View
{
    public interface IMainView
    {
        //Fields and Properties
        string User { get; set; }

        //Events
        event EventHandler LocationViewEvent;
        event EventHandler MembersViewEvent;
        event EventHandler MembershipPlansViewEvent;
        event EventHandler EmployeesViewEvent;

        //Methodes
        void Show();
    }
}
