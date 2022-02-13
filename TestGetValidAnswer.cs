using System;
using System.Collections.Generic;
using System.IO;

namespace slu_personal_project_proposal
{
    class TestGetValidAnswer
    {
        public static bool RunTest()
        {
            // TODO(jcollard 2022-02-03): This can be tested very similarly to AskQuestion.
            // This is because AskQuestion uses this method to get a valid answer.

            // The answer the player types is going to affect the results they are getting.
            
            List<string> testAnswers;

            testAnswers = new List<string>();
            testAnswers.Add("Myself");
            testAnswers.Add("Others");
            testAnswers.Add("idk");

            // TODO(jcollard 2022-02-10): For this type of test, you need to provide user instructions
            // for what they expect to see and what they should enter. For example:

            Console.WriteLine("1. Enter 7. This will be an invalid input.");
            Console.WriteLine("2. Enter 2. This will be valid");

            int result = Program.GetValidAnswer(testAnswers);
            int expected = 1;

            if (result != expected)
            {
                Console.Error.WriteLine($"Failure: Expected result to be {expected} but it was {result}");
                return true;
            }

            List<string> testAnswers1;

            testAnswers1 = new List<string>();
            testAnswers1.Add("UNO");
            testAnswers1.Add("BIO");
            testAnswers1.Add("TRI");
            testAnswers1.Add("4+");

            // TODO(jcollard 2022-02-10): Give instructions to your testser

            Console.WriteLine("1. Enter 0. This will be an invalid input.");
            Console.WriteLine("2. Enter 4. This will be valid");

            int result1 = Program.GetValidAnswer(testAnswers);
            int expected1 = 0;

            if (result1 != expected1)
            {
                Console.Error.WriteLine($"Failure: Expected result to be {expected1} but it was {result1}");
                return true;
            }

            List<string> testAnswers2;

            testAnswers2 = new List<string>();
            testAnswers2.Add("≤13");
            testAnswers2.Add("13-25");
            testAnswers2.Add("≥25");

            // TODO(jcollard 2022-02-10): Give instructions to your testser

            Console.WriteLine("1. Enter -1. This will be an invalid input.");
            Console.WriteLine("2. Enter 1. This will be valid");

            int result2 = Program.GetValidAnswer(testAnswers);
            int expected2 = 1;

            if (result2 != expected2)
            {
                Console.Error.WriteLine($"Failure: Expected result to be {expected2} but it was {result2}");
                return false;
            }
            
            return true;
        }
    }
}