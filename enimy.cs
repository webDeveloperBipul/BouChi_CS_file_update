using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class enimy : MonoBehaviour
{
    private float target;
    private Transform player;
    private float timeLeft = 10.0f;
    private float dist;
    private NavMeshAgent _agent;
    public float moveSpeed;
    public float howClose;
    public float EnemyDistanceRun = 5.0f;
    Vector3 startPos;
    Rigidbody rb;
    CharacterController controller;

    


    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        _agent = GetComponent<NavMeshAgent>();
        rb = GetComponent<Rigidbody>();
        startPos = this.transform.position;
        controller = GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {   
        
        

        GameObject varGameObject = GameObject.FindWithTag("Player");

        if (GameObject.Find("home1").GetComponent<safe_home>().outSide)
        {
            timeLeft -= Time.deltaTime;
            
            Debug.Log(timeLeft);
        }
       
        if (player != null)
        {
            if (timeLeft > 0f)
            {
                float distance = Vector3.Distance(transform.position, player.transform.position);
                // varGameObject.GetComponent<col>().enabled = true;


                if (distance < EnemyDistanceRun)
                {



                    Vector3 dirToPlayer = transform.position - player.transform.position;
                    Vector3 newPos = transform.position + dirToPlayer;
                    _agent.SetDestination(newPos);


                }
                else
                {
                    Vector3 dirToPlayer = transform.position + player.transform.position;
                    Vector3 newPos = transform.position - dirToPlayer;
                    _agent.SetDestination(startPos);
                }
                if (GameObject.Find("home1").GetComponent<safe_home>().EnteredTrigger)
                {

                    Vector3 dirToPlayer = transform.position + player.transform.position;
                    Vector3 newPos = transform.position - dirToPlayer;
                    _agent.SetDestination(startPos);
                    Debug.Log("ok");
                }


            }
            else
            {
                if (GameObject.Find("home1").GetComponent<safe_home>().EnteredTrigger)
                {

                    this.transform.position = startPos;
                    Debug.Log("ok");
                }
                else
                {

                    dist = Vector3.Distance(player.position, transform.position);
                    if (dist <= howClose)
                    {
                        transform.LookAt(player);

                        rb.AddForce(transform.forward * moveSpeed);
                    }

                }

                // varGameObject.GetComponent<col>().enabled = false;



            }

            if (GameObject.Find("home1").GetComponent<safe_home>().EnteredTrigger)
            {

                Vector3 dirToPlayer = transform.position + player.transform.position;
                Vector3 newPos = transform.position - dirToPlayer;
                _agent.SetDestination(startPos);
                Debug.Log("ok");
            }
        }
        else {
            // this.transform.position = Vector3.Lerp(transform.position, startPos, Time.deltaTime);
            //this.transform.position = Vector3.Lerp(transform.position, startPos, Time.deltaTime);
            this.transform.position = startPos;


        }

    }

    private void OnTriggerEnter(Collider coll)
    {
        
    }



}
