using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindChallengeScoreScript : MonoBehaviour
{
    public string courseName;
    public int modules;
    public int readings;
    public int quizzes;
    public int assignments;
    public bool taughtCourse;

    // Start is called before the first frame update
    void Start()
    {
        //operating under the assumption that a course is 10 weeks long, and there are the same number of different tasks each week

        double challengeScore;

        //calculate how much weight all of the different tasks have in the course
        double moduleScore = (modules / 10.0) * 0.15;
        Debug.Log("The module score is " + moduleScore);

        double readingScore = (readings / 10.0) * 0.3;
        Debug.Log("The reading score is " + readingScore);

        double quizScore = (quizzes / 10.0) * 0.15;
        Debug.Log("The quiz score is " + quizScore);

        double assignmentScore = (assignments / 10.0) * 0.3;
        Debug.Log("The assignment score is " + assignmentScore);

        //checking to see if the teacher taught the course before
        double taughtCourseScore = 0.0;

        if(taughtCourse == true){

            taughtCourseScore = 0.1;

        }
        Debug.Log("The taught course score is " + taughtCourseScore);

        //calculate the final challenge score. Also check to make sure we stay within out set bounds
        challengeScore = (moduleScore + readingScore + quizScore + assignmentScore + taughtCourseScore) * 10;

        if(challengeScore > 10){

            challengeScore = 10;

        }

        else if(challengeScore < 1){

            challengeScore = 1;

        }

        Debug.Log("The challenge score for this course is " + challengeScore);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
