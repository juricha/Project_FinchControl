using System;
using System.Collections.Generic;
using System.IO;
using FinchAPI;

namespace Project_FinchControl
{

    // **************************************************
    //
    // Title: Finch Control
    // Description: A Finch Robot menu control application,
    //              built on the provided starter solution 
    // Application Type: Console
    // Author: Jurich, Alexander
    // Dated Created: 6/4/2021
    // Last Modified: 6/6/2021
    //
    // **************************************************

    class Program
    {
        /// <summary>
        /// first method run when the app starts up
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            SetTheme();

            DisplayWelcomeScreen();
            DisplayMenuScreen();
            DisplayClosingScreen();
        }

        /// <summary>
        /// setup the console theme
        /// </summary>
        static void SetTheme()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGray;
        }

        /// <summary>
        /// *****************************************************************
        /// *                     Main Menu                                 *
        /// *****************************************************************
        /// </summary>
        static void DisplayMenuScreen()
        {
            Console.CursorVisible = true;

            bool quitApplication = false;
            string menuChoice;

            Finch finchRobot = new Finch();

            do
            {
                DisplayScreenHeader("MAIN MENU");
                Console.WriteLine();
                //
                // get user menu choice
                //
                Console.WriteLine("\t1] CONNECT Finch Robot");
                Console.WriteLine("\t2] Talent Show");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("\t3] Data Recorder");
                Console.WriteLine("\t4] Alarm System");
                Console.WriteLine("\t5] User Programming");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\t6] DISCONNECT Finch Robot");
                Console.WriteLine();
                Console.WriteLine("\t0] Quit");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("\tEnter Choice:");
                ;
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "1":
                        DisplayConnectFinchRobot(finchRobot);
                        break;

                    case "2":
                        TalentShowDisplayMenuScreen(finchRobot);
                        break;

                    case "3":

                        break;

                    case "4":

                        break;

                    case "5":

                        break;

                    case "6":
                        DisplayDisconnectFinchRobot(finchRobot);
                        break;

                    case "0":
                        DisplayDisconnectFinchRobot(finchRobot);
                        quitApplication = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a number for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitApplication);
        }

        #region TALENT SHOW

        /// <summary>
        /// *****************************************************************
        /// *                     Talent Show Menu                          *
        /// *****************************************************************
        /// </summary>
        static void TalentShowDisplayMenuScreen(Finch finchRobot)
        {
            Console.CursorVisible = true;

            bool quitTalentShowMenu = false;
            string menuChoice;

            do
            {
                DisplayScreenHeader("TALENT SHOW MENU");
                Console.WriteLine();

                //
                // get user menu choice
                //
                Console.WriteLine("\t1] Light and Sound");
                Console.WriteLine("\t2] Dance");
                Console.WriteLine("\t3] Mixing it Up");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("\t4] ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("\t0] Main Menu");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "1":
                        TalentShowDisplayLightAndSound(finchRobot);
                        break;

                    case "2":
                        TalentShowDisplayDance(finchRobot);
                        break;

                    case "3":
                        TalentShowDisplayMixingItUp(finchRobot);
                        break;

                    case "4":

                        break;

                    case "0":
                        quitTalentShowMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a number for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitTalentShowMenu);
        }

        /// <summary>
        /// *****************************************************************
        /// *               Talent Show > Light and Sound                   *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>
        static void TalentShowDisplayLightAndSound(Finch finchRobot)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("LIGHT AND SOUND");

            Console.WriteLine("\tThe Finch robot will not show off its glowing talent!");
            DisplayContinuePrompt();

            {
                finchRobot.noteOn(3000);
                finchRobot.setLED(0, 191, 255);
                finchRobot.wait(300);
                finchRobot.noteOn(2000);
                finchRobot.setLED(0, 0, 255);
                finchRobot.wait(300);
                finchRobot.noteOn(1000);
                finchRobot.setLED(0, 0, 205);
                finchRobot.wait(300);
                finchRobot.noteOn(2000);
                finchRobot.setLED(30, 144, 255);
                finchRobot.wait(300);
                finchRobot.noteOn(3000);
                finchRobot.setLED(128, 0, 128);
                finchRobot.wait(300);
                finchRobot.noteOn(4000);
                finchRobot.setLED(147, 112, 219);
                finchRobot.wait(300);
                finchRobot.noteOn(5000);
                finchRobot.setLED(75, 0, 130);
                finchRobot.wait(300);
                finchRobot.noteOn(4000);
                finchRobot.setLED(123, 104, 238);
                finchRobot.wait(300);
                finchRobot.noteOn(3000);
                finchRobot.setLED(223, 115, 255);
                finchRobot.noteOn(3000);
                finchRobot.setLED(123, 104, 238);
                finchRobot.wait(300);
                finchRobot.noteOn(2000);
                finchRobot.setLED(220, 20, 60);
                finchRobot.wait(300);
                finchRobot.noteOn(1000);
                finchRobot.setLED(255, 69, 0);
                finchRobot.wait(300);
                finchRobot.noteOn(2000);
                finchRobot.setLED(255, 53, 94);
                finchRobot.wait(300);
                finchRobot.noteOn(3000);
                finchRobot.setLED(139, 0, 0);
                finchRobot.wait(300);
                finchRobot.noteOn(4000);
                finchRobot.setLED(255, 0, 0);
                finchRobot.wait(300);
                finchRobot.noteOn(5000);
                finchRobot.setLED(232, 0, 13);
                finchRobot.wait(300);
                finchRobot.noteOn(4000);
                finchRobot.setLED(245, 199, 26);
                finchRobot.wait(300);
                finchRobot.noteOn(3000);
                finchRobot.setLED(255, 255, 49);
                finchRobot.noteOn(3000);
                finchRobot.setLED(0, 191, 255);
                finchRobot.wait(300);
                finchRobot.noteOn(2000);
                finchRobot.setLED(0, 0, 255);
                finchRobot.wait(300);
                finchRobot.noteOn(1000);
                finchRobot.setLED(0, 0, 205);
                finchRobot.wait(300);
                finchRobot.noteOn(2000);
                finchRobot.setLED(30, 144, 255);
                finchRobot.wait(300);
                finchRobot.noteOn(3000);
                finchRobot.setLED(128, 0, 128);
                finchRobot.wait(300);
                finchRobot.noteOn(4000);
                finchRobot.setLED(147, 112, 219);
                finchRobot.wait(300);
                finchRobot.noteOn(5000);
                finchRobot.setLED(75, 0, 130);
                finchRobot.wait(300);
                finchRobot.noteOn(4000);
                finchRobot.setLED(123, 104, 238);
                finchRobot.wait(300);
                finchRobot.noteOn(2000);
                finchRobot.setLED(223, 115, 255);
                finchRobot.wait(3000);
                finchRobot.noteOff();
                finchRobot.setLED(0, 0, 0);
            }

            DisplayMenuPrompt("Talent Show Menu");
        }

        /// <summary>
        /// *****************************************************************
        /// *                  Talent Show > Dance                          *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>
        static void TalentShowDisplayDance(Finch finchRobot)
        {
            Console.CursorVisible = false;
            bool isBeakUp;

            DisplayScreenHeader("DANCE");

            Console.WriteLine("\tThe Finch robot will now strut its stuff!");
            DisplayContinuePrompt();

            finchRobot.isBeakUp();
            finchRobot.setLED(102, 255, 0);
            finchRobot.setMotors(80, 0);
            finchRobot.wait(400);
            finchRobot.setMotors(0, 80);
            finchRobot.wait(400);
            finchRobot.setMotors(80, 0);
            finchRobot.wait(400);
            finchRobot.setMotors(0, 80);
            finchRobot.wait(400);
            finchRobot.setLED(255, 0, 255);
            finchRobot.setMotors(-80, 0);
            finchRobot.wait(400);
            finchRobot.setMotors(0, -80);
            finchRobot.wait(400);
            finchRobot.setMotors(-80, 0);
            finchRobot.wait(400);
            finchRobot.setMotors(0, -80);
            finchRobot.wait(400);
            finchRobot.setLED(0, 255, 255);
            finchRobot.setMotors(80, 0);
            finchRobot.wait(400);
            finchRobot.setMotors(0, 80);
            finchRobot.wait(400);
            finchRobot.setMotors(80, 0);
            finchRobot.wait(400);
            finchRobot.setMotors(0, 80);
            finchRobot.wait(400);
            finchRobot.setLED(255, 140, 0);
            finchRobot.setMotors(-80, 0);
            finchRobot.wait(400);
            finchRobot.setMotors(0, -80);
            finchRobot.wait(400);
            finchRobot.setMotors(-80, 0);
            finchRobot.wait(400);
            finchRobot.setMotors(0, -80);
            finchRobot.wait(400);
            finchRobot.setMotors(0, 0);
            finchRobot.setLED(0, 0, 0);
            finchRobot.noteOff();

            DisplayMenuPrompt("Talent Show Menu");
        }

        /// <summary>
        /// *****************************************************************
        /// *               Talent Show > Mixing it Up                      *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>
        static void TalentShowDisplayMixingItUp(Finch finchRobot)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("MIXING IT UP");

            Console.WriteLine("\tThe Finch Robot will now perform \"Greensleeves\"!");
            DisplayContinuePrompt();

            finchRobot.noteOn(880);
            finchRobot.wait(300);
            finchRobot.noteOn(1047);
            finchRobot.setMotors(40, 0);
            finchRobot.setLED(0, 128, 0);
            finchRobot.wait(600);
            finchRobot.noteOn(1175);
            finchRobot.wait(300);
            finchRobot.noteOn(1319);
            finchRobot.setMotors(-40, 0);
            finchRobot.setLED(172, 225, 175);
            finchRobot.wait(600);
            finchRobot.noteOn(1397);
            finchRobot.wait(150);
            finchRobot.noteOn(1319);
            finchRobot.wait(300);
            finchRobot.noteOn(1175);
            finchRobot.setMotors(0, 40);
            finchRobot.setLED(0, 100, 0);
            finchRobot.wait(600);
            finchRobot.noteOn(988);
            finchRobot.wait(300);
            finchRobot.noteOn(784);
            finchRobot.setMotors(0, -40);
            finchRobot.setLED(119, 221, 119);
            finchRobot.wait(600);
            finchRobot.noteOn(880);
            finchRobot.wait(150);
            finchRobot.noteOn(988);
            finchRobot.wait(300);
            finchRobot.noteOn(1047);
            finchRobot.setMotors(40, 0);
            finchRobot.setLED(34, 139, 34);
            finchRobot.wait(600);
            finchRobot.noteOn(880);
            finchRobot.wait(300);
            finchRobot.noteOn(880);
            finchRobot.setMotors(-40, 0);
            finchRobot.setLED(0, 128, 0);
            finchRobot.wait(600);
            finchRobot.noteOn(831);
            finchRobot.wait(150);
            finchRobot.noteOn(880);
            finchRobot.wait(300);
            finchRobot.noteOn(988);
            finchRobot.setMotors(0, 40);
            finchRobot.setLED(178, 236, 93);
            finchRobot.wait(600);
            finchRobot.noteOn(831);
            finchRobot.wait(300);
            finchRobot.noteOn(1319);
            finchRobot.setMotors(0, -40);
            finchRobot.setLED(50, 205, 50);
            finchRobot.wait(900);
            finchRobot.noteOff();
            finchRobot.wait(300);
            finchRobot.setMotors(0, 0);
            finchRobot.setLED(0, 0, 0);

            finchRobot.noteOn(1568);
            finchRobot.setMotors(40, 0);
            finchRobot.setLED(0, 128, 0);
            finchRobot.wait(900);
            finchRobot.setMotors(-40, 0);
            finchRobot.setLED(172, 225, 175);
            finchRobot.noteOn(1568);
            finchRobot.wait(600);
            finchRobot.noteOn(1397);
            finchRobot.wait(150);
            finchRobot.noteOn(1319);
            finchRobot.wait(300);
            finchRobot.setMotors(0, 40);
            finchRobot.setLED(0, 128, 0);
            finchRobot.noteOn(1175);
            finchRobot.wait(600);
            finchRobot.noteOn(988);
            finchRobot.wait(300);
            finchRobot.setMotors(0, -40);
            finchRobot.setLED(119, 221, 119);
            finchRobot.noteOn(784);
            finchRobot.wait(600);
            finchRobot.noteOn(880);
            finchRobot.wait(150);
            finchRobot.noteOn(988);
            finchRobot.wait(300);
            finchRobot.setMotors(40, 0);
            finchRobot.setLED(0, 128, 0);
            finchRobot.noteOn(1047);
            finchRobot.wait(600);
            finchRobot.noteOn(988);
            finchRobot.wait(150);
            finchRobot.noteOn(880);
            finchRobot.wait(300);
            finchRobot.setMotors(-40, 0);
            finchRobot.setLED(119, 221, 119);
            finchRobot.noteOn(831);
            finchRobot.wait(600);
            finchRobot.noteOn(740);
            finchRobot.wait(150);
            finchRobot.noteOn(831);
            finchRobot.wait(300);
            finchRobot.setMotors(80, -80);
            finchRobot.setLED(0, 128, 0);
            finchRobot.noteOn(880);
            finchRobot.wait(3000);

            finchRobot.noteOff();
            finchRobot.setMotors(0, 0);
            finchRobot.setLED(0, 0, 0);

            DisplayMenuPrompt("Talent Show Menu");
        }

        #endregion

        #region FINCH ROBOT MANAGEMENT

        /// <summary>
        /// *****************************************************************
        /// *               Disconnect the Finch Robot                      *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>
        static void DisplayDisconnectFinchRobot(Finch finchRobot)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("DISCONNECT FINCH ROBOT");

            Console.WriteLine("\tDisconnecting the Finch Robot...");
            DisplayContinuePrompt();
            finchRobot.noteOn(3000);
            finchRobot.setLED(0, 0, 255);
            finchRobot.wait(100);
            finchRobot.noteOn(2000);
            finchRobot.setLED(128, 0, 128);
            finchRobot.wait(100);
            finchRobot.noteOn(1000);
            finchRobot.setLED(255, 0, 0);
            finchRobot.wait(1000);
            finchRobot.noteOff();
            finchRobot.wait(800);
            finchRobot.noteOn(3000);
            finchRobot.setLED(0, 0, 255);
            finchRobot.wait(1000);
            finchRobot.noteOn(2000);
            finchRobot.setLED(128, 0, 128);
            finchRobot.wait(1000);
            finchRobot.noteOn(1000);
            finchRobot.setLED(255, 0, 0);
            finchRobot.wait(1000);
            finchRobot.noteOff();
            finchRobot.setLED(0, 0, 0);
            finchRobot.disConnect();

            Console.WriteLine("\tFinch Robot has been disconnected.");
            
            DisplayMenuPrompt("Main Menu");
        }

        /// <summary>
        /// *****************************************************************
        /// *                  Connect the Finch Robot                      *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>
        /// <returns>notify if the robot is connected</returns>
        static bool DisplayConnectFinchRobot(Finch finchRobot)
        {
            Console.CursorVisible = false;

            bool robotConnected;

            DisplayScreenHeader("CONNECT FINCH ROBOT");

            Console.WriteLine("\tConnecting Finch Robot... ");
             Console.WriteLine("\tPlease connect the Robot's USB cable to the computer.");
            DisplayContinuePrompt();

            robotConnected = finchRobot.connect();

            // TODO test connection and provide user feedback - text, lights, sounds
            if (robotConnected)
            {
                finchRobot.noteOn(1000);
                finchRobot.setLED(255, 0, 0);
                finchRobot.wait(1000);
                finchRobot.noteOn(2000);
                finchRobot.setLED(128, 0, 128);
                finchRobot.wait(1000);
                finchRobot.noteOn(3000);
                finchRobot.setLED(0, 0, 255);
                finchRobot.wait(1000);
                finchRobot.noteOff();
                finchRobot.wait(800);
                finchRobot.noteOn(1000);
                finchRobot.setLED(255, 0, 0);
                finchRobot.wait(100);
                finchRobot.noteOn(2000);
                finchRobot.setLED(128, 0, 128);
                finchRobot.wait(100);
                finchRobot.noteOn(3000);
                finchRobot.setLED(0, 0, 255);
                finchRobot.wait(1000);
                finchRobot.noteOff();
                Console.WriteLine("\tFinch Robot has been connected.");
            }
                DisplayMenuPrompt("Main Menu");

            //
            // reset finch robot
            //
            finchRobot.setLED(0, 0, 0);
            finchRobot.noteOff();

            return robotConnected;
        }

        #endregion

        #region USER INTERFACE

        /// <summary>
        /// *****************************************************************
        /// *                     Welcome Screen                            *
        /// *****************************************************************
        /// </summary>
        static void DisplayWelcomeScreen()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tFINCH CONTROL");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// *****************************************************************
        /// *                     Closing Screen                            *
        /// *****************************************************************
        /// </summary>
        static void DisplayClosingScreen()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tThank you for using Finch Control!");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// display continue prompt
        /// </summary>
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("\tPress any key to continue.");
            Console.ReadKey();
        }

        /// <summary>
        /// display menu prompt
        /// </summary>
        static void DisplayMenuPrompt(string menuName)
        {
            Console.WriteLine();
            Console.WriteLine($"\tPress any key to return to the {menuName} Menu.");
            Console.ReadKey();
        }

        /// <summary>
        /// display screen header
        /// </summary>
        static void DisplayScreenHeader(string headerText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerText);
            Console.WriteLine();
        }

        #endregion
    }
}
