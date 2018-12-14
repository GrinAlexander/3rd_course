using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadFirstScene : MonoBehaviour
{

	public GameObject player;

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

	private void OnTriggerEnter2D(Collider2D collision)
	{
        if (player.GetComponent<Collider>() == collision.GetComponent<Collider>())
        {
            SceneManager.LoadScene("First");
        }
			
	}
}
