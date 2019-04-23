using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSecondScene : MonoBehaviour
{
	private void Update()
	{
		LoadScene();
	}
	public void LoadScene()
	{
		if (Input.GetKey(KeyCode.Alpha1))
		{
			SceneManager.LoadScene("First");
		}
		if (Input.GetKey(KeyCode.Alpha2))
		{
			SceneManager.LoadScene("Second");
		}
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Second");
        }

    }
}
