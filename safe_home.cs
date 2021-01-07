using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class safe_home : MonoBehaviour
{
    public bool stay;
    public bool exit;
    public bool enter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            enter = true;
            
            exit = false;

        }




    }


    public void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            stay = true;

            exit = false;

        }




    }
    public void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            stay = false;
            exit = true;
            enter = false;




        }




    }



}
