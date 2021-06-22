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
    // Last Modified: 6/22/2021
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
                Console.WriteLine("\t3] Data Recorder");
                Console.WriteLine("\t4] Alarm System");
                Console.ForegroundColor = ConsoleColor.Gray;
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
                        DataRecorderDisplayMenuScreen(finchRobot);
                        break;

                    case "4":
                        LightAlarmDisplayMenuScreen(finchRobot);
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

        #region DATA RECORDER

        /// <summary>
        /// *****************************************************************
        /// *           Data Recorder > Number of Data Points               *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>

        static void DataRecorderDisplayMenuScreen(Finch finchRobot)
        {
            
            int numberOfDataPoints = 0;
            double dataPointFrequency = 0.0;
            double[] temperatures = null;
            double[] lightSensors = null;

            Console.CursorVisible = true;

            bool quitDataRecorderMenu = false;
            string menuChoice;

            do
            {
                DisplayScreenHeader("DATA RECORDER MENU");
                Console.WriteLine();

                Console.WriteLine("\t1] Number of Data Points");
                Console.WriteLine("\t2] Frequency of Data Points");
                Console.WriteLine("\t3] Get Temperature Data");
                Console.WriteLine("\t4] Show Data");
                Console.WriteLine();
                Console.WriteLine("\t5] Get Light Data");
                Console.WriteLine("\t6] Show Light Data");
                Console.WriteLine();
                Console.WriteLine("\t7] Array Excercises");
                Console.WriteLine();
                Console.WriteLine("\t0] Main Menu");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("\t\tEnter Choice:");
                menuChoice = (Console.ReadLine());

                switch (menuChoice)
                {
                    case "1":
                        numberOfDataPoints = DataRecorderDisplayGetNumberOfDataPoints();
                        break;

                    case "2":
                        dataPointFrequency = DataRecorderDisplayGetDataPointFrequency();
                        break;

                    case "3":
                        temperatures = DataRecorderDisplayGetData(numberOfDataPoints, dataPointFrequency, finchRobot);
                        break;

                    case "4":
                        DataRecorderDisplayData(temperatures);
                        break;

                    case "5":
                        lightSensors = DataRecorderDisplayGetLightSensors(numberOfDataPoints, dataPointFrequency, finchRobot);
                        break;

                    case "6":
                        DataRecorderDisplayLightSensorData(lightSensors);
                        break;

                    case "7":
                        DataRecorderArrayExcercises(finchRobot);
                        break;

                    case "0":
                        quitDataRecorderMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a number for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }
            }
            while (!quitDataRecorderMenu);
        }

        private static void DataRecorderDisplayLightSensorData(double[] lightSensors)
        {
            throw new NotImplementedException();
        }

        private static void DataRecorderArrayExcercises(Finch finchRobot)
        {
            Console.CursorVisible = true;

            bool quitDataRecorderMenu = false;
            string menuChoice;

            do
            {
                DisplayScreenHeader("ARRAY EXCERCISES");
                Console.WriteLine();

                Console.WriteLine("\t1] Declare and Initialize");
                Console.WriteLine("\t2] Sort");
                Console.WriteLine("\t3] Sum");
                Console.WriteLine("\t4] Average");
                Console.WriteLine("\t5] Foreach Loop");
                Console.WriteLine();
                Console.WriteLine("\t0] Main Menu");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("\t\tEnter Choice:");
                menuChoice = (Console.ReadLine());

                switch (menuChoice)
                {
                    case "1":
                        DataRecorderArrayExcercisesDeclare(finchRobot);
                        break;

                    case "2":
                        DataRecorderArrayExcercisesSort();
                        break;

                    case "3":
                        DataRecorderArrayExcercisesSum();
                        break;

                    case "4":
                        DataRecorderArrayExcercisesAverage();
                        break;

                    case "5":
                        DataRecorderArrayExcercisesForeachLoop();
                        break;

                    case "0":
                        quitDataRecorderMenu = true;
                        break;
                }
            }
            while (!quitDataRecorderMenu);
        }

        private static void DataRecorderArrayExcercisesDeclare(Finch finchRobot)
        {
            Finch myFinch = new Finch();
            int[] lightReading = new int[10]; int i = 0;

            lightReading[i] = (myFinch.getLeftLightSensor() + myFinch.getRightLightSensor()) / 2; i++;
        
            i = 0;
            while (i < 10) {Console.WriteLine(lightReading[i]); i++; }

            DisplayContinuePrompt();
        }

        private static void DataRecorderArrayExcercisesSort()
        {
            
        }

        private static void DataRecorderArrayExcercisesSum()
        {
            
        }

        private static void DataRecorderArrayExcercisesAverage()
        {

        }

        private static void DataRecorderArrayExcercisesForeachLoop()
        {
            int[,] numbers2D = new int[3, 2] { { 9, 99 }, { 3, 33 }, { 5, 55 } };

            foreach (int i in numbers2D)
            {
                Console.Write("{0} ", i);
            }
        }

        private static double[] DataRecorderDisplayGetLightSensors(int numberOfDataPoints, double dataPointFrequency, Finch finchRobot)
        {
            double[] lightSensors = new double[numberOfDataPoints];

            DisplayScreenHeader("GET LIGHT DATA");

            Console.WriteLine($"\tNumber of data points: {numberOfDataPoints}");
            Console.WriteLine($"\tNumber of seconds: {dataPointFrequency}");
            Console.WriteLine();
            Console.WriteLine("\tThe Finch robot is ready to record data.");
            DisplayContinuePrompt();

            for (int index = 0; index == numberOfDataPoints; index++)
            {
                lightSensors[index] = finchRobot.getTemperature();
                Console.WriteLine($"\tReading {index + 1}: {lightSensors[index].ToString("n2")}");
                int waitInSeconds = (int)(dataPointFrequency * 1000);
                finchRobot.wait(waitInSeconds);
            }

            DisplayContinuePrompt();
            DisplayScreenHeader("GET LIGHT DATA");

            Console.WriteLine();
            Console.WriteLine("\tTable of Light Data");
            Console.WriteLine();
            DataRecorderDisplayTable(lightSensors);

            DisplayContinuePrompt();

            return lightSensors;
        }

        private static int DataRecorderDisplayGetNumberOfDataPoints()
        {
            int numberOfDataPoints;

            DisplayScreenHeader("NUMBER OF DATA POINTS");
            Console.WriteLine();

            Console.Write("\tPlease enter the number of Data Points.");
            Console.WriteLine();
            Console.WriteLine();

            int.TryParse(Console.ReadLine(), out numberOfDataPoints);

            Console.WriteLine();
            Console.WriteLine($"\tYou have entered {numberOfDataPoints} Data Points.");

            DisplayContinuePrompt();

            return numberOfDataPoints;
        }
        
        private static double DataRecorderDisplayGetDataPointFrequency()
        {
            double dataPointFrequency;

            DisplayScreenHeader("DATA POINT FREQUENCY");
            Console.WriteLine();

            Console.Write("\tPlease enter the Data Point Frequency (in seconds).");
            Console.WriteLine();
            Console.WriteLine();

            double.TryParse(Console.ReadLine(), out dataPointFrequency);

            Console.WriteLine();
            Console.WriteLine($"\tYou have entered {dataPointFrequency} seconds.");

            DisplayContinuePrompt();

            return dataPointFrequency;
        }

        private static double[] DataRecorderDisplayGetData(int numberOfDataPoints, double dataPointFrequency, Finch finchRobot)
        {
            double[] temperatures = new double[numberOfDataPoints];

            DisplayScreenHeader("GET TEMPERATURE DATA");

            Console.WriteLine($"\tNumber of data points: {numberOfDataPoints}");
            Console.WriteLine($"\tNumber of seconds: {dataPointFrequency}");
            Console.WriteLine();
            Console.WriteLine("\tThe Finch robot is ready to record data.");
            DisplayContinuePrompt();

            for (int index = 0; index < numberOfDataPoints; index++)
            {
                temperatures[index] = finchRobot.getTemperature();
                Console.WriteLine($"\tReading {index + 1}: {temperatures[index].ToString("n2")}");
                int waitInSeconds = (int)(dataPointFrequency * 1000);
                finchRobot.wait(waitInSeconds);
            }

            DisplayContinuePrompt();
            DisplayScreenHeader("GET TEMPERATURE DATA");

            Console.WriteLine();
            Console.WriteLine("\tTable of Temperatures");
            Console.WriteLine();
            DataRecorderDisplayTable(temperatures);

            DisplayContinuePrompt();

            return temperatures;
        }

        private static void DataRecorderDisplayData(double[] temperatures)
        {
            DisplayScreenHeader("SHOW DATA");
            Console.WriteLine();

            DataRecorderDisplayTable(temperatures);

            DisplayContinuePrompt();
        }

        private static void DataRecorderDisplayTable(double[] temperatures)
        {
            Console.WriteLine(
               "Recording #".PadLeft(15) +
               "Temp".PadLeft(15)
               );
            Console.WriteLine(
                "-----------".PadLeft(15) +
                "-----------".PadLeft(15)
                );
            for (int index = 0; index < temperatures.Length; index++)
            {
                Console.WriteLine(
                (index + 1).ToString().PadLeft(15) +
                temperatures[index].ToString("n2").PadLeft(15)
                );
            }
        }

        #endregion

        #region ALARM SYSTEM

        /// <summary>
        /// *****************************************************
        /// *                 Light Alarm Menu                  *
        /// *****************************************************
        /// </summary>  
        /// <param name="finchRobot">finch robot object</param>

        static void LightAlarmDisplayMenuScreen(Finch finchRobot)
        {
            Console.CursorVisible = true;

            bool quitDataRecorderMenu = false;
            string menuChoice;

            string tempOrLight = "";
            string sensorsToMonitor = "";
            string rangeType = "";

            int minMaxThresholdValue = 0;
            int timeToMonitor = 0;

            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                DisplayScreenHeader("LIGHT ALARM SYSTEM");
                Console.WriteLine();

                Console.WriteLine("\t1] Set Sensors to Monitor");
                Console.WriteLine("\t2] Set Range Type");
                Console.WriteLine("\t3] Set Minimum/Maximum Threshhold Value");
                Console.WriteLine("\t4] Set Time to Monitor");
                Console.WriteLine("\t5] Set Alarm");
                Console.WriteLine();
                Console.WriteLine("\t6] Temperature & Light Alarm");

                Console.WriteLine();
                Console.WriteLine("\t0] Main Menu");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("\t\tEnter Choice:");
                menuChoice = (Console.ReadLine());

                switch (menuChoice)
                {
                    case "1":
                        sensorsToMonitor = LightAlarmDisplaySetSensorsToMonitor();
                        break;

                    case "2":
                        rangeType = LightAlarmDisplaySetRangeType();
                        break;

                    case "3":
                        minMaxThresholdValue = LightAlarmSetMinMaxThresholdValue(rangeType, finchRobot, tempOrLight);
                        break;

                    case "4":
                        timeToMonitor = LightAlarmSetTimeToMonitor();
                        break;

                    case "5":
                        LightAlarmSetAlarm(finchRobot, sensorsToMonitor, rangeType, minMaxThresholdValue, timeToMonitor);
                        break;

                    case "6":
                        LightAlarmTemperature(finchRobot);
                        break;


                    case "0":
                        quitDataRecorderMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a number for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }
            }
            while (!quitDataRecorderMenu);
        }

        private static void LightAlarmTemperature(Finch finchRobot)
        {
            int tempThreshold;
            int lightThreshold;
            string askLight;

            Console.ForegroundColor = ConsoleColor.White;
            DisplayScreenHeader("TEMPERATURE & LIGHT THRESHOLD VALUE");

            Console.WriteLine($"\tTemperature sensor ambient value: {finchRobot.getTemperature()}");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write($"\tEnter the minimum temperature sensor value:");
            int.TryParse(Console.ReadLine(), out tempThreshold);

            Console.WriteLine();
            Console.WriteLine($"\tYou have entered the minimum value as {tempThreshold}.");

            if (tempThreshold >= finchRobot.getTemperature())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(1, 10);
                Console.WriteLine("\t***********************************************");
                Console.WriteLine("\t*                                             *");
                Console.WriteLine("\t*                 W A R N I N G               *");
                Console.WriteLine("\t*         Min. Temp. Threshold Exceeded       *");
                Console.WriteLine("\t*                                             *");
                Console.WriteLine("\t***********************************************");

                finchRobot.noteOn(1000);
                finchRobot.setLED(255, 0, 0);
                finchRobot.wait(300);
                finchRobot.noteOn(2000);
                finchRobot.setLED(0, 0, 0);
                finchRobot.wait(300);
                finchRobot.noteOn(1000);
                finchRobot.setLED(255, 0, 0);
                finchRobot.wait(300);
                finchRobot.noteOn(2000);
                finchRobot.setLED(0, 0, 0);
                finchRobot.wait(300);
                finchRobot.noteOn(1000);
                finchRobot.setLED(255, 0, 0);
                finchRobot.wait(300);
                finchRobot.noteOn(2000);
                finchRobot.setLED(0, 0, 0);
                finchRobot.wait(300);
                finchRobot.noteOn(1000);
                finchRobot.setLED(255, 0, 0);
                finchRobot.wait(300);
                finchRobot.noteOn(2000);
                finchRobot.setLED(0, 0, 0);
                finchRobot.wait(300);
                finchRobot.noteOff();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"\tThe minimum threshold value of {finchRobot.getTemperature()} was exceeded.");
                Console.ReadLine();
            }
            else
            {
                finchRobot.noteOn(4000);
                finchRobot.setLED(0, 255, 0);
                finchRobot.wait(300);
                finchRobot.noteOff();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"\tThe minimum threshold value of {finchRobot.getTemperature()} was not exceeded.");
                Console.ReadLine();
            }
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write($"\tMonitor the light sensor value? [yes, no]");
            askLight = Console.ReadLine();

            int tempValue;
            int lightValue;
            int threshold;

            if (askLight == "yes")
            {
                lightValue = (int)finchRobot.getLeftLightSensor();
                tempValue = (int)finchRobot.getTemperature();

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"\tLight sensor ambient value: {lightValue}");
                Console.WriteLine($"\tTemperature sensor ambient value: {tempValue}");
                Console.WriteLine();
                Console.WriteLine();

                Console.Write($"\tEnter the maximum light sensor value:");
                int.TryParse(Console.ReadLine(), out threshold);

                Console.WriteLine();
                Console.WriteLine($"\tYou have entered the maximum value as {threshold}.");

                if (threshold >= tempValue)   
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(1, 10);
                    Console.WriteLine("\t***********************************************");
                    Console.WriteLine("\t*                                             *");
                    Console.WriteLine("\t*                 W A R N I N G               *");
                    Console.WriteLine("\t*          Miximum Threshold Exceeded         *");
                    Console.WriteLine("\t*                                             *");
                    Console.WriteLine("\t***********************************************");

                    finchRobot.noteOn(1000);
                    finchRobot.setLED(255, 0, 0);
                    finchRobot.wait(300);
                    finchRobot.noteOn(2000);
                    finchRobot.setLED(0, 0, 0);
                    finchRobot.wait(300);
                    finchRobot.noteOn(1000);
                    finchRobot.setLED(255, 0, 0);
                    finchRobot.wait(300);
                    finchRobot.noteOn(2000);
                    finchRobot.setLED(0, 0, 0);
                    finchRobot.wait(300);
                    finchRobot.noteOn(1000);
                    finchRobot.setLED(255, 0, 0);
                    finchRobot.wait(300);
                    finchRobot.noteOn(2000);
                    finchRobot.setLED(0, 0, 0);
                    finchRobot.wait(300);
                    finchRobot.noteOn(1000);
                    finchRobot.setLED(255, 0, 0);
                    finchRobot.wait(300);
                    finchRobot.noteOn(2000);
                    finchRobot.setLED(0, 0, 0);
                    finchRobot.wait(300);
                    finchRobot.noteOff();

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine($"\tThe maximum threshold value of {tempValue} was exceeded.");
                    Console.ReadLine();
                }
                else if (threshold >= lightValue)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(1, 10);
                    Console.WriteLine("\t***********************************************");
                    Console.WriteLine("\t*                                             *");
                    Console.WriteLine("\t*                 W A R N I N G               *");
                    Console.WriteLine("\t*          Miximum Threshold Exceeded         *");
                    Console.WriteLine("\t*                                             *");
                    Console.WriteLine("\t***********************************************");

                    finchRobot.noteOn(1000);
                    finchRobot.setLED(255, 0, 0);
                    finchRobot.wait(300);
                    finchRobot.noteOn(2000);
                    finchRobot.setLED(0, 0, 0);
                    finchRobot.wait(300);
                    finchRobot.noteOn(1000);
                    finchRobot.setLED(255, 0, 0);
                    finchRobot.wait(300);
                    finchRobot.noteOn(2000);
                    finchRobot.setLED(0, 0, 0);
                    finchRobot.wait(300);
                    finchRobot.noteOn(1000);
                    finchRobot.setLED(255, 0, 0);
                    finchRobot.wait(300);
                    finchRobot.noteOn(2000);
                    finchRobot.setLED(0, 0, 0);
                    finchRobot.wait(300);
                    finchRobot.noteOn(1000);
                    finchRobot.setLED(255, 0, 0);
                    finchRobot.wait(300);
                    finchRobot.noteOn(2000);
                    finchRobot.setLED(0, 0, 0);
                    finchRobot.wait(300);
                    finchRobot.noteOff();

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine($"\tThe maximum threshold value of {tempValue} was exceeded.");
                    Console.ReadLine();
                }
                else
                {
                    finchRobot.noteOn(4000);
                    finchRobot.setLED(0, 255, 0);
                    finchRobot.wait(300);
                    finchRobot.noteOff();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine($"\tThe maximum threshold value of {lightValue} was not exceeded.");
                    Console.ReadLine();
                }
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            DisplayMenuPrompt("Light Alarm");
        }
        static void LightAlarmSetAlarm(Finch finchRobot, string sensorsToMonitor, string rangeType, int minMaxThresholdValue, int timeToMonitor)
        {
            int secondsElapsed = 0;
            bool thresholdExceeded = false;
            int currentLightSensorValue = 0;

            DisplayScreenHeader("SET ALARM");

            Console.WriteLine($"\tSensors to monitor: {sensorsToMonitor}");
            Console.WriteLine("\tRange Type: {0}", rangeType);
            Console.WriteLine("\tMin/Max Threshold Value: " + minMaxThresholdValue);
            Console.WriteLine($"\tTime to monitor: {timeToMonitor}");
            Console.WriteLine();

            Console.WriteLine("\tPress any key to begin monitoring.");
            Console.ReadKey();
            Console.WriteLine();

            while ((secondsElapsed < timeToMonitor) && !thresholdExceeded)
            {
                LightAlarmSecondsElapsed(secondsElapsed);
                switch (sensorsToMonitor)
                {
                    case "left":
                        currentLightSensorValue = finchRobot.getLeftLightSensor();
                        break;

                    case "right":
                        currentLightSensorValue = finchRobot.getRightLightSensor();
                        break;

                    case "both":
                        currentLightSensorValue = (finchRobot.getRightLightSensor() + finchRobot.getLeftLightSensor()) / 2;
                        break;  
                }

                switch (rangeType)
                {
                    case "minimum":
                        if (currentLightSensorValue < minMaxThresholdValue)
                        {
                            thresholdExceeded = true;
                        }
                        break;

                    case "maximum":
                        if (currentLightSensorValue > minMaxThresholdValue) 
                        {
                            thresholdExceeded = true;
                        }
                        break;  
                }

                finchRobot.wait(1000);
                secondsElapsed++;
            }

            if (thresholdExceeded)
            {
                Console.WriteLine($"\tThe {rangeType} threshold value of {minMaxThresholdValue} was exceeded by the current light sensor value of {currentLightSensorValue}.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(1, 10);
                Console.WriteLine("\t***********************************************");
                Console.WriteLine("\t*                                             *");
                Console.WriteLine("\t*                 W A R N I N G               *");
                Console.WriteLine("\t*         Max. Light Threshold Exceeded       *");
                Console.WriteLine("\t*                                             *");
                Console.WriteLine("\t***********************************************");
                
                finchRobot.noteOn(3000);
                finchRobot.setLED(255, 0, 0);
                finchRobot.wait(300);
                finchRobot.noteOn(2000);
                finchRobot.setLED(0, 0, 0);
                finchRobot.wait(300);
                finchRobot.noteOn(3000);
                finchRobot.setLED(255, 0, 0);
                finchRobot.wait(300);
                finchRobot.noteOn(2000);
                finchRobot.setLED(0, 0, 0);
                finchRobot.wait(300);
                finchRobot.noteOn(3000);
                finchRobot.setLED(255, 0, 0);
                finchRobot.wait(300);
                finchRobot.noteOn(2000);
                finchRobot.setLED(0, 0, 0);
                finchRobot.wait(300);
                finchRobot.noteOn(3000);
                finchRobot.setLED(255, 0, 0);
                finchRobot.wait(300);
                finchRobot.noteOn(2000);
                finchRobot.setLED(0, 0, 0);
                finchRobot.wait(300);
                finchRobot.noteOff();
                
                Console.WriteLine();
                Console.WriteLine($"\tThe {rangeType} threshold value of {minMaxThresholdValue} was exceeded.");
            }

            DisplayMenuPrompt("Light Alarm");
        }

        static void LightAlarmSecondsElapsed(int secondsElapsed)
        {
            Console.SetCursorPosition(2, 10);
            Console.WriteLine();
            Console.Write(string.Format($"\t{secondsElapsed} seconds elapsed."));
        }

        static int LightAlarmSetTimeToMonitor()
        {
            int timeToMonitor;

            DisplayScreenHeader("TIME TO MONITOR");

            Console.Write($"\tTime to Monitor (in seconds):");
            Console.WriteLine();
            Console.WriteLine();
            
            int.TryParse(Console.ReadLine(), out timeToMonitor);

            Console.WriteLine();
            Console.WriteLine($"\tYou have entered {timeToMonitor} seconds.");

            DisplayMenuPrompt("Light Alarm");

            return timeToMonitor;
        }

        static int LightAlarmSetMinMaxThresholdValue(string rangeType, Finch finchRobot, string tempOrLight)
        {
            int minMaxLightThresholdValue;

            DisplayScreenHeader("MINIMUM/MAXIMUM THRESHOLD VALUE");

            Console.WriteLine($"\tLeft light sensor ambient value: {finchRobot.getLeftLightSensor()}");
            Console.WriteLine($"\tRight light sensor ambient value: {finchRobot.getRightLightSensor()}");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write($"\tEnter the {rangeType} light sensor value:");
            int.TryParse(Console.ReadLine(), out minMaxLightThresholdValue);

            Console.WriteLine();
            Console.WriteLine($"\tYou have entered the {rangeType} value as {minMaxLightThresholdValue}.");

            DisplayMenuPrompt("Light Alarm");

            return minMaxLightThresholdValue;
        }

        static string LightAlarmDisplaySetSensorsToMonitor()
        {
            string tempOrLight;
            string sensorsToMonitor = "";

            DisplayScreenHeader("SENSORS TO MONITOR");

            Console.Write("\tSensors to monitor [temperature, light]:");
            tempOrLight = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();

            if (tempOrLight == "temperature")
            {
                Console.WriteLine($"\tYou have chosen {tempOrLight} to be monitored.");
            }
            else if (tempOrLight == "light")
            {
                Console.Write("\tLight sensors to monitor [left, right, both]:");
                sensorsToMonitor = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine($"\tYou have chosen {sensorsToMonitor} light(s) to be monitored.");
            }

            DisplayMenuPrompt("Light Alarm");

            return sensorsToMonitor;
        }

        static string LightAlarmDisplaySetRangeType()
        {
            string rangeType;

            DisplayScreenHeader("RANGE TYPE");

            Console.Write("\tRange Type [minimum, maximum]:");
            rangeType = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"\tYou have chosen a {rangeType} range type.");

            DisplayMenuPrompt("Light Alarm");

            return rangeType;
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
