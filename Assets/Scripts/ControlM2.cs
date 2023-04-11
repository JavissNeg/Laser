using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlM2 : MonoBehaviour
{
    float varG = 0f;
    float varX = 0f;
    float varY = 0f;
    bool mirrorMovimentF = false;
    bool mirrorMovimentG = false;
    bool mirrorMovimentW = false;
    bool mirrorMovimentA = false;
    bool mirrorMovimentS = false;
    bool mirrorMovimentD = false;
    public static bool MouseStatusM2 = false;


    private void OnMouseDown()
    {
        Control.MouseStatusL = false;
        ControlM.MouseStatusM = false;
        MouseStatusM2 = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (MouseStatusM2 == true)
        {
            //Move up
            if (Input.GetKeyDown(KeyCode.W))
            {
                mirrorMovimentW = true;
            }
            else
            {
                if (Input.GetKeyUp(KeyCode.W))
                {
                    mirrorMovimentW = false;
                }
            }

            if (mirrorMovimentW == true)
            {
                transform.Translate(new Vector3(varX, varY + Control2.velocity, 0f));
            }


            //Move down
            if (Input.GetKeyDown(KeyCode.S))
            {
                mirrorMovimentS = true;
            }
            else
            {
                if (Input.GetKeyUp(KeyCode.S))
                {
                    mirrorMovimentS = false;
                }
            }

            if (mirrorMovimentS == true)
            {
                transform.Translate(new Vector3(varX, varY - Control2.velocity, 0f));
            }


            //Move right
            if (Input.GetKeyDown(KeyCode.D))
            {
                mirrorMovimentD = true;
            }
            else
            {
                if (Input.GetKeyUp(KeyCode.D))
                {
                    mirrorMovimentD = false;
                }
            }

            if (mirrorMovimentD == true)
            {
                transform.Translate(new Vector3(varX + Control2.velocity, varY, 0f));
            }

            //Move left
            if (Input.GetKeyDown(KeyCode.A))
            {
                mirrorMovimentA = true;
            }
            else
            {
                if (Input.GetKeyUp(KeyCode.A))
                {
                    mirrorMovimentA = false;
                }
            }

            if (mirrorMovimentA == true)
            {
                transform.Translate(new Vector3(varX - Control2.velocity, varY, 0f));
            }

            //Increase rotation
            if (Input.GetKeyDown(KeyCode.F))
            {
                mirrorMovimentF = true;
            }
            else
            {
                if (Input.GetKeyUp(KeyCode.F))
                {
                    mirrorMovimentF = false;
                }
            }

            if (mirrorMovimentF == true)
            {
                transform.Rotate(new Vector3(0f, 0f, varG + Control2.velocity));
            }


            //Decrease rotation
            if (Input.GetKeyDown(KeyCode.G))
            {
                mirrorMovimentG = true;
            }
            else
            {
                if (Input.GetKeyUp(KeyCode.G))
                {
                    mirrorMovimentG = false;
                }
            }

            if (mirrorMovimentG == true)
            {
                transform.Rotate(new Vector3(0f, 0f, varG - Control2.velocity));
            }

        }

    }
}
