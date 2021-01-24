using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;
namespace TranslationMemory
{
    class InputController
    {
        public string GetString(string question)
        {
            Console.WriteLine(question);
            string answer = Console.ReadLine();
            return answer;
        }
        public int GetInt(string question)
        {
            Console.WriteLine(question);
            int answer = Convert.ToInt32(Console.ReadLine());
            return answer;
        }
        public void WriteString(string answer)
        {
            Console.WriteLine("Answer: " + answer);
        }
        public void WriteInt(int answer)
        {
            Console.WriteLine("Answer: " + answer);
        }
        public int GetInt()
        {
            Regex rgx = new Regex("[0-9]{4}");
            Console.WriteLine("Bitte gib dein Passwort ein: ");
            string answer = Console.ReadLine();
            if (rgx.IsMatch(answer))
            {
                return Convert.ToInt32(answer);
            }
            else
            {
                Console.WriteLine("Error! Leider haben sie keinen gültigen Zahlencode eingeben. Versuchen sie es erneut! Es muss eine vierstellige Zahl sein!");
                GetInt();
            }
            return GetInt();
        }
    }
}