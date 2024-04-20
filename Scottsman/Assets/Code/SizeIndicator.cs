using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeIndicator : MonoBehaviour
{
    public Vector2 Size;
    private SpriteRenderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        Size = renderer.bounds.size;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
