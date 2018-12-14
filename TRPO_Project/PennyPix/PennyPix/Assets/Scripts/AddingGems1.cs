using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddingGems : MonoBehaviour {

    public GameObject player;
    public GameObject gem;
    public UnityEngine.UI.Text text;

	void Update () {
	}

    private void OnTriggerEnter2D()
    {
        int counter = 0;
        text.text = counter.ToString();
        if (player.GetComponent<Collider>() == gem.GetComponent<Collider>())
        {
            counter++;
            text.text = counter.ToString();
        }
    }
}
