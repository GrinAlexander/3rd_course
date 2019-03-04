using GameFramework.GameStructure;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PennyReaction : MonoBehaviour
{
   // public GameObject blood;
   public ParticleSystem particleSystem;
    private float time = 3;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            while (time != 0)
            {
                time -= Time.timeScale;
            }
            particleSystem.Play();
            Destroy(gameObject);
           // Application.LoadLevel(Application.loadedLevel);
        }
    }
}