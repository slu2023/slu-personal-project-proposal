# MadLibs

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

![Image Text](FLOWCHART.epgz)

## Methods

static int AskQuestion(Question);
static int GetValidAnswer(List<string>answer);
static string GetResult(List<int>scores,);
List<string> results);