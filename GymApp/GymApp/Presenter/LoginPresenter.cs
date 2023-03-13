using GymApp.Model;
using GymApp.View;
using System;

namespace GymApp.Presenter
{
    public class LoginPresenter
    {

        //Fields
        private ILoginView loginView;
        ILoginRepository loginRepository;

        //Constructor
        public LoginPresenter(ILoginView loginView, ILoginRepository loginRepository)
        {
            this.loginView = loginView;
            this.loginRepository = loginRepository;

            //Subscribe event handler methods to view events
            this.loginView.LoginEvent += LoginUser;
        }

        private void LoginUser(object sender, EventArgs e)
        {
            var model = new Login();
            model.Username = loginView.Username;
            model.Password = loginView.Password;
            try
            {
                new Common.ModelDataValidation().Validate(model);
                loginRepository.Login(model);
                loginView.IsSuccessful = model.IsSuccessful;
                loginView.Message = model.Message;
                loginView.IsAdmin = model.IsAdmin;
                if (model.IsAdmin)
                {

                }
            }
            catch (Exception)
            {
                loginView.IsSuccessful = false;
                loginView.Message = model.Message;
            }
        }

        private void ClearFields(object sender, EventArgs e)
        {
            loginView.Username = "";
            loginView.Password = "";

        }
    }
}
