using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Game_Manager : MonoBehaviour
{

    public Question[] questions;
    private static List<Question> unansweredQuestions;
    
    private Question currentQuestion;

    [SerializeField]
    private Text questionText;

    [SerializeField]
    private Text trueAnswerText;

    [SerializeField]
    private float timeBetweenQuestions = 1f;
    void Start()
    {
        
        if (unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            unansweredQuestions = questions.ToList<Question>();
        }

        SetCurrentQuestion();
        
    }

    void SetCurrentQuestion ()
    {
        int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);
        currentQuestion = unansweredQuestions[randomQuestionIndex];

        questionText.text = currentQuestion.question;

        if (currentQuestion.isCorrect)
        {
            trueAnswerText.text = "CORRECT!";
        }

        else
        {
            trueAnswerText.text = "INCORRECT!";
        }
    }

    IEnumerator TransitionToNextQuestion()
    {
        unansweredQuestions.Remove(currentQuestion);
        yield return new WaitForSeconds(timeBetweenQuestions);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void userSelectAnswerOne()
    {
        
        if (currentQuestion.isCorrect)
        {
            
            Debug.Log("Correct");
        }

        else
        {
            Debug.Log("Incorrect");
        }
        Score.scoreValue += 10;
        Number.numberValue += 1;
        Percent.percentValue = 100;
        StartCoroutine(TransitionToNextQuestion());
    }

    public void userSelectAnswerTwo()
    { 
         if (currentQuestion.isCorrect)
         {
            
            Debug.Log("Correct");
         }

        else
        {
            Debug.Log("Incorrect");
        }
        Score.scoreValue += 10;
        Number.numberValue += 1;
        Percent.percentValue = 100;
        StartCoroutine(TransitionToNextQuestion());
    }

    public void userSelectAnswerThree()
    {
        if (currentQuestion.isCorrect)
        {
            
            Debug.Log("Correct");
        }

        else
        {
            Debug.Log("Incorrect");
        }
        Score.scoreValue += 10;
        Number.numberValue += 1;
        Percent.percentValue = 100;
        StartCoroutine(TransitionToNextQuestion());
    }

    public void userSelectAnswerFour()
    {
        if (currentQuestion.isCorrect)
        {
            
            Debug.Log("Correct");
        }

        else
        {
            Debug.Log("Incorrect");
        }
        Score.scoreValue += 10;
        Number.numberValue += 1;
        Percent.percentValue = 100;
        StartCoroutine(TransitionToNextQuestion());
    }

}
