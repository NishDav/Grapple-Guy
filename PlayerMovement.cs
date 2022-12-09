using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform playerTransform;
    public float playerSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetAxisRaw("Horizontal") > 0){
         
            playerTransform.Translate(new Vector2(1, 0) * playerSpeed * Time.deltaTime);
        }

        if (Input.GetAxisRaw("Horizontal") < 0){
        
            playerTransform.Translate(new Vector2(-1, 0) * playerSpeed * Time.deltaTime);   
        }
    }
}
