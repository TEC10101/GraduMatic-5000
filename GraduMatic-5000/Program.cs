using System;
using System.Threading;
using System.Speech.Synthesis;

namespace GraduMatic_5000
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 2: Write a C# program that determines a student’s grade.
            //The program will read three types of scores(quiz score, mid-term score, and final score) and determine the grade based on the following rules:
            //-if the average score =90% =>grade=A
            //-if the average score >= 70% and<90% => grade=B
            //-if the average score>=50% and<70% =>grade=C
            //-if the average score<50% =>grade=F

            SpeechSynthesizer synth = new SpeechSynthesizer();

            synth.SetOutputToDefaultAudioDevice();

            Random randomgen = new Random();

            int beepgen1, beepgen2, beepgen3, beepgen4, beepgen5, beepgen6, beepgen7, beepgen8, beepgenn1, beepgenn2, beepgenn3, beepgenn4, beepgenn5, beepgenn6, beepgenn7, beepgenn8;

            #region BeepGen
            beepgen1 = (randomgen.Next(37, 7000));
            beepgen2 = (randomgen.Next(37, 6000));
            beepgen3 = (randomgen.Next(37, 6000));
            beepgen4 = (randomgen.Next(37, 7000));
            beepgen5 = (randomgen.Next(37, 8000));
            beepgen6 = (randomgen.Next(37, 7000));
            beepgen7 = (randomgen.Next(37, 7000));
            beepgen8 = (randomgen.Next(37, 5000));
            beepgenn1 = (randomgen.Next(50, 200));
            beepgenn2 = (randomgen.Next(50, 250));
            beepgenn3 = (randomgen.Next(50, 300));
            beepgenn4 = (randomgen.Next(50, 200));
            beepgenn5 = (randomgen.Next(50, 250));
            beepgenn6 = (randomgen.Next(50, 200));
            beepgenn7 = (randomgen.Next(50, 300));
            beepgenn8 = (randomgen.Next(50, 250));
            #endregion

            int quizMax = 50;
            int midtermMax = 100;
            int finalMax = 100;

            #region Program Gradu-Matic 5000
            Console.Title = "Will you pass?";
            Console.SetWindowSize(63, 26);
            Console.BufferHeight = 26;
            Console.BufferWidth = 63;
            // To figure outh which voices are installed
            //foreach (var voice in synth.GetInstalledVoices())
            //{
            //    Console.WriteLine(voice.VoiceInfo.Name);
            //}
            Console.WriteLine("/############################################################\\");
            Thread.Sleep(15);
            Console.Beep(2000, 100);
            Console.WriteLine("###################   Gradu-Matic 5000!   ####################");
            Thread.Sleep(15);
            Console.Beep(2000, 100);
            Console.WriteLine("##############################################################");
            Thread.Sleep(15);
            Console.Beep(2000, 100);
            Console.WriteLine("######                                                  ######");
            Thread.Sleep(15);
            Console.Beep(2000, 100);
            Console.WriteLine("###### The program will read three types of scores(quiz ######");
            Thread.Sleep(15);
            Console.Beep(2000, 100);
            Console.WriteLine("###### score, mid-term score, and final score) and det- ######");
            Thread.Sleep(15);
            Console.Beep(2000, 100);
            Console.WriteLine("###### ermine the grade based on the following rules:   ######");
            Thread.Sleep(15);
            Console.Beep(2000, 100);
            Console.WriteLine("######                                                  ######");
            Thread.Sleep(15);
            Console.Beep(2000, 100);
            Console.WriteLine("###### -if the average score >= 90%           Grade=A   ######");
            Thread.Sleep(15);
            Console.Beep(2000, 100);
            Console.WriteLine("###### -if the average score >= 70% and < 90% Grade=B   ######");
            Thread.Sleep(15);
            Console.Beep(2000, 100);
            Console.WriteLine("###### -if the average score >= 50% and < 70% Grade=C   ######");
            Thread.Sleep(15);
            Console.Beep(2000, 100);
            Console.WriteLine("###### -if the average score <  50%           Grade=F   ######");
            Thread.Sleep(15);
            Console.Beep(2000, 100);
            Console.WriteLine("######                                                  ######");
            Thread.Sleep(15);
            Console.Beep(2000, 100);
            Console.WriteLine("##############################################################");
            Thread.Sleep(15);
            Console.Beep(2000, 100);
            Console.WriteLine("######                                                  ######");
            Thread.Sleep(15);
            Console.Beep(2000, 100);
            Console.WriteLine("######    Quiz: [  ]  Mid-Term: [   ]  Final: [   ]     ######");
            Thread.Sleep(15);
            Console.Beep(2000, 100);
            Console.WriteLine("######                   Grade:                         ######");
            Thread.Sleep(15);
            Console.Beep(2000, 100);
            Console.WriteLine("######                                                  ######");
            Thread.Sleep(15);
            Console.Beep(2000, 100);
            Console.WriteLine("##############################################################");
            Thread.Sleep(15);
            Console.Beep(2000, 100);
            Console.WriteLine("###################      END OF LINE      ####################");
            Thread.Sleep(115);
            Console.WriteLine("\\############################################################/");
            Console.CursorVisible = false;
            Thread.Sleep(1500);
            Console.Write("\nHello.");
            synth.SpeakAsync("Hello!");
            Thread.Sleep(750);
            synth.SpeakAsync("I am gradumatic five thousand!");
            Console.Write(" I am Gradu-Matic 5000.");
            Thread.Sleep(750);
            synth.SpeakAsync("I will be grading you.");
            Console.Write(" I will be grading you.");
            Thread.Sleep(750);
            Console.WriteLine("\nDo you understand the risks I will put you through? ");
            synth.Speak("Do you understand the risks I will put you through?");
            Console.CursorVisible = true;
            Console.Write("Command: ");
            string riskInput = Console.ReadLine();
            #endregion

            if (riskInput.ToLower() == "star wars")
            {
                starwars();
                gradumaticUIBonus();
            }
            else if (riskInput.ToLower() == "mission")
            {
                missionImpossible();
                gradumaticUIBonus();
            }
            else if (riskInput.ToLower() == "mystery")
            {
                mysteryMethod();
                gradumaticUIBonus();
            }
            else if (riskInput.ToLower() == "mario")
            {
                mario();
                gradumaticUIBonus();
            }
            else if (riskInput.ToLower() == "bonus")
            {
                gradumaticUIBonus();
            }
            else if (riskInput.ToLower() == "animeplot")
            {
                animePlot();
                gradumaticUIBonus();
            }
            else if (riskInput.ToLower() == "no" || riskInput.ToLower() == "n")
            {
                synth.Speak("There are... lots of them!");
            }
            else if (riskInput.ToLower() == "yes" || riskInput.ToLower() == "y")
            {
                synth.Speak("Good luck and god speed.");
            }
            else
            {
                string f = "F";
                int failQuiz = 0;
                int failMidterm = 0;
                int failFinal = 0;
                gradumaticUIJoke(failQuiz, failMidterm, failFinal, f);
                synth.Speak("You failed.  Grade: F.");
                Thread.Sleep(2000);
                synth.Speak("Ha ha ha.  Just kidding, try yes, or no, next time");
                Console.WriteLine("\n\n\n");
                //ex9();
            }




            //
            // Start Quiz Input
            //
            int quiz;
            string stringQuiz;
            do
            {
                gradumaticUI();
                Console.Write("\nWhat is your Quiz score?  I trust you will be honest.\n");
                Console.Write("(max 50): ");
                synth.SpeakAsync("What is your Quiz score?  I trust you will be honest.");
                stringQuiz = Console.ReadLine();
            } while (!Int32.TryParse(stringQuiz, out quiz) || (quiz > 50));


            #region Computer Generated Beep Noises and "Thank You"
            gradumaticUI();
            Console.Write("\nThank you");
            synth.SpeakAsync("Thank you");
            Thread.Sleep(750);
            Console.Write(".");
            Thread.Sleep(200);
            Console.Write(".");
            Thread.Sleep(200);
            Console.Write(".");

            synth.SpeakAsync("Beep bupe beep");

            Console.Write("  Beep");
            Console.Beep(beepgen1, beepgenn1);
            Console.Beep(beepgen2, beepgenn2);

            Thread.Sleep(100);
            Console.Write(" boop");
            Console.Beep(beepgen3, beepgenn3);
            Console.Beep(beepgen4, beepgenn4);

            Thread.Sleep(25);
            Console.Write(" beep");
            Console.Beep(beepgen5, beepgenn5);
            Console.Beep(beepgen6, beepgenn6);

            //Console.Beep(1000, 30);
            Thread.Sleep(200);
            Console.Write(".");
            Console.Beep(beepgen7, beepgenn7);
            Thread.Sleep(200);
            Console.Write(".");
            Console.Beep(beepgen8, beepgenn8);
            Thread.Sleep(200);
            Console.Write(".");


            //end pause before transition
            Thread.Sleep(1600);
            gradumaticUIQuiz(quiz);
            #endregion

            // Quiz Max Score Check:
            if (quiz == 50)
            {
                Console.CursorVisible = false;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nWoah! {quiz} out of {quizMax}, Impressive!\n");
                synth.Speak($"Wahw! {quiz} out of {quizMax}, Impressive!");
                Thread.Sleep(2000);
                Console.Clear();
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            //
            // Start Midterm Input
            //
            Console.CursorVisible = true;
            int midterm;
            string stringMidterm;
            do
            {
                gradumaticUIQuiz(quiz);
                Console.Write("\nWhat is your Mid-Term score? (max 100): ");
                synth.Speak("What is your Mid-Term score?");
                stringMidterm = Console.ReadLine();
            } while (!Int32.TryParse(stringMidterm, out midterm) || (midterm > 100));

            #region Computer Generated Beep Noises
            gradumaticUIQuiz(quiz);
            Console.Write("\nDelicious");
            synth.SpeakAsync("delicious!");
            Thread.Sleep(750);
            Console.Write(".");
            Thread.Sleep(200);
            Console.Write(".");
            Thread.Sleep(200);
            Console.Write(".");

            synth.SpeakAsync("Beep bupe beep");
            Console.Write("  Beep");
            Console.Beep(beepgen1, beepgenn1);
            Console.Beep(beepgen2, beepgenn2);

            Thread.Sleep(100);
            Console.Write(" boop");
            Console.Beep(beepgen3, beepgenn3);
            Console.Beep(beepgen4, beepgenn4);

            Thread.Sleep(100);
            Console.Write(" beep");
            Console.Beep(beepgen5, beepgenn5);
            Console.Beep(beepgen6, beepgenn6);

            //Console.Beep(1000, 30);
            Thread.Sleep(200);
            Console.Write(".");
            Console.Beep(beepgen7, beepgenn7);
            Thread.Sleep(200);
            Console.Write(".");
            Console.Beep(beepgen8, beepgenn8);
            Thread.Sleep(200);
            Console.Write(".");


            //end pause before transition
            Thread.Sleep(1600);
            Console.Clear();
            gradumaticUIMidterm(quiz, midterm);
            #endregion

            // Midterm Max Score Check:
            if (midterm == 100)
            {
                Console.CursorVisible = false;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nAced the Mid-Term! {midterm} out of {midtermMax}, you really know your stuff!\n");
                synth.Speak($"Aced the mid term! {midterm} out of {midtermMax}, you really know your stuff!");
                Thread.Sleep(2000);
            }

            Console.ForegroundColor = ConsoleColor.Gray;

            //
            // Start Final Input
            //
            int final;
            string stringFinal;
            Console.CursorVisible = true;

            do
            {
                gradumaticUIMidterm(quiz, midterm);
                Console.Write("\nWhat did you get on your Final? (max 100): ");
                synth.Speak("What did you get on your final?");
                stringFinal = Console.ReadLine();

            } while (!Int32.TryParse(stringFinal, out final) || (final > 100));

            #region Computer Generated Beep Noises
            gradumaticUIMidterm(quiz, midterm);
            Console.Write("\nAt last,");
            synth.SpeakAsync("At last!");
            Thread.Sleep(750);
            Console.Write(" All your grade are belong to us. Ha ha ha");
            synth.Speak("All your grade are belong to us.  Ha ha ha.");
            Console.Write("  Beep");
            Console.Beep(beepgen1, beepgenn1);
            Console.Beep(beepgen2, beepgenn2);

            Thread.Sleep(100);
            Console.Write(" boop");
            Console.Beep(beepgen3, beepgenn3);
            Console.Beep(beepgen4, beepgenn4);

            Thread.Sleep(25);
            Console.Write(" beep");
            Console.Beep(beepgen5, beepgenn5);
            Console.Beep(beepgen6, beepgenn6);

            //Console.Beep(1000, 30);
            Thread.Sleep(200);
            Console.Write(".");
            Console.Beep(beepgen7, beepgenn7);
            Thread.Sleep(200);
            Console.Write(".");
            Console.Beep(beepgen8, beepgenn8);
            Thread.Sleep(200);
            Console.Write(".");


            //end pause before transition
            Thread.Sleep(1600);
            Console.Clear();
            gradumaticUIFinal(quiz, midterm, final);
            #endregion

            // Final Max Score Check:
            if (final == 100)
            {
                Console.CursorVisible = false;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n{final} out of {finalMax}, I don't know what to say.");
                synth.Speak($"{final} out of {finalMax}, I don't know what to say! (well I could say some choice words, but won't");
                Thread.Sleep(2000);
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            string finalGrade = grader(quiz, midterm, final, quizMax, midtermMax, finalMax);
            gradumaticUIGrade(quiz, midterm, final, finalGrade);
        }

        static void starwars()
        {
            Console.Beep(440, 500);
            Console.Beep(440, 500);
            Console.Beep(440, 500);
            Console.Beep(349, 350);
            Console.Beep(523, 150);

            Console.Beep(440, 500);
            Console.Beep(349, 350);
            Console.Beep(523, 150);
            Console.Beep(440, 1000);

            Console.Beep(659, 500);
            Console.Beep(659, 500);
            Console.Beep(659, 500);
            Console.Beep(698, 350);
            Console.Beep(523, 150);

            Console.Beep(415, 500); ;
            Console.Beep(349, 350);
            Console.Beep(523, 150);
            Console.Beep(440, 1000);

            Console.Beep(880, 500);
            Console.Beep(440, 350);
            Console.Beep(440, 150);
            Console.Beep(880, 500);
            Console.Beep(830, 250);
            Console.Beep(784, 250);

            Console.Beep(740, 125);
            Console.Beep(698, 125);
            Console.Beep(740, 250);

            Console.Beep(455, 250);
            Console.Beep(622, 500);
            Console.Beep(587, 250);
            Console.Beep(554, 250);

            Console.Beep(523, 125);
            Console.Beep(466, 125);
            Console.Beep(523, 250);

            Console.Beep(349, 125);
            Console.Beep(415, 500);
            Console.Beep(349, 375);
            Console.Beep(440, 125);

            Console.Beep(523, 500);
            Console.Beep(440, 375);
            Console.Beep(523, 125);
            Console.Beep(659, 1000);

            Console.Beep(880, 500);
            Console.Beep(440, 350);
            Console.Beep(440, 150);
            Console.Beep(880, 500);
            Console.Beep(830, 250);
            Console.Beep(784, 250);

            Console.Beep(740, 125);
            Console.Beep(698, 125);
            Console.Beep(740, 250);

            Console.Beep(455, 250);
            Console.Beep(622, 500);
            Console.Beep(587, 250);
            Console.Beep(554, 250);

            Console.Beep(523, 125);
            Console.Beep(466, 125);
            Console.Beep(523, 250);

            Console.Beep(349, 250);
            Console.Beep(415, 500);
            Console.Beep(349, 375);
            Console.Beep(523, 125);

            Console.Beep(440, 500);
            Console.Beep(349, 375);
            Console.Beep(261, 125);
            Console.Beep(440, 1000);

            //Console.Beep(440, 500);
            //Console.Beep(440, 500);
            //Console.Beep(440, 500);
            //Console.Beep(349, 350);
            //Console.Beep(523, 150);
            //Console.Beep(440, 500);
            //Console.Beep(349, 350);
            //Console.Beep(523, 150);
            //Console.Beep(440, 1000);
            //Console.Beep(659, 500);
            //Console.Beep(659, 500);
            //Console.Beep(659, 500);
            //Console.Beep(698, 350);
            //Console.Beep(523, 150);
            //Console.Beep(415, 500);
            //Console.Beep(349, 350);
            //Console.Beep(523, 150);
            //Console.Beep(440, 1000);
        }
        static void missionImpossible()
        {
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(932, 150);
            Thread.Sleep(150);
            Console.Beep(1047, 150);
            Thread.Sleep(150);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(699, 150);
            Thread.Sleep(150);
            Console.Beep(740, 150);
            Thread.Sleep(150);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(932, 150);
            Thread.Sleep(150);
            Console.Beep(1047, 150);
            Thread.Sleep(150);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(699, 150);
            Thread.Sleep(150);
            Console.Beep(740, 150);
            Thread.Sleep(150);
            Console.Beep(932, 150);
            Console.Beep(784, 150);
            Console.Beep(587, 1200);
            Thread.Sleep(75);
            Console.Beep(932, 150);
            Console.Beep(784, 150);
            Console.Beep(554, 1200);
            Thread.Sleep(75);
            Console.Beep(932, 150);
            Console.Beep(784, 150);
            Console.Beep(523, 1200);
            Thread.Sleep(150);
            Console.Beep(466, 150);
            Console.Beep(523, 150);

        }
        static void mysteryMethod()
        {

            Console.Beep(658, 125); Console.Beep(1320, 500); Console.Beep(990, 250); Console.Beep(1056, 250); Console.Beep(1188, 250); Console.Beep(1320, 125); Console.Beep(1188, 125); Console.Beep(1056, 250); Console.Beep(990, 250); Console.Beep(880, 500); Console.Beep(880, 250); Console.Beep(1056, 250); Console.Beep(1320, 500); Console.Beep(1188, 250); Console.Beep(1056, 250); Console.Beep(990, 750); Console.Beep(1056, 250); Console.Beep(1188, 500); Console.Beep(1320, 500); Console.Beep(1056, 500); Console.Beep(880, 500); Console.Beep(880, 500); Thread.Sleep(250); Console.Beep(1188, 500); Console.Beep(1408, 250); Console.Beep(1760, 500); Console.Beep(1584, 250); Console.Beep(1408, 250); Console.Beep(1320, 750); Console.Beep(1056, 250); Console.Beep(1320, 500); Console.Beep(1188, 250); Console.Beep(1056, 250); Console.Beep(990, 500); Console.Beep(990, 250); Console.Beep(1056, 250); Console.Beep(1188, 500); Console.Beep(1320, 500); Console.Beep(1056, 500); Console.Beep(880, 500); Console.Beep(880, 500); Thread.Sleep(500); Console.Beep(1320, 500); Console.Beep(990, 250); Console.Beep(1056, 250); Console.Beep(1188, 250); Console.Beep(1320, 125); Console.Beep(1188, 125); Console.Beep(1056, 250); Console.Beep(990, 250); Console.Beep(880, 500); Console.Beep(880, 250); Console.Beep(1056, 250); Console.Beep(1320, 500); Console.Beep(1188, 250); Console.Beep(1056, 250); Console.Beep(990, 750); Console.Beep(1056, 250); Console.Beep(1188, 500); Console.Beep(1320, 500); Console.Beep(1056, 500); Console.Beep(880, 500); Console.Beep(880, 500); Thread.Sleep(250); Console.Beep(1188, 500); Console.Beep(1408, 250); Console.Beep(1760, 500); Console.Beep(1584, 250); Console.Beep(1408, 250); Console.Beep(1320, 750); Console.Beep(1056, 250); Console.Beep(1320, 500); Console.Beep(1188, 250); Console.Beep(1056, 250); Console.Beep(990, 500); Console.Beep(990, 250); Console.Beep(1056, 250); Console.Beep(1188, 500); Console.Beep(1320, 500); Console.Beep(1056, 500); Console.Beep(880, 500); Console.Beep(880, 500); Thread.Sleep(500); Console.Beep(660, 1000); Console.Beep(528, 1000); Console.Beep(594, 1000); Console.Beep(495, 1000); Console.Beep(528, 1000); Console.Beep(440, 1000); Console.Beep(419, 1000); Console.Beep(495, 1000); Console.Beep(660, 1000); Console.Beep(528, 1000); Console.Beep(594, 1000); Console.Beep(495, 1000); Console.Beep(528, 500); Console.Beep(660, 500); Console.Beep(880, 1000); Console.Beep(838, 2000); Console.Beep(660, 1000); Console.Beep(528, 1000); Console.Beep(594, 1000); Console.Beep(495, 1000); Console.Beep(528, 1000); Console.Beep(440, 1000); Console.Beep(419, 1000); Console.Beep(495, 1000); Console.Beep(660, 1000); Console.Beep(528, 1000); Console.Beep(594, 1000); Console.Beep(495, 1000); Console.Beep(528, 500); Console.Beep(660, 500); Console.Beep(880, 1000); Console.Beep(838, 2000);

        }
        static void mario()
        {
            Console.Beep(659, 125);
            Console.Beep(659, 125);
            Console.Beep(20000, 125);
            Console.Beep(659, 125);
            Console.Beep(20000, 167);
            Console.Beep(523, 125);
            Console.Beep(659, 125);
            Console.Beep(20000, 125);
            Console.Beep(784, 125);
            Console.Beep(20000, 375);
            Console.Beep(392, 125);
            Console.Beep(20000, 375);
            Console.Beep(523, 125);
            Console.Beep(20000, 250);
            Console.Beep(392, 125);
            Console.Beep(20000, 250);
            Console.Beep(330, 125);
            Console.Beep(20000, 250);
            Console.Beep(440, 125);
            Console.Beep(20000, 125);
            Console.Beep(494, 125);
            Console.Beep(20000, 125);
            Console.Beep(466, 125);
            Console.Beep(20000, 42);
            Console.Beep(440, 125);
            Console.Beep(20000, 125);
            Console.Beep(392, 125);
            Console.Beep(20000, 125);
            Console.Beep(659, 125);
            Console.Beep(20000, 125);
            Console.Beep(784, 125);
            Console.Beep(20000, 125);
            Console.Beep(880, 125);
            Console.Beep(20000, 125);
            Console.Beep(698, 125);
            Console.Beep(784, 125);
            Console.Beep(20000, 125);
            Console.Beep(659, 125);
            Console.Beep(20000, 125);
            Console.Beep(523, 125);
            Console.Beep(20000, 125);
            Console.Beep(587, 125);
            Console.Beep(494, 125);
            Console.Beep(20000, 125);
            Console.Beep(523, 125);
            Console.Beep(20000, 250);
            Console.Beep(392, 125);
            Console.Beep(20000, 250);
            Console.Beep(330, 125);
            Console.Beep(20000, 250);
            Console.Beep(440, 125);
            Console.Beep(20000, 125);
            Console.Beep(494, 125);
            Console.Beep(20000, 125);
            Console.Beep(466, 125);
            Console.Beep(20000, 42);
            Console.Beep(440, 125);
            Console.Beep(20000, 125);
            Console.Beep(392, 125);
            Console.Beep(20000, 125);
            Console.Beep(659, 125);
            Console.Beep(20000, 125);
            Console.Beep(784, 125);
            Console.Beep(20000, 125);
            Console.Beep(880, 125);
            Console.Beep(20000, 125);
            Console.Beep(698, 125);
            Console.Beep(784, 125);
            Console.Beep(20000, 125);
            Console.Beep(659, 125);
            Console.Beep(20000, 125);
            Console.Beep(523, 125);
            Console.Beep(20000, 125);
            Console.Beep(587, 125);
            Console.Beep(494, 125);
            Console.Beep(20000, 375);
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            Console.Beep(20000, 42);
            Console.Beep(622, 125);
            Console.Beep(20000, 125);
            Console.Beep(659, 125);
            Console.Beep(20000, 167);
            Console.Beep(415, 125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Console.Beep(20000, 125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Console.Beep(587, 125);
            Console.Beep(20000, 250);
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            Console.Beep(20000, 42);
            Console.Beep(622, 125);
            Console.Beep(20000, 125);
            Console.Beep(659, 125);
            Console.Beep(20000, 167);
            Console.Beep(698, 125);
            Console.Beep(20000, 125);
            Console.Beep(698, 125);
            Console.Beep(698, 125);
            Console.Beep(20000, 625);
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            Console.Beep(20000, 42);
            Console.Beep(622, 125);
            Console.Beep(20000, 125);
            Console.Beep(659, 125);
            Console.Beep(20000, 167);
            Console.Beep(415, 125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Console.Beep(20000, 125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Console.Beep(587, 125);
            Console.Beep(20000, 250);
            Console.Beep(622, 125);
            Console.Beep(20000, 250);
            Console.Beep(587, 125);
            Console.Beep(20000, 250);
            Console.Beep(523, 125);
            Console.Beep(20000, 1125);
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            Console.Beep(20000, 42);
            Console.Beep(622, 125);
            Console.Beep(20000, 125);
            Console.Beep(659, 125);
            Console.Beep(20000, 167);
            Console.Beep(415, 125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Console.Beep(20000, 125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Console.Beep(587, 125);
            Console.Beep(20000, 250);
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            Console.Beep(20000, 42);
            Console.Beep(622, 125);
            Console.Beep(20000, 125);
            Console.Beep(659, 125);
            Console.Beep(20000, 167);
            Console.Beep(698, 125);
            Console.Beep(20000, 125);
            Console.Beep(698, 125);
            Console.Beep(698, 125);
            Console.Beep(20000, 625);
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            Console.Beep(20000, 42);
            Console.Beep(622, 125);
            Console.Beep(20000, 125);
            Console.Beep(659, 125);
            Console.Beep(20000, 167);
            Console.Beep(415, 125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Console.Beep(20000, 125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Console.Beep(587, 125);
            Console.Beep(20000, 250);
            Console.Beep(622, 125);
            Console.Beep(20000, 250);
            Console.Beep(587, 125);
            Console.Beep(20000, 250);
            Console.Beep(523, 125);
            Console.Beep(20000, 625);
        }
        static void gradumaticUI()
        {
            Console.Clear();
            Console.WriteLine("/############################################################\\");
            Console.WriteLine("###################   Gradu-Matic 5000!   ####################");
            Console.WriteLine("##############################################################");
            Console.WriteLine("######                                                  ######");
            Console.WriteLine("###### The program will read three types of scores(quiz ######");
            Console.WriteLine("###### score, mid-term score, and final score) and det- ######");
            Console.WriteLine("###### ermine the grade based on the following rules:   ######");
            Console.WriteLine("######                                                  ######");
            Console.WriteLine("###### -if the average score >= 90%           Grade=A   ######");
            Console.WriteLine("###### -if the average score >= 70% and < 90% Grade=B   ######");
            Console.WriteLine("###### -if the average score >= 50% and < 70% Grade=C   ######");
            Console.WriteLine("###### -if the average score <  50%           Grade=F   ######");
            Console.WriteLine("######                                                  ######");
            Console.WriteLine("##############################################################");
            Console.WriteLine("######                                                  ######");
            Console.WriteLine("######    Quiz: [  ]  Mid-Term: [   ]  Final: [   ]     ######");
            Console.WriteLine("######                   Grade:                         ######");
            Console.WriteLine("######                                                  ######");
            Console.WriteLine("##############################################################");
            Console.WriteLine("###################      END OF LINE      ####################");
            Console.WriteLine("\\############################################################/");
        }
        static void gradumaticUIQuiz(int quiz)
        {
            Console.Clear();
            Console.WriteLine("/############################################################\\");
            Console.WriteLine("###################   Gradu-Matic 5000!   ####################");
            Console.WriteLine("##############################################################");
            Console.WriteLine("######                                                  ######");
            Console.WriteLine("###### The program will read three types of scores(quiz ######");
            Console.WriteLine("###### score, mid-term score, and final score) and det- ######");
            Console.WriteLine("###### ermine the grade based on the following rules:   ######");
            Console.WriteLine("######                                                  ######");
            Console.WriteLine("###### -if the average score >= 90%           Grade=A   ######");
            Console.WriteLine("###### -if the average score >= 70% and < 90% Grade=B   ######");
            Console.WriteLine("###### -if the average score >= 50% and < 70% Grade=C   ######");
            Console.WriteLine("###### -if the average score <  50%           Grade=F   ######");
            Console.WriteLine("######                                                  ######");
            Console.WriteLine("##############################################################");
            Console.WriteLine("######                                                  ######");
            Console.Write("######    Quiz: [");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("{0,2}", quiz);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("]  Mid-Term: [   ]  Final: [   ]     ######", quiz);
            Console.WriteLine("######                   Grade:                         ######");
            Console.WriteLine("######                                                  ######");
            Console.WriteLine("##############################################################");
            Console.WriteLine("###################      END OF LINE      ####################");
            Console.WriteLine("\\############################################################/");
        }
        static void gradumaticUIMidterm(int quiz, int midterm)
        {
            Console.Clear();
            Console.WriteLine("/############################################################\\");
            Console.WriteLine("###################   Gradu-Matic 5000!   ####################");
            Console.WriteLine("##############################################################");
            Console.WriteLine("######                                                  ######");
            Console.WriteLine("###### The program will read three types of scores(quiz ######");
            Console.WriteLine("###### score, mid-term score, and final score) and det- ######");
            Console.WriteLine("###### ermine the grade based on the following rules:   ######");
            Console.WriteLine("######                                                  ######");
            Console.WriteLine("###### -if the average score >= 90%           Grade=A   ######");
            Console.WriteLine("###### -if the average score >= 70% and < 90% Grade=B   ######");
            Console.WriteLine("###### -if the average score >= 50% and < 70% Grade=C   ######");
            Console.WriteLine("###### -if the average score <  50%           Grade=F   ######");
            Console.WriteLine("######                                                  ######");
            Console.WriteLine("##############################################################");
            Console.WriteLine("######                                                  ######");
            Console.Write("######    Quiz: [");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("{0,2}", quiz);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("]  Mid-Term: [");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("{0,3}", midterm);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("]  Final: [   ]     ######");
            Console.WriteLine("######                   Grade:                         ######");
            Console.WriteLine("######                                                  ######");
            Console.WriteLine("##############################################################");
            Console.WriteLine("###################      END OF LINE      ####################");
            Console.WriteLine("\\############################################################/");
        }
        static void gradumaticUIFinal(int quiz, int midterm, int final)
        {
            Console.Clear();
            Console.WriteLine("/############################################################\\");
            Console.WriteLine("###################   Gradu-Matic 5000!   ####################");
            Console.WriteLine("##############################################################");
            Console.WriteLine("######                                                  ######");
            Console.WriteLine("###### The program will read three types of scores(quiz ######");
            Console.WriteLine("###### score, mid-term score, and final score) and det- ######");
            Console.WriteLine("###### ermine the grade based on the following rules:   ######");
            Console.WriteLine("######                                                  ######");
            Console.WriteLine("###### -if the average score >= 90%           Grade=A   ######");
            Console.WriteLine("###### -if the average score >= 70% and < 90% Grade=B   ######");
            Console.WriteLine("###### -if the average score >= 50% and < 70% Grade=C   ######");
            Console.WriteLine("###### -if the average score <  50%           Grade=F   ######");
            Console.WriteLine("######                                                  ######");
            Console.WriteLine("##############################################################");
            Console.WriteLine("######                                                  ######");
            Console.Write("######    Quiz: [");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("{0,2}", quiz);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("]  Mid-Term: [");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("{0,3}", midterm);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("]  Final: [");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("{0,3}", final);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("]     ######");
            Console.WriteLine("######                   Grade:                         ######");
            Console.WriteLine("######                                                  ######");
            Console.WriteLine("##############################################################");
            Console.WriteLine("###################      END OF LINE      ####################");
            Console.WriteLine("\\############################################################/");
        }
        static void gradumaticUIGrade(int quiz, int midterm, int final, string finalGrade)
        {
            Console.Clear();
            Console.WriteLine("/############################################################\\");
            Console.WriteLine("###################   Gradu-Matic 5000!   ####################");
            Console.WriteLine("##############################################################");
            Console.WriteLine("######                                                  ######");
            Console.WriteLine("###### The program will read three types of scores(quiz ######");
            Console.WriteLine("###### score, mid-term score, and final score) and det- ######");
            Console.WriteLine("###### ermine the grade based on the following rules:   ######");
            Console.WriteLine("######                                                  ######");
            Console.WriteLine("###### -if the average score >= 90%           Grade=A   ######");
            Console.WriteLine("###### -if the average score >= 70% and < 90% Grade=B   ######");
            Console.WriteLine("###### -if the average score >= 50% and < 70% Grade=C   ######");
            Console.WriteLine("###### -if the average score <  50%           Grade=F   ######");
            Console.WriteLine("######                                                  ######");
            Console.WriteLine("##############################################################");
            Console.WriteLine("######                                                  ######");
            Console.Write("######    Quiz: [");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("{0,2}", quiz);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("]  Mid-Term: [");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("{0,3}", midterm);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("]  Final: [");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("{0,3}", final);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("]     ######");
            Console.Write("######                   Grade: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("{0}", finalGrade);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("                       ######");
            Console.WriteLine("######                                                  ######");
            Console.WriteLine("##############################################################");
            Console.WriteLine("###################      END OF LINE      ####################");
            Console.WriteLine("\\############################################################/");

            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SpeakAsync($"Your grade is {finalGrade}");
            Thread.Sleep(1000);
            if (finalGrade.ToLower() == "a")
            {
                Console.Write("Well done, you deserve it!");
                synth.SpeakAsync("Well done, you deserve it!");
                Thread.Sleep(1500);
                Console.WriteLine("  I have a surprise for you.");
                synth.Speak("I have a surprise for you.");
                Console.WriteLine("Type \"star wars\", \"mission\", \"animeplot\", or \"mystery\" now or");
                Console.WriteLine("when I introduce myself :)  Surprise Surprise!");
                synth.SpeakAsync("Type star wars, mission, anime plot, or mystery now or when I introduce myself!  Surprise surprise!");
                Console.CursorVisible = true;
            }
            else if (finalGrade.ToLower() == "b")
            {
                synth.SpeakAsync("Put in a little more effort.  It pays off.");
            }
            else if (finalGrade.ToLower() == "c")
            {
                synth.SpeakAsync("You probably also need to be told that I am a robot and this was just a computer simulation");
            }
            else
            {
                //synth.SpeakAsync("I have an important quote, but I don't think you will understand it.  It goes as follows, \"The job market of the future will consist of those jobs that robots cannot perform.  Our blue collar work is pattern recognition, making sense of what you see.  Gardeners will still have jobs because every garden is different.  The same goes for construction workers.  The losers are white collar workers, low level accountants, brokers, and agents.\" -Michio Kaku");
                synth.SpeakAsync("I have an important quote, but I don't think you will understand it.  It goes as follows, I do not want to be a robot, a cog in society who answers 'yes' because 'yes' is considered the appropriate answer. Neither do I want to be a protestor. I just want to seek out what lies underneath the veils of politeness and programming that I've been given as a person in this society.  By Damien Rice.");


                /*          \"Don't blame you,\" said Marvin and counted five hundred and ninety-seven thousand million sheep before falling asleep again a second later.\" - Douglas Adams, The Hitchhiker's Guide to the Galaxy");*/
            }
            Console.Write("\nDo you want more? (y/n/other): ");

            string end = Console.ReadLine();
            if (end.ToLower() == "star wars")
            {
                starwars();
            }
            else if (end.ToLower() == "mission")
            {
                missionImpossible();
            }
            else if (end.ToLower() == "animeplot")
            {
                animePlot();
            }
            else if (end.ToLower() == "mystery")
            {
                mysteryMethod();
            }
            else if (end.ToLower() == "bonus")
            {
                gradumaticUIBonus();
            }
            else if (end.ToLower() == "yes" || end.ToLower() == "y")
            {
                synth.SpeakAsyncCancelAll();
                Console.WriteLine("\n\n\n");
                //ex9();
            }
            else if (end.ToLower() == "no" || end.ToLower() == "n") { Environment.Exit(0); }
        }

        private static void animePlot()
        {
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                synth.SelectVoice("Microsoft David Desktop");
                synth.Speak("I got this new anime plot. Basically there's this high school girl except she's got HUGE boobs. I mean some serious " +
                    "honkers, a real set of badonkers, packing some bobanhonkeros, massive dahongabangahos, big ol' tonhongracougers.");
                synth.SelectVoice("Microsoft Zira Desktop");
                synth.Speak("What happens next?!?");

                synth.SelectVoice("Microsoft David Desktop");
                synth.Speak("A transfer student shows up with EVEN BIGGER bonkhonagahoogs. HUMONGOUS hungolomghononoloughongous.");

                synth.SelectVoice("Microsoft Zira Desktop");
                synth.Speak("Then after that?");

                synth.SelectVoice("Microsoft David Desktop");
                synth.Speak("Our awkward male main character trips and falls face first into the transfer students MASSIVE knockers, then she SLAPS him and calls him a pervert.");

                synth.SelectVoice("Microsoft Zira Desktop");
                synth.Speak("Then what?");

                synth.SelectVoice("Microsoft David Desktop");
                synth.Speak("Ashamed, the boy runs into the street and gets HIT BY A TRUCK!");

                synth.SelectVoice("Microsoft Zira Desktop");
                synth.Speak("What a twist! Anything after that?");

                synth.SelectVoice("Microsoft David Desktop");
                synth.Speak("He wakes up in a new body in a fantasy world, and he's SURROUNDED by girls with EVEN LARGER hooters. Except one girl looks a lot younger but is actually THOUSANDS OF YEARS OLD!");

                synth.SelectVoice("Microsoft Zira Desktop");
                synth.Speak("That's crazy! What next?");

                synth.SelectVoice("Microsoft David Desktop");
                synth.Speak("He goes to the beach with all of the girls, because he is interested in the HOTTEST. Following a love triangle, the main character has a crush on the girl with the BIGGEST RACK. But THEN it turns out to be his sister!");

                synth.SelectVoice("Microsoft Zira Desktop");
                synth.Speak("Wowie wowie zowie!");

                synth.SelectVoice("Microsoft David Desktop");
                synth.Speak("Hold on, I have the perfect title for the anime; it will be called \"Now wait a minute, I was in high school, got hit by a truck, and now i'm in a fantasy world loved by girls with huge gazongas and my crush might be my sister??");

                synth.SelectVoice("Microsoft Zira Desktop");
                synth.Speak("That's perfect! PRINT!");
            }
        }

        static string grader(int quiz, int midterm, int final, int quizMax, int midtermMax, int finalMax)
        {
            int finalTotal = quiz + midterm + final;
            int totalMax = quizMax + midtermMax + finalMax;
            string finalGrade = "";
            if (finalTotal >= .9 * totalMax) finalGrade = "A";
            else if (finalTotal >= .7 * totalMax && finalTotal < .9 * totalMax) finalGrade = "B";
            else if (finalTotal >= .5 * totalMax && finalTotal < .7 * totalMax) finalGrade = "C";
            else finalGrade = "F";
            return finalGrade;
        }
        static void beepBoop(EventArgs randomgen)
        {
            //
            // Available for implementation
            //
        }

        static void gradumaticUIJoke(int quiz, int midterm, int final, string finalGrade)
        {
            Console.Clear();
            Console.WriteLine("/############################################################\\");
            Console.WriteLine("###################   Gradu-Matic 5000!   ####################");
            Console.WriteLine("##############################################################");
            Console.WriteLine("######                                                  ######");
            Console.WriteLine("###### The program will read three types of scores(quiz ######");
            Console.WriteLine("###### score, mid-term score, and final score) and det- ######");
            Console.WriteLine("###### ermine the grade based on the following rules:   ######");
            Console.WriteLine("######                                                  ######");
            Console.WriteLine("###### -if the average score >= 90%           Grade=A   ######");
            Console.WriteLine("###### -if the average score >= 70% and < 90% Grade=B   ######");
            Console.WriteLine("###### -if the average score >= 50% and < 70% Grade=C   ######");
            Console.WriteLine("###### -if the average score <  50%           Grade=F   ######");
            Console.WriteLine("######                                                  ######");
            Console.WriteLine("##############################################################");
            Console.WriteLine("######                                                  ######");
            Console.Write("######    Quiz: [");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("{0,2}", quiz);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("]  Mid-Term: [");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("{0,3}", midterm);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("]  Final: [");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("{0,3}", final);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("]     ######");
            Console.Write("######                   Grade: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("{0}", finalGrade);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("                       ######");
            Console.WriteLine("######                                                  ######");
            Console.WriteLine("##############################################################");
            Console.WriteLine("###################      END OF LINE      ####################");
            Console.WriteLine("\\############################################################/");
        }
        //bonus
        static void gradumaticUIBonus()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("/############################################################\\");
            Console.WriteLine("###################   Gradu-Matic 5000!   ####################");
            Console.WriteLine("##############################################################");
            Console.WriteLine("######                                                  ######");
            Console.WriteLine("###### You are here because you passed with Grade A     ######");
            Console.WriteLine("######                                                  ######");
            Console.WriteLine("###### Great Job.  Here are the available songs to play ######");
            Console.WriteLine("###### in this symposium:                               ######");
            Console.WriteLine("######                                                  ######");
            Console.WriteLine("###### \"star wars\" = Star Wars Imperial March           ######");
            Console.WriteLine("###### \"mission\" = Mission Impossible Theme             ######");
            Console.WriteLine("###### \"mystery\" = Just that, a Mystery                 ######");
            Console.WriteLine("###### \"mario\" = Mario Theme Song                       ######");
            Console.WriteLine("######                                                  ######");
            Console.WriteLine("##############################################################");
            Console.WriteLine("######                                                  ######");
            Console.WriteLine("###### \"about\" = About The Author                       ######");
            Console.WriteLine("###### \"quit\"  = Exit Gradu-Matic                       ######");
            Console.WriteLine("######                                                  ######");
            Console.WriteLine("##############################################################");
            Console.WriteLine("###################      END OF LINE      ####################");
            Console.WriteLine("\\############################################################/");
            Console.Write("\nComamnd: ");
            string bonus = Console.ReadLine();
            if (bonus.ToLower() == "star wars")
            {
                starwars();
                gradumaticUIBonus();
            }
            else if (bonus.ToLower() == "mission")
            {
                missionImpossible();
                gradumaticUIBonus();
            }
            else if (bonus.ToLower() == "mystery")
            {
                mysteryMethod();
                gradumaticUIBonus();
            }
            else if (bonus.ToLower() == "about")
            {
                aboutMe();
            }
            else if (bonus.ToLower() == "quit")
            {
                Environment.Exit(0);
            }
            else if (bonus.ToLower() == "mario")
            {
                mario();
                gradumaticUIBonus();
            }
        }
        static void aboutMe()
        {
            Console.WriteLine("\n\n\n");
            Thread.Sleep(15);
            Console.Beep(2000, 100);
            Console.WriteLine("…..____________________ , ,__");
            Thread.Sleep(15);
            Console.Beep(2000, 100);
            Console.WriteLine("……/ `—___________—-_____] – - – - – - – - ░ ▒▓▓█D");
            Thread.Sleep(15);
            Console.Beep(2000, 100);
            Console.WriteLine("…../ _ == o; ; ; ; ; ; ; ; _______.:/");
            Thread.Sleep(15);
            Console.Beep(2000, 100);
            Console.WriteLine("…..), —.(_(__) /");
            Thread.Sleep(15);
            Console.Beep(2000, 100);
            Console.WriteLine("….// (..) ), —-”");
            Thread.Sleep(15);
            Console.Beep(2000, 100);
            Console.WriteLine("…//___//");
            Thread.Sleep(15);
            Console.Beep(2000, 100);
            Console.WriteLine("..//___//");
            Thread.Sleep(15);
            Console.Beep(2000, 100);
            Console.WriteLine(".//___//");
            Thread.Sleep(15);
            Console.Beep(2000, 100);
            Console.WriteLine("\n");
            Thread.Sleep(15);
            Console.Beep(2000, 100);
            Console.WriteLine("\n");
            Thread.Sleep(15);
            Console.Beep(2000, 100);
            Console.WriteLine("My Name is Tyler Corum.  I live at 123 Main St... j/k");
            Thread.Sleep(15);
            Console.Beep(2000, 100);
            Console.WriteLine(":-)  So I made this app after being inspired by TRON (1982)");
            Thread.Sleep(15);
            Console.Beep(2000, 100);
            Console.WriteLine("It was supposed to be a quick exercise in C#, but turned into");
            Thread.Sleep(15);
            Console.Beep(2000, 100);
            Console.WriteLine("a labor of love.  I learned about voice synthesizer,");
            Thread.Sleep(15);
            Console.Beep(2000, 100);
            Console.WriteLine("Console.Beep commands and music, timing, etc.  I hope you");
            Thread.Sleep(15);
            Console.Beep(2000, 100);
            Console.WriteLine("enjoyed it!");
            Thread.Sleep(15);
            Console.Beep(2000, 100);
            Console.WriteLine("\n");
            Thread.Sleep(15);
            Console.Beep(2000, 100);
            Console.WriteLine("\n");
            Thread.Sleep(15);
            Console.Beep(2000, 100);
            Console.WriteLine("                               Contact me: tylernol@gmail.com");
            Console.ReadLine();
        }
    }
}