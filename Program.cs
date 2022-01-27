using System;

namespace slu_personal_project_proposal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

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

        static int GetValidAnswer (List <string> answers)
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
            return -1;
        }


    }
}

