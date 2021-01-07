using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Myscript : MonoBehaviour
{
    protected Joystick joystick;
    protected joyButton joyButton; 
     // Start is called before the first frame update
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        joyButton = FindObjectOfType<joyButton>();
    }

    // Update is called once per frame
    void Update()
    {
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = new Vector3(joystick.Horizontal * 600f * Time.deltaTime + Input.GetAxis("Horizontal") * 600f *  Time.deltaTime,
                               rigidbody.velocity.y, joystick.Vertical * 600f * Time.deltaTime + Input.GetAxis("Vertical") * 600f *  Time.deltaTime);
    }
}
