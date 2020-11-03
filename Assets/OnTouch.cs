using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTouch : MonoBehaviour
{
   
    public AudioSource WelcomeHell;

    // Start is called before the first frame update
    void Start()
    {
        WelcomeHell = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision coli)
    {
        if(coli.gameObject.tag=="FloorMain")
        {
            WelcomeHell.Play();
        }
    }
}
