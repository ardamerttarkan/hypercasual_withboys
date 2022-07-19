using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kosu : MonoBehaviour
{
    [SerializeField] float movementspeed;
    [SerializeField] float herspeed;
    
    float hor;

    void Start()
    {
        
    }

    
    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(hor * herspeed * Time.deltaTime, 0, movementspeed * Time.deltaTime));


    }
}
