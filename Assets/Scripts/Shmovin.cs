using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shmovin : MonoBehaviour
{
    bool up = false;
    bool left = false;
    bool down = false;
    bool right = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            up = true;
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            up = false;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            left = true;
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            left = false;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            down = true;
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            down = false;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            right = true;
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            right = false;

        }

        Vector2 pos = transform.position;
        if (up)
        {
            pos.y += Time.deltaTime;
        }
        if (left)
        {
            pos.x -= Time.deltaTime;
        }
        if (down)
        {
            pos.y -= Time.deltaTime;
        }
        if (right)
        {
            pos.x += Time.deltaTime;
        }
        transform.position = pos;
    }
}
