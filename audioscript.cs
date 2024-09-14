using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioscript : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource a;
    public bool isplay=true;
    void Start()
    {
        a=GetComponent<AudioSource>();  
    }
    public void playing(){
        if(isplay){
            a.Stop();
            isplay=false;
        }
        else{
            a.Play();
            isplay=true;
        }
    }
}
