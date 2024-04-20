using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public bool Started;
    public float cameraSpeed;
    public Vector3 initPos;
    public Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = initPos;
        Started = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = pos;
        if(Input.GetKeyDown(KeyCode.Q))
        {
            Started = true;
        }
        if (Started)
        {
            pos.x = pos.x + cameraSpeed * Time.deltaTime;
        }
    }
}
