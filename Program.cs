
using System;
using System.Collections.Generic; // Feedback(jcollard 2022-01-27): This line makes it so you can use the List data type

namespace slu_personal_project_proposal
{
    class Program
    {
        private static object testQuestion;

        static void Main(string[] args, object testQuestion)
        {
            // Checks if the user added a command line argument
            // Also checks if the first argument is "test"
            if (args.Length > 0 && args[0] == "test")
            {
                TestAll();
                return; // Exits the program
            }

            //Question:
            // Can you help me write an example about how I can loop through all my questions answers and results?

            // TODO(jcollard 2022-02-13):

            // 1. Start by creating a List<Question> to store all of your questions
            // List<Question> allQuestions = new List<Question>();

            List<string> allQuestions = new List<string>();

            // 2. Create a question
            // Question QuizQuesiton = new Question();

            Question Question = new Question();    

            // 3. Specify th eactual question
            // QuizQuesiton.question = "How old are you?";

            Question.question = "How are you feeling today?";

            // 4. Specify the possible answers
            // AgeQuesiton.answers.Add("1. Option 1");
            // AgeQuesiton.answers.Add("2. Option 2");

            object p = testQuestion.answers.Add("GREAT!");
            object p1 = testQuestion.answers.Add("So So");
            object p2 = testQuestion.answers.Add("Kinda ok");

            // 5. Add the question to allQuestions
            // allQuestions.Add(AgeQuesiton);

            allQuestions.Add(testQuestion);

            // 6. Repeat steps 2 - 5 for each question

            // 7. Create a List<int> to track your scores
            // List<int> scores = new List<int>();

            List<int> testScores = new List<int>();

            // 8. Initialize each score to 0
            // scores.Add(0);
            // scores.Add(0); // repeat for each result

            testScores.Add(5);
            testScores.Add(3);
            testScores.Add(1);

            // 9. Loop through each of the questions in your quesiton list

            foreach (Question q in allQuestions)
                //9 a. Ask the question
            {
                int result = AskQuestion(q);

                //9 a. Increase the related result
                testScores[result] = testScores[result] + 1;
            }

            // 10. Create a List<string> of the results
            // List<string> results = new List<string>();
            
            List<string> testResults = new List<string>();

            
            // 11. Add the results to the list
            // results.Add("Banana Guard");;

            testResults.Add("CSP");
            testResults.Add("CSA");
            testResults.Add("POST");

            // 12. Calculate the result

            string finalResult = GetResult(testScores, testResults);

            // 13. Display the final result

            Console.WriteLine($"Your personality is: {finalResult}");
            

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

            // TODO(jcollard 2022-02-10): Implement this method second.
            // Here is an example that is similar to what you need to do:
            // https://jcollard.github.io/IntroToCSharpSite/examples/display-options
            //
            // In your version, you will be looping through `q.answers` rather than `options`
            // After you've displayed all of the options, you need to use `GetValidAnswer` to
            // get the users response.
            // Finally, return the users response.

            // start by validating the input
            if (q == null) throw new ArgumentNullException("List of options may not be null.");
            if (q.answers.Count == 0) throw new ArgumentException("The List of options much contain at least 1 option.");

            // If the input is valid, we continue:

            int ix = 1; // Create a variable to track the index
            foreach (string answer in q.answers)
            {
                Console.WriteLine($"{ix}. {answer}"); //Display the current index and option
                ix = ix + 1; // Increment the index
            }

            int result = GetValidAnswer(q.answers);
            return result;

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

            // Create a variable to store the value the user enters
            int userInput;

            do
            {
                // Asks the user to enter a number
                Console.WriteLine("Enter a number that is positive.");

                // Read the user input into a string
                string input = Console.ReadLine();

                // Try to cover the user input into an integer
                bool isANumber = int.TryParse(input, out userInput);

                if (isANumber == false)
                {
                    // If the user didn't enter an integer, display an invalid input.
                    Console.Error.WriteLine("You did not enter a number.");
                }

                else if (userInput <= 0 || userInput > Answers.Count)
                {
                    Console.WriteLine("Invalid input");
                }
            } while (userInput <= 0 || userInput > Answers.Count);
            // If the userInput is less than 0, we continue the loop

            // Finally, we return the userinput
            return userInput;
        }



        // TODO(jcolalrd 2022-02-10): Implement this method first
        // Here is an example that is similar to what you are doing:
        // https://jcollard.github.io/IntroToCSharpSite/examples/read-input
        //
        // In the example, the code validates the input is greater than 1000.
        // Your solution should validate that the number is greater than 0 and less or equal to Answers.Count



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

            // TODO(jcollard 2022-02-10): Complete this method last Here is an
            // example showing how to use two lists to find data associated
            // between them:
            // https://jcollard.github.io/IntroToCSharpSite/examples/association-list
            //
            // In your example, you will be searching for the highest scoring
            // result rather than the shortest person

            // First, we much validate the inputs to this method
            if (Scores == null || Results == null) throw new Exception ("Scores List and Results list must be non-null.");
            if (Scores.Count == 0) throw new Exception("Cannot process an empty list.");
            if (Results.Count !=Scores.Count) throw new Exception("Scores and Results lists were not the same length.");

            int resultScores = Scores[0];
            string resultResults = Results[0];

            int index = 0;
            foreach (string Result in Results) // TODO(jcollard 2022-02-13): You want to loop through the scores here rather than the results
            {
                if (Scores > resultScores) // TODO(jcollard 2022-02-13): You want to check if score > resultScores
                {
                    resultScores = Scores[index];
                    resultResults = Results[index];
                }
                index = index + 1;
            }

            return resultResults; // TODO(jcollard 2022-02-13): Finally, you should return resultResults
    }

    // Feedback(jcollard 2022-01-27): I've added in the Question class for you.
    // This class stores both a question string and a list of answers together!
    public class Question
    {
        public string question;
        public List<string> answers = new List<string>();
    }
}

