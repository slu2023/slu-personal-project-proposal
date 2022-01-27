using System;
using System.Collections.Generic; // Feedback(jcollard 2022-01-27): This line makes it so you can use the List data type.

namespace slu_personal_project_proposal
{
    class Program
    {
        static void Main(string[] args)
        {
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

        // TODO (jcollard 2022-01-27): Add a documentation comment
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

        // TODO (jcollard 2022-01-27): Add a documentation comment
        static int GetValidAnswer (List<string> answers)
        {
            // * If answers.Length < 1, disply "select an option 1 to {answers.Length}".  int choice = int.Parse(ReadLine())
            // ** If Choice > 0 AND Choice < = answers.Length, return choice
            // ** Otherwise, display "Invalid choice"
            // * Otherwise, throw new Exception ("Must have at least one answer.")
            return -1;
        }

        /// <summary>
        /// Given a series of questions to the user, score the points when the player enters an answer.  
        /// Looping until all the questions has been displayed and answered.
        /// Score the points according to the play's response.
        /// Display the score the play gets.
        /// </summary>
        /// <param name="prompt">The message to display to the user</param>
        /// <returns>The positive number the user chose</returns>
        public static int GetPositiveInt(string prompt)
        {
            // TODO (jcollard 2022-01-27): Add step-by-step algorithm comment
            return -1;
        }


    }

    // Feedback(jcollard 2022-01-27): I've added in the Question class for you.
    // This class stores both a question string and a list of answers together!
    class Question 
    {
        public string question;
        public List<string> answers = new List<string>();
    }
}

