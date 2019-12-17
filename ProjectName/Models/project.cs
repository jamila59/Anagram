using System;


namespace ToDoList.Models
{

    class Project
    {
        static void Main()
        {
            Console.WriteLine("Enter a word to check for possible anagrams");
            string userWord = Console.ReadLine();

            Console.WriteLine("Enter a list of words");
            string userList = Console.ReadLine();
            string[] userListArray = userList.ToArray();

            Item input = new Item(userWord, userListArray);
            input.CheckAnagram();
        }
    }
}    