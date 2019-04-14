using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class Frog : MonoBehaviour {

	public Rigidbody2D rb;

    public void ChangeSize()
    {
        rb.transform.Translate(2,2,2);
    }

	void Update () {

		if (Input.GetKeyDown(KeyCode.RightArrow))
			rb.MovePosition(rb.position + Vector2.right);
		else if (Input.GetKeyDown(KeyCode.LeftArrow))
			rb.MovePosition(rb.position + Vector2.left);
		else if (Input.GetKeyDown(KeyCode.UpArrow))
			rb.MovePosition(rb.position + Vector2.up);
		else if (Input.GetKeyDown(KeyCode.DownArrow))
			rb.MovePosition(rb.position + Vector2.down);

	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "Car")
		{
			Debug.Log("WE LOST!");
            Lives.CurrentLives -= 1;
            if (Lives.CurrentLives == 0)
            {
                string path = @"C:\Users\Chase\Desktop\froggerExtract\Frogger-Replica-master\Frogger-Replica-master\FroggerReplica\Assets\scoreSheet.txt.meta";
                string scoreStr = Score.CurrentScore.ToString();
                File.AppendAllText(path, scoreStr);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            
		}
	}
}
