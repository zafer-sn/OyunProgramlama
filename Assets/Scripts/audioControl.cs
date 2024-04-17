using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class audioControl : MonoBehaviour
{

    AudioSource src;
    public AudioClip clip1;
    public AudioClip clip2;

    private void Start()
    {
        src = gameObject.GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            src.PlayOneShot(clip1);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            src.PlayOneShot(clip2);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            src.Stop();
        }
    }
}
