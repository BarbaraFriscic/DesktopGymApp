using GymApp.Presenter;
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
    public partial class LoginView : Form, ILoginView
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isAdmin;
        private MainPresenter _mainPresenter;
        private IMainView _mainView;

        public LoginView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();


        }

        private void AssociateAndRaiseViewEvents()
        {
            //Login
            btnLogin.Click += delegate
            {
                LoginEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {

                    _mainView = new MainView(isAdmin);
                    _mainPresenter = new MainPresenter(_mainView);
                    _mainView.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Invalid Login Credentials!");
                ClearFields();
            };

            //Clear
            btnClear.Click += delegate
            {
                ClearFields();
            };

            //ShowPassword
            ckbShowPassword.CheckedChanged += delegate
            {
                if (ckbShowPassword.Checked)
                    ShowPassword();
                else
                    txtPassword.PasswordChar = '*';
            };
        }


        //Properties
        public string Username
        {
            get { return txtUsername.Text; }
            set { txtUsername.Text = value; }
        }

        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }

        public bool IsAdmin
        {
            get { return isAdmin; }
            set { isAdmin = value; }
        }

        //Events
        public event EventHandler LoginEvent;

        //Methods
        public void ShowPassword()
        {
            txtPassword.PasswordChar = '\0';
        }

        public void ClearFields()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            ckbShowPassword.Checked = false;
        }
    }
}
