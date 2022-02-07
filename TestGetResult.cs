using System;
using System.IO;
using System.Collections.Generic;

namespace slu_personal_project_proposal
{
    class TestGetResult
    {
        public static bool RunTest()
        {

            // TODO(jcollard 2022-02-03):
            // For this test, you want to call the GetResult method.
            // 1. First, update GetResult in Program.cs to be public: `public static string GetResult(List<int> Scores, List<string> Results)`
            //
            // This method has 2 parameters List<int> Scores and List<string> Results.
            // The goal of this test is to check and see if this method works as expected.
            // Start by constructing a List<int> to create some test scores:

            // 1. Add `using System.Collections.Generic;` to the top of this file. This will allow you to use the List type.
            // 2. Create a variable called `testScores` that is a list of integers (`List<int>`):

            List<int> testScores;

            // 3. Assign testScores to be a new list of integers:

            testScores = new List<int>();

            // 4. Add a few test values to the list:

            testScores.Add(3);
            testScores.Add(5);
            testScores.Add(1);

            // 5. Create a variable called testResults` that is a list of strings (`List<string>`):

            List<string> testResults;

            // 6. Assign testResults to be a new list of strings:

            testResults = new List<string>();

            // 7. Add a few test values to the list:

            testResults.Add("Spiderman"); // A score of 3 because testScores has 3 in it
            testResults.Add("Black Widow"); // A score of 5 because testScores has a 5 in it
            testResults.Add("The Hulk"); // A score of 1 because testScores has a score of 1 in it

            // 8. Call GetResult and pass the arguments testScores and testResults

            string result = Program.GetResult(testScores, testResults);

            // 9. Check to see if the result was **not** what you expected. In this case, Black Widow should be the winner

            if (result != "Black Widow")
            {
                // 10. If the result is not what we expected, we display a failure message and return false
                Console.Error.WriteLine($"Failure: Expected result to be Black Widow but it was {result}");
                return false;
            }

            // TODO(jcollard 2022-02-03): Write at least 3 more test cases.
            // * What should happen if there is a tie?
            // * What should happen if there are more than 3 possible outcomes?
            // * What other cases might there be?


            

            // TODO(jcollard 2022-02-03): Finally, if all of the results are as expected, you should return true.
            
            List<int> testScores1;

            testScores1 = new List<int>();
            testScores1.Add(20);
            testScores1.Add(35);
            testScores1.Add(41);

            List<string> testResults1;

            testResults1 = new List<String>();
            testResults1.Add("CSP");
            testResults1.Add("CSA");
            testResults1.Add("POST");

            string result1 = Program.GetResult(testScores1, testResults1);

            if (result1 !="POST")
            {
                Console.Error.WriteLine($"Failure: Expected result to be POST, but result was result");
                return false;
            }

            List<int> testScores2;

            testScores1 = new List<int>();
            testScores1.Add(2);
            testScores1.Add(3);
            testScores1.Add(4);

            List<string> testResults2;

            testResults1 = new List<String>();
            testResults1.Add("BOYS");
            testResults1.Add("GIRLS");
            testResults1.Add("CHILDREN");

            string result2 = Program.GetResult(testScores2, testResults2);

            if (result2 !="CHILDREN")
            {
                Console.Error.WriteLine($"Failure: Expected result to be CHILDREN, but result was result");
                return false;
            }

            List<int> testScores3;

            testScores1 = new List<int>();
            testScores1.Add(0);
            testScores1.Add(0);
            testScores1.Add(7);

            List<string> testResults3;

            testResults1 = new List<String>();
            testResults1.Add("SMART");
            testResults1.Add("KIND");
            testResults1.Add("BOTH");

            string result3 = Program.GetResult(testScores3, testResults3);

            if (result3 !="BOTH")
            {
                Console.Error.WriteLine($"Failure: Expected result to be BOTH, but result was result");
                return false;
            }

            List<int> testScores4;

            testScores1 = new List<int>();
            testScores1.Add(17);
            testScores1.Add(18);
            testScores1.Add(15);

            List<string> testResults4;

            testResults1 = new List<String>();
            testResults1.Add("MATH&SCIENCE");
            testResults1.Add("LANGUAGE&HISTORY");
            testResults1.Add("ART&FILM");

            string result4 = Program.GetResult(testScores4, testResults4);

            if (result1 !="LANGUAGE&HISTORY")
            {
                Console.Error.WriteLine($"Failure: Expected result to be LANGUAGE&HISTORY, but result was result");
                return false;
            }

            
            return true;
        }
    }
}