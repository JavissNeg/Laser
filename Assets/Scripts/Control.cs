using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    float varG = 0f;
    float varY = 0f;
    float varX = 0f;
    bool laserMovimentF = false;
    bool laserMovimentG = false;
    bool laserMovimentW = false;
    bool laserMovimentA = false;
    bool laserMovimentS = false;
    bool laserMovimentD = false;
    public static bool MouseStatusL = false;

     
    private void OnMouseDown()
    {
        ControlM.MouseStatusM = false;
        ControlM2.MouseStatusM2 = false;
        MouseStatusL = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (MouseStatusL == true)
        {

            //Move up
            if (Input.GetKeyDown(KeyCode.W))
            {
                laserMovimentW = true;
            }
            else
            {
                if (Input.GetKeyUp(KeyCode.W))
                {
                    laserMovimentW = false;
                }
            }

            if (laserMovimentW == true)
            {
                transform.Translate(new Vector3(varX,varY+ Control2.velocity, 0f));
            }


            //Move down
            if (Input.GetKeyDown(KeyCode.S))
            {
                laserMovimentS = true;
            }
            else
            {
                if (Input.GetKeyUp(KeyCode.S))
                {
                    laserMovimentS = false;
                }
            }

            if (laserMovimentS == true)
            {
                transform.Translate(new Vector3(varX, varY - Control2.velocity, 0f));
            }


            //Move right
            if (Input.GetKeyDown(KeyCode.D))
            {
                laserMovimentD = true;
            }
            else
            {
                if (Input.GetKeyUp(KeyCode.D))
                {
                    laserMovimentD = false;
                }
            }

            if (laserMovimentD == true)
            {
                transform.Translate(new Vector3(varX + Control2.velocity, varY , 0f));
            }

            //Move left
            if (Input.GetKeyDown(KeyCode.A))
            {
                laserMovimentA = true;
            }
            else
            {
                if (Input.GetKeyUp(KeyCode.A))
                {
                    laserMovimentA = false;
                }
            }

            if (laserMovimentA == true)
            {
                transform.Translate(new Vector3(varX - Control2.velocity, varY , 0f));
            }

            //Increase rotation
            if (Input.GetKeyDown(KeyCode.F))
            {
                laserMovimentF = true;
            }
            else
            {
                if (Input.GetKeyUp(KeyCode.F))
                {
                    laserMovimentF = false;
                }
            }

            if (laserMovimentF == true)
            {
                transform.Rotate(new Vector3(0f, 0f, varG + Control2.velocity));
            }


            //Decrease rotation
            if (Input.GetKeyDown(KeyCode.G))
            {
                laserMovimentG = true;
            }
            else
            {
                if (Input.GetKeyUp(KeyCode.G))
                {
                    laserMovimentG = false;
                }
            }

            if (laserMovimentG == true)
            {
                transform.Rotate(new Vector3(0f, 0f, varG - Control2.velocity));
            }

        }

    }
}
