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
            

            // TODO(jcollard 2022-02-03): You need to import the list library to use List.
            // Add using `using System.Collections.Generic;` to the top of this file
            // That said, I don't think you actually need this list here.
            List<string> options = new List<string>();
            Question testQuestion = new Question();
            testQuestion.question = "Some question here";
            testQuestion.answers.Add("Some answer");
            testQuestion.answers.Add("Some other answer");
            
            // Then, create a message to be displayed to the tester. What should the method
            // write to the console when you pass testQuestion as an argument?
            //
            
            Console.WriteLine("Expected: the output to contain 3 options.");
            Console.WriteLine("First type 4. This should be an invalid option. It will ask again.");
            Console.WriteLine("Next type 1. This should be a valid option. By selecting 1, the method should return 1.");
            
            // TODO(jcollard 2022-02-03): The error here is saying it cannot find the `AskQuestion` method. You need to do
            // 2 things to fix this:
            //
            // 1. In Program.cs you need to add `public` in front of the AskQuestion method. In this case you need to change
            //    it to `public static int AskQuestion(Question q)`. The keyword public specifies that you would like that method
            //    to be accessible in other files
            //
            // 2. The AskQuestion method expects to be passed a `Question`. `options` is a `List<string>`. Instead, you want
            //    to change this to `AskQuestion(testQuestion)`. The type of testQuesiton is `Question` which is what AskQuestion
            //    expects.
            int result = Program.AskQuestion(options);
            
            // Then we check that the result is equal to 1 because that is what we told the tester to enter.
            // 
            // Think of a few more tests you could do. What should happen if the question has no answers?
            // What should happen if the question has more than 3 answers?
            
            Console.WriteLine($"The method returned {result}.");
            Console.WriteLine("Does this method appear to be working?");
            
            return false;

            // Load test_scores.txt.

            List<string> scores = Program.AskQuestion("test_scores.txt")..ToList();

            // This file contains 3 lines
            if(scores.Count !=3)
            {
                Console.Error.WriteLine("The file test_scores should have 3 lines but that was not the cases.");
                return false;
            }

            // The first line of the file should be "TestQuestion"
            if(scores[0] !="TestQuestion")
            {
                Console.Error.WriteLine("The first file should have been \"QuestionFirst\".");
                return false;
            }

            try
            {
                // This should produce an exception
                Program.AskQuestion("NotAFile.txt");

                // If we get to this line, it means there was not an exception
                Console.Error.WriteLine("Expected an exception from loading \"NotAFile.txt\"");
                return false;
            }
            catch (Exception e)
            {
                // Ignore the error
            }

            // // If we made it this far, everything seems to be working so we return true.
            return true;


        }
    }
}