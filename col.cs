using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col : MonoBehaviour
{
    private float timeLeft = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (timeLeft > 0f)
        {

            if (collision.gameObject.name == "enimy")
            {
                Destroy(collision.gameObject);
            }
        }
        if (timeLeft < 0f)
        {

            if (collision.gameObject.name == "player")
            {
                Destroy(collision.gameObject);
            }
        }

    }

    
}
