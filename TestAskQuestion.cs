using System;
using System.IO;

namespace slu_personal_project_proposal
{
    class TestAskQuestion
    {
        public static bool RunTest()
        {
            // TODO(jcollard 2022-02-01): These look great.
            // Now, figure out how to call your methods. In this case you would do the following:
            //
            // 1. Start by setting up a Question object
            // We do this because your method AskQuestion takes 1 parameter which must be a Question
            
            List<string> options = new List<string>();
            Question testQuestion = new Question();
            testQuestion.question = "Some question here";
            testQuestion.answers.Add("Some answer");
            testQuestion.answers.Add("Some other8 answer");
            
            // Then, create a message to be displayed to the tester. What should the method
            // write to the console when you pass testQuestion as an argument?
            //
            
            Console.WriteLine("Expected: the output to contain 3 options.");
            Console.WriteLine("First type 4. This should be an invalid option. It will ask again.");
            Console.WriteLine("Next type 1. This should be a valid option. By selecting 1, the method should return 1.")
            
            int result = Program.AskQuestion(options);
            
            // Then we check that the result is equal to 1 because that is what we told the tester to enter.
            // 
            // Think of a few more tests you could do. What should happen if the question has no answers?
            // What should happen if the question has more than 3 answers?
            
            Console.WriteLine($"The method returned {result}.");
            Console.WriteLine("Does this method appear to be working?");
            
            return false;

            // // Load test_scores.txt.

            // List<string> scores = Program.AskQuestion("test_scores.txt")..ToList();

            // // This file contains 3 lines
            // if(scores.Count !=3)
            // {
            //     Console.Error.WriteLine("The file test_scores should have 3 lines but that was not the cases.");
            //     return false;
            // }

            // // The first line of the file should be "TestQuestion"
            // if(scores[0] !="TestQuestion")
            // {
            //     Console.Error.WriteLine("The first file should have been \"QuestionFirst\".");
            //     return false;
            // }

            // try
            // {
            //     // This should produce an exception
            //     Program.AskQuestion("NotAFile.txt");

            //     // If we get to this line, it means there was not an exception
            //     Console.Error.WriteLine("Expected an exception from loading \"NotAFile.txt\"");
            //     return false;
            // }
            // catch (Exception e)
            // {
            //     // Ignore the error
            // }

            // // If we made it this far, everything seems to be working so we return true.
            // return true;
        }
    }
}