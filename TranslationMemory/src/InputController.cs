using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;
namespace TranslationMemory
{
    class InputController
    {
        private List<Command> _commands = new List<Command>();

        private string _userType = null;
        public void InitCommands(string usertype)
        {
            _userType = usertype;
            _commands.Add(new Command("/logout", null));

        }
        public void GetUserSpecificCommands()
        {

            List<string> commands = new List<string>();
            foreach (Command command in _commands)
            {
                if (command._userType == _userType || command._userType == null)
                {
                    commands.Add(command._command);
                }
            }
            foreach (string command in commands)
            {
                Console.WriteLine("Folgende Konsolenbefehle können sie auswählen: " + command);
            }
        }

        public string GetStringAnswer(string question)
        {
            Console.WriteLine(question);
            string answer = Console.ReadLine();
            return answer;
        }
        public string GetStringAnswer()
        {
            string answer = Console.ReadLine();
            return answer;
        }
        public int GetIntAnswer(string question)
        {
            Console.WriteLine(question);
            int answer = Convert.ToInt32(Console.ReadLine());
            return answer;
        }
        public void WriteString(string answer)
        {
            Console.WriteLine(answer);
        }
        public void WriteInt(int answer)
        {
            Console.WriteLine(answer);
        }
        public int GetIntAnswer()
        {
            Regex rgx = new Regex("[0-9]{4}");
            Console.WriteLine("Bitte gib dein Passwort ein: ");
            string answer = Console.ReadLine();
            if (rgx.IsMatch(answer))
            {
                return Convert.ToInt32(answer);
            }
            Console.WriteLine("Error! Leider haben sie keinen gültigen Zahlencode eingeben. Versuchen sie es erneut! Es muss eine vierstellige Zahl sein!");
            return GetIntAnswer();
        }
        public Gender GetGender(string gender)
        {
            if (gender.ToUpper() == Gender.MALE.ToString())
            {
                return Gender.MALE;
            }
            else if (gender.ToUpper() == Gender.FEMALE.ToString())
            {
                return Gender.FEMALE;
            }
            else
            {
                return Gender.DIVERS;
            }
        }
    }
}