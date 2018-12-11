using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordSaver
{
    class Program
    {

        // *************************************************************
        // Application:     Master Password
        // Author:          Chemello, Nick P
        // Description:     Capstone project.
        // Date Created:    12/2/2018
        // Date Revised:    12/9/2018
        // *************************************************************\


        static void Main(string[] args)
        {
            DisplayOpeningScreen();
            DisplayMenu();
            DisplayClosingScreen();
        }


        /// <summary>
        /// Example website
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        static Website InitializeWebSiteYoutube(string name)
        {
            Website youtube = new Website(name);

            youtube.Name = "Youtube";
            youtube.Email = "fistlast@youtube.com";
            youtube.Password = "Aa12345678";

            return youtube;
        }
        static Website InitializeWebSiteFacebook()
        {
            Website facebook = new Website();

            facebook.Name = "Facebook";
            facebook.Email = "fistlast@Facebook.com";
            facebook.Password = "Aa87654321";

            return facebook;
        }


        /// <summary>
        /// 
        /// </summary>
        static void DisplayMenu()
        {

            Website youtube;
            youtube = InitializeWebSiteYoutube("Youtube");
            Website facebook;
            facebook = InitializeWebSiteFacebook();

            //
            //add examples to list
            //
            List<Website> webList = new List<Website>();
            webList.Add(facebook);
            webList.Add(youtube);

            string menuChoice;
            bool exiting = false;

            while (!exiting)
            {
                DisplayHeader("Main Menu");

                Console.WriteLine("\tA) Display All Websites");
                Console.WriteLine("\tB) Add a Website");
                Console.WriteLine("\tC) Delete a Website");
                Console.WriteLine("\tD) Display Website info");
                Console.WriteLine("\tE) Exit");

                Console.Write("Enter Choice:");
                menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "A":
                    case "a":
                        DisplayAllWebSites(webList);
                        break;
                    case "B":
                    case "b":
                        DisplayAddSeaMonster(webList);
                        break;
                    case "C":
                    case "c":
                        DisplayDeleteSeaMonster(webList);
                        break;
                    case "D":
                    case "d":
                        DisplayWebsiteInfo(webList);
                        break;
                    case "E":
                    case "e":
                        exiting = true;
                        break;

                    default:
                        break;
                }
            }
        }

        private static void DisplayWebsiteInfo(List<Website> webList)
        {
            DisplayHeader("Website info");

            //
            //get website name
            //
            foreach (Website website in webList)
            {
                Console.WriteLine(website.Name);
            }
            Console.WriteLine();
            Console.WriteLine("Enter Name");
            string websiteName = Console.ReadLine();

            //
            //Display info
            //
            bool found = false;
            foreach (Website website in webList)
            {
                if (website.Name.ToUpper() == websiteName.ToUpper())
                {
                    Console.WriteLine();
                    Console.WriteLine(website.Name);
                    Console.WriteLine(website.Email);
                    Console.WriteLine(website.Password);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine($"unable to locate website name {websiteName}");
            }

            DisplayContinuePrompt();

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="webList"></param>
        static void DisplayDeleteSeaMonster(List<Website> webList)
        {
            DisplayHeader("Delete a Website");

            //
            //get website name
            //
            foreach (Website website in webList)
            {
                Console.WriteLine(website.Name);
            }

            Console.WriteLine();
            Console.Write("Enter Name:");
            string websiteName = Console.ReadLine();

            //
            //delete site
            //
            bool found = false;
            foreach (Website website in webList)
            {
                if (website.Name.ToUpper() == websiteName.ToUpper())
                {
                    webList.Remove(website);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine($"Error eunable to locate website name {websiteName}");
            }
            DisplayContinuePrompt();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="webList"></param>
        static void DisplayAddSeaMonster(List<Website> webList)
        {
            Website userWebsite = new Website();

            DisplayHeader("Add Website");

            Console.Write("Enter Website name:");
            userWebsite.Name = Console.ReadLine();
            Console.Write("Enter Email:");
            userWebsite.Email = Console.ReadLine();
            Console.Write("Enter Password:");
            userWebsite.Password = Console.ReadLine();

            webList.Add(userWebsite);

            DisplayOpeningScreen();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="webList"></param>
        static void DisplayAllWebSites(List<Website> webList)
        {
            DisplayHeader("List Of Websites");

            foreach (Website website in webList)
            {
                Console.WriteLine(website.WebsitPassword());
            }

            DisplayContinuePrompt();
        }



        #region HELPER METHODS

        /// <summary>
        /// display opening screen
        /// </summary>
        static void DisplayOpeningScreen()
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("\t\tWelcome to Master Password");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// display closing screen
        /// </summary>
        static void DisplayClosingScreen()
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("\t\tPasswords are stored. Thank you.");
            Console.WriteLine();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        /// <summary>
        /// display continue prompt
        /// </summary>
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        /// <summary>
        /// display header
        /// </summary>
        static void DisplayHeader(string headerTitle)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerTitle);
            Console.WriteLine();
        }

        #endregion


    }
}

