using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lander : MonoBehaviour
{
    public float engineSpeed = 0;
    public float rotationSpeed = -40;
    public bool engineIsOn = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            engineIsOn = true;
        } else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            engineIsOn = false;
        }
        if (engineIsOn)
        {
            engineSpeed += 1f * Time.deltaTime;
        }
        else engineSpeed -= 1f * Time.deltaTime;
        engineSpeed = Mathf.Clamp(engineSpeed, 0, 3);

        Debug.Log(transform.up * engineSpeed * Time.deltaTime);
        transform.Rotate(0, 0, Input.GetAxisRaw("Horizontal") * rotationSpeed * Time.deltaTime);
        Vector3 pos = transform.position;
        pos += transform.up * engineSpeed * Time.deltaTime;
        pos += Vector3.down * 1.5f * Time.deltaTime;
        transform.position = pos;

    }
}
