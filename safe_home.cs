using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class safe_home : MonoBehaviour
{
    public bool EnteredTrigger;
    public bool outSide;
    public bool Entered;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerStay(Collider other)
    {
       
        if (other.gameObject.tag == "Player")
        {
            EnteredTrigger = true;

            outSide = false;

        }

       

           
    }
    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            Entered = true;

            outSide = false;

        }




    }
    public void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            EnteredTrigger = false;
            outSide = true;




        }




    }



}
