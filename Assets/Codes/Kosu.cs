using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kosu : MonoBehaviour
{
    [SerializeField] float movementspeed;
    [SerializeField] float herspeed;
    
    float hor;
    bool movementRight = true;
    bool movementLeft = true;
    int leftCount = 0;
    int rightCount = 0;

    public void Start()
    {
        
    }
    
    void Update()
    {
       
        transform.Translate(new Vector3(0, 0, movementspeed * Time.deltaTime));
        MovementOneClick();
        
        
    }

    void MovementOneClick()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (movementRight || leftCount == 0)
            {
                transform.Translate(new Vector3(3, 0, 0));
                movementRight = false;
                movementLeft = true;
                rightCount++;
                if (leftCount == 2)
                {
                    leftCount--;
                }
                else
                {
                    leftCount--;
                }

            }

        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (movementLeft || rightCount == 0)
            {
                transform.Translate(new Vector3(-3, 0, 0));
                movementLeft = false;
                movementRight = true;
                leftCount++;
                if (rightCount == 2)
                {
                    rightCount--;
                }
                else
                {
                    rightCount--;
                }
            }

        }
    }
}

