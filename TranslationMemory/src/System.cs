using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
namespace TranslationMemory
{
    class System
    {
        private InterfaceUser _registeredUser = null;
        private DataTransferObject _dataTransferObject = null;
        private ConsoleController _inputController = null;

        public System()
        {
            _dataTransferObject = new DataTransferObject();
            _inputController = new ConsoleController();
            // CreateAdminAndTranslator();
        }
        private void CreateAdminAndTranslator()
        {
            InterfaceUser translator = (Translator)_dataTransferObject.CreateNewUser(Role.TRANSLATOR, Gender.MALE, "translator1234", 1234, new List<Word>(), new List<Translation>());
            InterfaceUser admin = (Admin)_dataTransferObject.CreateNewUser(Role.ADMIN, Gender.MALE, "admin1234", 1234, new List<Word>(), new List<Translation>());
            _dataTransferObject.SaveUser(translator, Role.TRANSLATOR);
            _dataTransferObject.SaveUser(admin, Role.ADMIN);
        }
        private void RegisterUser()
        {
            string username = _inputController.GetStringAnswer("Bitte erstellen sie ihren Benutzernamen: ");
            int password = _inputController.GetIntAnswer();
        }
        private void EnterAsUser()
        {
            string answer = _inputController.GetStringAnswer("Bitte geben sie ihr geschlecht ein. Sie können wählen zwischen 'Male', 'Female' oder 'Divers'");
            // string answer = "Male";
            if (answer.ToUpper() != _inputController.GetGender(answer).ToString())
            {
                _inputController.WriteString("Tut mir leid, aber ihre Eingabe war leider nicht richtig");
                EnterAsUser();
            }
            Role role = Role.USER;
            Gender gender = _inputController.GetGender(answer);
            _registeredUser = (User)_dataTransferObject.CreateNewUser(role, gender, null, 0, new List<Word>(), null);
            // _dataTransferObject.SaveUser((User)_registeredUser, _registeredUser.Role);
            // List<Language> l = _dataTransferObject.GetLanguages();
            // Database.Instance.SaveUser((User)_registeredUser, Role.USER);
        }
        private void Login()
        {
            string username = _inputController.GetStringAnswer("Bitte geben Sie ihren Benutzernamen ein: ");
            int password = _inputController.GetIntAnswer();
            // _inputController.WriteString(username);
            // _inputController.WriteInt(password);
            // Database.Instance
            if (_dataTransferObject.LoginUser(username, password) != null)
            {
                InterfaceUser u = _dataTransferObject.LoginUser(username, password);
                string name = "";
                switch (u.Role)
                {
                    case Role.TRANSLATOR:
                        Translator t = (Translator)u;
                        name = t._userName;
                        _registeredUser = (Translator)u;
                        break;
                    default:
                        Admin a = (Admin)u;
                        name = a._userName;
                        _registeredUser = (Admin)u;
                        break;
                }
                _inputController.WriteString("####################### Herzlich Willkommen ################## \nGuten Tag " + name + ", Sie haben sich erfolgreich angmeldet!");
            }
            else
            {
                _inputController.WriteErrorMessage();
                _inputController.WriteString("Sie müssen Ihren richtigen Usernamen und ihr richtiges Passwort eingeben um sich anmelden zu könenn!");
                Login();
            }
        }
        public void MainLifeCycle()
        {
            WelcomeView();
            _inputController.InitCommands(_registeredUser.GetType().ToString());

            // EnterAsUser();
            // int i = 0;
            while (_registeredUser != null)
            {

                MainLifeCycleHandleInput();
                // Console.WriteLine(_registeredUser.GetType());
                // Console.WriteLine("Main Programm");


                // if (i == 25)
                // {

                //     _registeredUser = null;
                // }
                // i++;
            }
            SayingGoodbye();
        }
        private void WelcomeView()
        {
            string answer = _inputController.GetStringAnswer("Willst du dich Registrieren oder hast du bereits ein Konto bei uns? Tippe '/guest' um als User fortzufahren oder '/login' um dich anzumelden.");
            _inputController.WriteString(answer);
            switch (answer)
            {
                case "/login":
                    Login();
                    break;
                // case "/register":
                //     RegisterUser();
                //     break;
                case "/guest":
                    EnterAsUser();
                    break;
                default:
                    WelcomeView();
                    break;
            }
        }
        private void MainLifeCycleHandleInput()
        {
            _inputController.WriteStringList(_inputController.GetUserSpecificCommands(), "Zwischen folgende Konsolenbefehle können sie auswählen: ", null);
            string answer = _inputController.GetStringAnswer();
            if (_inputController.IsInputCorrectAt(answer))
            {
                switch (answer)
                {
                    case "/logout":
                        _inputController.WriteString("Aufwiedersehen und bis zum nächsten mal /n Wollen Sie sich erneut anmelden oder das Programm beenden?");
                        switch (_registeredUser.Role)
                        {
                            case Role.USER:
                                _dataTransferObject.SaveUser((User)_registeredUser, _registeredUser.Role);
                                break;
                            case Role.TRANSLATOR:
                                _dataTransferObject.SaveUser((Translator)_registeredUser, _registeredUser.Role);
                                break;
                            default:
                                _dataTransferObject.SaveUser((Admin)_registeredUser, _registeredUser.Role);
                                break;
                        }
                        _registeredUser = null;
                        break;
                    case "/search-word":
                        string word = _inputController.GetStringAnswer("Nach welchem Wort wollen Sie suchen?");
                        Word WORD = _dataTransferObject.GetWord(word);
                        if (WORD == null)
                        {
                            _inputController.WriteString("Tut uns leid, das Wort " + word + " haben wir leider nicht in unserem System gefunden, wir fügen ihnen Ihr Wort dem System hinzu");
                            Word _word = _dataTransferObject.CreateWord(word);
                            switch (_registeredUser.Role)
                            {
                                case Role.TRANSLATOR:
                                    Translator t = (Translator)_registeredUser;
                                    CreateTranslations(_word._UUID, t.UUID);
                                    t.SaveWord(_word);
                                    break;
                                default:
                                    User u = (User)_registeredUser;
                                    CreateTranslations(_word._UUID, u.UUID);
                                    u.SaveWord(_word);
                                    break;
                            }
                        }
                        else
                        {
                            _inputController.WriteTranslationsByWord(_dataTransferObject.GetTranslationByWord(WORD), WORD);
                        }
                        break;
                    case "/get-my-words":
                        List<Word> createdWords = new List<Word>();
                        switch (_registeredUser.Role)
                        {
                            case Role.TRANSLATOR:
                                Translator t = (Translator)_registeredUser;
                                createdWords = t.GetAddedWords();
                                break;
                            default:
                                User u = (User)_registeredUser;
                                createdWords = u.GetAddedWords();
                                break;
                        }
                        _inputController.WriteAddedWords(createdWords);
                        break;
                    case "/get-count-of-all-words-in-database":
                        string count = "Zurzeit sind " + _dataTransferObject.GetWordsInDatabaseLength() + " in der Datenbank gespeichert";
                        List<string> percentages = _dataTransferObject.GetPercentageOfCorrectTranslatetWords();
                        _inputController.WriteStringList(percentages, count, null);
                        break;
                    default:
                        MainLifeCycleHandleInput();
                        break;
                }
            }
            else
            {
                _inputController.WriteErrorMessage();
                MainLifeCycleHandleInput();
            }

        }
        private void ShowUncompleteTranslatetWords()
        {

        }
        private void SayingGoodbye()
        {
            string answer = _inputController.GetStringAnswer("Geben Sie entweder /login, /guest oder /end ein um fortzufahren.");
            switch (answer)
            {
                case "/login":
                    Login();
                    break;
                case "/guest":
                    EnterAsUser();
                    break;
                case "/end":
                    break;
                default:
                    _inputController.WriteErrorMessage();
                    SayingGoodbye();
                    break;
            }

        }
        private void HandleInput(string answer)
        {

        }
        private void CreateTranslations(string wordUuid, string userUuid)
        {
            _dataTransferObject.CreateTranslation(wordUuid, userUuid, true);
        }
    }
}