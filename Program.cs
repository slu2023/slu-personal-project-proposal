using System;
using System.Collections.Generic; // Feedback(jcollard 2022-01-27): This line makes it so you can use the List data type.

namespace slu_personal_project_proposal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Checks if the user added a command line argument
            // Also checks if the first argument is "test"
            if (args.Length > 0 && args[0] == "test")
            {
                TestAll();
                return; // Exits the program
            }
            // Otherwise, the program continues executing
            // Feedback(jcollard 2022-01-27): 
            // Here is an example of how you would create a question:

            // First create a new Question()
            Question simpleQuestion = new Question();

            // Next, set the question to be an actual question.
            simpleQuestion.question = "How much wood could a woodchuck chuck if a woodchuck could chuck wood?";

            // Next, add answers to the question
            simpleQuestion.answers.Add("As much wood as a woodchuck could chuck if a woodchuck could chuck wood.");
            simpleQuestion.answers.Add("Uh... 14?");
            simpleQuestion.answers.Add("None. Clearly the woodchuck is a manifestation of all your fears.");

            // Finally, you can display the question and answers
            Console.WriteLine(simpleQuestion.question);

            // For your final solution, you will loop through these rather than manually selecting each one.
            Console.WriteLine($"1. {simpleQuestion.answers[0]}");
            Console.WriteLine($"2. {simpleQuestion.answers[1]}");
            Console.WriteLine($"3. {simpleQuestion.answers[2]}");


        }

        public static void TestAll()
        {
            bool testPersonalityQuiz = TestPersonalityQuiz.RunTest();
            Console.WriteLine($"Test PersonalityQuiz(filename); {testPersonalityQuiz}");

            bool testAskQuestion = TestAskQuestion.RunTest();
            Console.WriteLine($"Test AskQuestion(options); {testAskQuestion}");

            bool testGetValidAnswer = TestGetValidAnswer.RunTest();
            Console.WriteLine($"Test GetValidAnswer(options); {testGetValidAnswer}");

            bool testGetResult = TestGetResult.RunTest();
            Console.WriteLine($"Test GetResult(options); {testGetResult}");
        }

        /// <summary>
        /// The player has a score of 0 at the beginning 
        /// Looping until all the questions has been displayed to the user
        /// Get the player to answer the questions
        /// Determine the score base on the answer the player gives
        /// </summary>
        /// <param name="prompt">The message to display to the user</param>
        /// <returns>The positive number the user chose</returns>        
        public static string PersonalityQuiz()
        {

            // 1. Initialize each score to be 0
            // 2. Create a list of question objects
            // 3. Loop through each question
            //    *If there are more questions, we should go back to loop through each question
            //    *Otherwise display the result calculated by the score refering to the characters
            // 4. Prompt user to answer the question
            // 5. Use the user's answer to increase on of the score
            return null;
        }

        /// <summary>
        /// Given a series of questions to the user, score the points when the player enters an answer.  
        /// Looping until all the questions has been displayed and answered.
        /// </summary>
        /// <param name="prompt">The message to display to the user</param>
        /// <returns>The positive number the user chose</returns>
        public static int AskQuestion(Question q)
        {

            // 1. Display q.Question
            // 2. Loop through for each answer in q.Question
            // 3. Display answer
            // 4. Shows int selected = GetValidAnswer(q.Answers)
            return 1;
        }


        /// <summary>
        /// Storing the valid answers from the player
        /// Score the points according to the play's response.
        /// </summary>
        /// <param name="prompt">The message to display to the user</param>
        /// <returns>The positive number the user chose</returns>
        public static int GetValidAnswer(List<string> Answers)
        {
            // * If answers.Length < 1, disply "select an option 1 to {answers.Length}".  int choice = int.Parse(ReadLine())
            // ** If Choice > 0 AND Choice < = answers.Length, return choice
            // ** Otherwise, display "Invalid choice"
            // * Otherwise, throw new Exception ("Must have at least one answer.")
            return -1;
        }

        /// <summary>
        /// Display the score the play gets.
        /// </summary>
        /// <param name="prompt">The message to display to the user</param>
        /// <returns>The positive number the user chose</returns>
        public static string GetResult(List<int> Scores, List<string> Results)
        {
            // 1. int highest = 0
            // 2. int highest lx = 0
            // 3. int current lx = 0
            // 4. * If currect lx < Scores.Length, display int score = Scores[currlx]
            //    ** If Score > highest, highest = Score, and highestlx = Currlx, therefore Currlx = Currlx +1
            //    ** Otherwise, Currlx = Currlx + 1
            //    * Otherwise, return Results[highestlx]
            return "Black Widow";
        }
    }

    // Feedback(jcollard 2022-01-27): I've added in the Question class for you.
    // This class stores both a question string and a list of answers together!
    public class Question
    {
        public string question;
        public List<string> answers = new List<string>();
    }
}

