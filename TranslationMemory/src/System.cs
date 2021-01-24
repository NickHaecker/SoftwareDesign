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

        // private bool test = false;

        public System()
        {
            _userFactory = new UserFactory();
            _translationFactory = new TranslationFactory();
            _inputController = new InputController();
        }
        private void RegisterUser()
        {
            string username = _inputController.GetString("Bitte erstellen sie ihren Benutzernamen: ");
            int password = _inputController.GetInt();
            // Database.Instance.
        }
        private void EnterAsUser()
        {
            string answer = _inputController.GetString("Bitte geben sie ihr geschlecht ein. Sie können wählen zwischen 'Male', 'Female' oder 'Divers'");
            // string answer = "Male";
            if (answer.ToUpper() != _inputController.GetGender(answer).ToString())
            {
                Console.WriteLine("Tut mir leid, aber ihre Eingabe war leider nicht richtig");
                EnterAsUser();
            }
            Role role = Role.USER;
            Gender gender = _inputController.GetGender(answer);
            _registeredUser = _userFactory.GetUser(role, gender, null, 0);
        }
        private void Login()
        {
            string username = _inputController.GetString("Bitte geben Sie ihren Benutzernamen ein: ");
            int password = _inputController.GetInt();
            _inputController.WriteString(username);
            _inputController.WriteInt(password);
            // Database.Instance
        }
        public void MainLifeCycle()
        {
            WelcomeView();
            // EnterAsUser();
            int i = 0;
            while (_registeredUser != null)
            {
                // Console.WriteLine(_registeredUser.GetType());
                // Console.WriteLine("Main Programm");


                if (i == 25)
                {

                    _registeredUser = null;
                }
                i++;
            }

        }
        private void WelcomeView()
        {
            string answer = _inputController.GetString("Willst du dich Registrieren oder hast du bereits ein Konto bei uns? Tippe '/register' um dich zu registerieren, '/guest' um als User fortzufahren oder '/login' um dich anzumelden.");
            _inputController.WriteString(answer);
            switch (answer)
            {
                case "/login":
                    Login();
                    break;
                case "/register":
                    RegisterUser();
                    break;
                case "/guest":
                    EnterAsUser();
                    break;
                default:
                    WelcomeView();
                    break;
            }
        }
        private void HandleInput()
        {

        }
        private void ShowUncompleteTranslatetWords()
        {

        }
    }
}