using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Input;
using Demo.DemoCBIA.Services;

namespace Demo.DemoCBIA.ViewModels
{

    public class LoginViewModel : BaseLoginViewModel
    {
        private readonly IAuthenticationService _authenticationService;
        bool passEntered = false;
        bool isLoginEnabled = false;
        string login = "";
        bool loginHasError = false;
        string password = "";
        bool passwordHasError = false;

        public LoginViewModel(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        public async Task<bool> AuthenticateAsync(string username, string password)
        {
            // Call authentication service and perform authentication logic
            // For example:
            bool isAuthenticated = await _authenticationService.AuthenticateAsync(username, Password);

            // Return authentication result
            return isAuthenticated;
        }

        public bool IsLoginEnabled
        {
            get { return this.isLoginEnabled; }
            set { SetProperty(ref this.isLoginEnabled, value); }
        }

        public string Login
        {
            get { return this.login; }
            set { SetProperty(ref this.login, value); }
        }

        public bool LoginHasError
        {
            get { return this.loginHasError; }
            set { SetProperty(ref this.loginHasError, value); }
        }

        public string Password
        {
            get { return this.password; }
            set { SetProperty(ref this.password, value); }
        }

        public bool PasswordHasError
        {
            get { return this.passwordHasError; }
            set { SetProperty(ref this.passwordHasError, value); }
        }

        public ICommand SignUpCommand { private set; get; }

        public bool ValidateEditors()
        {
            if (Password.Length < 6)
            {
                IsLoginEnabled = false;
            }
            if (Password.Length > 5)
            {
                this.passEntered = true;
            }
            if (!this.passEntered)
            {
                return true;
            }
            PasswordHasError = !Regex.IsMatch(Password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{5,}$");
            LoginHasError = String.IsNullOrEmpty(Login);
            if (!PasswordHasError && !LoginHasError)
            {
                IsLoginEnabled = true;
                return true;
            }
            else
            {
                IsLoginEnabled = false;
                return false;
            }
        }
    }
}
