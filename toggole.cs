using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggole : MonoBehaviour
{
    public bool ison=false;
    public GameObject pre;
    public void on(){
        if(ison){
            pre.SetActive(false);
            ison=false;
        }
        else{
            pre.SetActive(true);
            ison=true;
        }

    }

}
