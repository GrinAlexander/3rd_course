using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : MonoBehaviour
{
    private float posX = 0, posY = 0, posZ = 0;
    public GameObject Player;
    public GameObject Blood;
    // Update is called once per frame
    void Update()
    {
        if (Player != null)
        {
            posX = Player.transform.position.x;
            posY = Player.transform.position.y;
            posZ = Player.transform.position.z;
            Blood.transform.position = new Vector3(posX, posY, posZ);
        }   
        
    }
}
