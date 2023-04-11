using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control2 : MonoBehaviour
{
    public static float velocity = .01f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            velocity = .07f;
        }
        else
        {
            if (Input.GetKeyUp(KeyCode.Q))
            {
                velocity = .01f;
            }
        }
    }
}
