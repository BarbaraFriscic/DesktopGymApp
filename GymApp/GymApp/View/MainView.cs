using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymApp.View
{
    public partial class MainView : Form, IMainView
    {
        //Fields
        private bool isAdmin;

        //Constructor
        public MainView(bool isAdmin)
        {
            InitializeComponent();
            

            if(isAdmin)
            {
                AssociateAndRaiseViewEvents();
            }
            else
            {
                btnEmployeeView.Hide();
                btnEmployeeView.Enabled = false;
                AssociateAndRaiseViewEvents();
            }
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnLocationView.Click += delegate { LocationViewEvent?.Invoke(this, EventArgs.Empty); };
            btnMemberView.Click += delegate { MembersViewEvent?.Invoke(this, EventArgs.Empty); };
            btnPlansView.Click += delegate { MembershipPlansViewEvent?.Invoke(this, EventArgs.Empty); };
            btnEmployeeView.Click += delegate { EmployeesViewEvent?.Invoke(this, EventArgs.Empty); };
        }

        //Properties
        public string User
        {
            get { return lblWelcome.Text; }
            set { lblWelcome.Text = value; }
        }
        //Events
        public event EventHandler LocationViewEvent;
        public event EventHandler MembersViewEvent;
        public event EventHandler MembershipPlansViewEvent;
        public event EventHandler EmployeesViewEvent;
    }
}
