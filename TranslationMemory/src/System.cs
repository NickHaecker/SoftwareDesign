using System;
using System.Collections.Generic;
using System.Collections;
namespace TranslationMemory
{
    class System
    {
        private InterfaceUser _registeredUser = null;
        private UserFactory _userFactory = null;
        private TranslationFactory _translationFactory = null;

        public System()
        {
            _userFactory = new UserFactory();
            _translationFactory = new TranslationFactory();
        }
        private void RegisterUser(string username, int password)
        {

        }
        private void Login(string username, int password)
        {

        }
        public void HandleInput()
        {
            int i = 0;
            while (_registeredUser != null)
            {
                Console.WriteLine("Main Programm");


                if (i == 25)
                {
                    _registeredUser = null;
                }
                i++;
            }
        }
        private void ShowUncompleteTranslatetWords()
        {

        }
    }
}