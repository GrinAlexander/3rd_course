using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PennyDeath : MonoBehaviour
{
    public new ParticleSystem particleSystem;
    private float posX, posY, posZ;
    public GameObject Player;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            posX = Player.transform.position.x;
            posY = Player.transform.position.y;
            posZ = Player.transform.position.z;
            particleSystem.transform.position = new Vector3(posX, posY, posZ);
            particleSystem.Play();
            Destroy(Player);
            StartCoroutine(Timer());
        }
    }
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}