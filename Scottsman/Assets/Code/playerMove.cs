using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public Vector2 playerPos;
    public float moveSpeed;
    public bool isJumping;
    public float jumpHeight;
    // Start is called before the first frame update
    void Start()
    {
        isJumping = false;
    }

    // Update is called once per frame
    void Update()
    {
      
        transform.position = playerPos;
        
        
           if (Input.GetKey(KeyCode.D))
            {
                playerPos.x = playerPos.x + moveSpeed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.A))
            {
                playerPos.x = playerPos.x - moveSpeed * Time.deltaTime;
            }
        
        
    }
}
