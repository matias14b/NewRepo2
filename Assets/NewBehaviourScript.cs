using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        setearObjeto();

    }

    // Update is called once per frame
    function Update()
    {
        if (Input.GetAxis("Vertical") > 0.2)
            animation.CrossFade("walk");
        else
            animation.CrossFade("idle");
    }


    public void setearObjeto()
    {
    }
}
