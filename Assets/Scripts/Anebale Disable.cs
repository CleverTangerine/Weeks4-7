using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnebaleDisable : MonoBehaviour
{
    public SpriteRenderer sr;
    public AnebaleDisable script;
    public GameObject GO;
    public AudioSource audioSource;
    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //sr.enabled = false;
            //script.enabled = false;
            GO.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //sr.enabled = true;
            //script.enabled = true;
            GO.SetActive(true);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            //if (!audioSource.isPlaying)
            //{
            //    audioSource.Play();
            //}
            if (!audioSource.isPlaying)
            {
                audioSource.PlayOneShot(clip);
            }
            
        }
    }
}
