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

            int result1 = Program.GetValidAnswer(testAnswers);
            int expected3 = 1;

            if (result1 != expected3)
            {
                Console.Error.WriteLine($"Failure: Expected result to be Myself but it was {result1}");
                return false;
            }

            
            
            return true;
        }
    }
}