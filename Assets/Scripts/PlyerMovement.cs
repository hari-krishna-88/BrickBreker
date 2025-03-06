using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlyerMovement : MonoBehaviour
{
    public float speed=30;
    public float movementHorizontal;
    public float maxX=7.4f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movementHorizontal = Input.GetAxis("Horizontal");

        if (movementHorizontal>0 && transform.position.x<maxX || (movementHorizontal <0 && transform.position.x>-maxX))
        {
           
            transform.position += Vector3.right *2* movementHorizontal * speed*Time.deltaTime;
        }

       
    }
}
