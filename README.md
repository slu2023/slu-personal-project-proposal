# Personality Quiz

## Description

This Personality Quiz will help you determine which NARUTO character you are! Are you more of a INSERT MAIN CHARACTER'S NAME or are you secretly a INSERT VILLAIN NAME HERE? Take this quiz to find out today!

## Purpose

The purpose of the Personality Quiz is to provide entertainment to the user. The program outputs questions to the user and accepts their answer as input via the keyboard. Finally, at the end of the quiz, the program displays the result of the quiz.

## High Level Design

At a high level, the Personality Quiz works in the following way:

1. Initializes a list of scores to 0 (each score represents one of the possible outcomes)
   
2. Creates a list of questions and answers (each possible answer will increase one of the scores by 1)
   
3. Loops through each question and 
   
   1. Prompts the user to answer the question
   2. Increases the appropriate score by 1
   
4. When all of the questions have been answered, use the highest score to display the result of the quiz.

## Flowchart

![Image Text](FLOWCHART.png)

## Methods

static int AskQuestion(Question);
static int GetValidAnswer(List<string>answer);
static string GetResult(List<int>scores,);
List<string> results);

### Question Class

It is important for this program to group together questions and answers.  To manage this, there's a class being created and has two properties.  A string Question, which will be the question being asked and a List<string> Answers, which will be a list of the possible answers to that questions.

![Image Text](Question.png)

### static int AskQuestion(Question q)

DisplayDisplays the specified question along with each of its answers. Then, prompts the user to select one of the answers. Finally, returns the index of the answer the player selected.

![Image Text](AskQuestion.png)

1. Display the question.
   
2. Loop through each answer and display it.
   
3. Use the GetValidAnswer method to get the user's response.
   
4. Return the user's response

### static int GetValidAnswer(List answers)

Given a list of answers, prompts the user to enter a number corresponding to one of the answers. If the user enters a number that is not within the specified range, the user is asked to enter another value.

![Image Text](GetValidAnswer.png)

1. Validate that there is at least 1 possible answer.
   
2. If the list of answers is empty, throw an exception.
   
3. Otherwise, Display a message asking the user to select an option.
   
4. Store the user's response in a variable name choice
   
5. Validate that choice is one of the possible answers
   
6. If it is not a valid answer
   1. Display an error message
   2. Go to 3
   
7. Otherwise, return the user's choice.

### static string GetResult(List scores, List results);

Given two lists, one representing the scores for each possible result and one representing each possible result, determines which score is the highest and returns the corresponding string from the results list.

![Image Text](GetResult.png)

1. Initialize highest to 0. This variable represents the highest score we have seen so far.
   
2. Initialize highestIx to 0. This variable represents the index of the highest score we have seen so far.
   
3. Loop through each score in scores, tracking the index in a variable currentIx
   - If the score is greater than the highest score
     + Update highest to store the score (this is the highest score we have seen so far)
     + Update highestIx to store the currentIx (this is the index of the highest score we have seen so far)
  
4. After we have checked each score, highestIx should be the index of the highest score.
   
5. return results[highestIx];