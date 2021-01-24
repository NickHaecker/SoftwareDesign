using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
namespace TranslationMemory
{
    class System
    {
        private InterfaceUser _registeredUser = null;
        private UserFactory _userFactory = null;
        private TranslationFactory _translationFactory = null;
        private InputController _inputController = null;

        private bool test = false;

        public System()
        {
            _userFactory = new UserFactory();
            _translationFactory = new TranslationFactory();
            _inputController = new InputController();
        }
        private void RegisterUser()
        {

        }
        private void Login()
        {
            string username = _inputController.GetString("Bitte geben Sie ihren Benutzernamen ein: ");
            int password = _inputController.GetInt();
            _inputController.WriteString(username);
            _inputController.WriteInt(password);
            Database.Instance
        }
        public void HandleInput()
        {
            WelcomeView();
            int i = 0;
            while (test != true)
            {
                // Console.WriteLine("Main Programm");

                // if (i == 25)
                // {
                //     test = true;
                // }
                // i++;
            }

        }
        private void WelcomeView()
        {
            string answer = _inputController.GetString("Willst du dich Registrieren oder hast du bereits ein Konto bei uns? Tippe '/register' um dich zu registerieren oder '/login' um dich anzumelden.");
            _inputController.WriteString(answer);
            switch (answer)
            {
                case "/login":
                    Login();
                    break;
                case "/register":
                    RegisterUser();
                    break;
                default:
                    WelcomeView();
                    break;
            }
        }
        private void ShowUncompleteTranslatetWords()
        {

        }
    }
}