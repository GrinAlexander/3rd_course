using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PennyDeath : MonoBehaviour
{
    public ParticleSystem particleSystem;
    private float posX, posY, posZ;
    public GameObject Player;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            posX = Player.transform.position.x;
            posY = Player.transform.position.y;
            posZ = Player.transform.position.z;
            particleSystem.transform.position = new Vector3(posX, posY, posZ);
            Invoke("RestartLevel", 2.0f);
            particleSystem.Play();
            Destroy(gameObject);
        } 
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}