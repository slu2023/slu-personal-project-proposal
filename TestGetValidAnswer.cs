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
                Console.Error.WriteLine($"Failure: Expected result to be Myself but it was {result}");
                return true;
            }

            List<string> testAnswers1;

            testAnswers1 = new List<string>();
            testAnswers1.Add("Myself");
            testAnswers1.Add("Others");
            testAnswers1.Add("idk");

            // TODO(jcollard 2022-02-10): Give instructions to your testser

            int result1 = Program.GetValidAnswer(testAnswers);
            int expected1 = 0;

            if (result1 != expected1)
            {
                Console.Error.WriteLine($"Failure: Expected result to be Myself but it was {result1}");
                return true;
            }

            List<string> testAnswers2;

            testAnswers2 = new List<string>();
            testAnswers2.Add("Myself");
            testAnswers2.Add("Others");
            testAnswers2.Add("idk");

            // TODO(jcollard 2022-02-10): Give instructions to your testser

            int result2 = Program.GetValidAnswer(testAnswers);
            int expected2 = -1;

            if (result2 != expected2)
            {
                Console.Error.WriteLine($"Failure: Expected result to be Myself but it was {result1}");
                return false;
            }
            
            return true;
        }
    }
}