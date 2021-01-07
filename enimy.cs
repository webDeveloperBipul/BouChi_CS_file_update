using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enimy : MonoBehaviour
{
    private float target;
    private Transform player;
   
    private float timeLeft =2f;
    private float dist;
    private NavMeshAgent _agent;
    public float moveSpeed;
    public float howClose;
    public float EnemyDistanceRun = 5.0f;
    private bool enter;
  Vector3 startPos;
    Rigidbody rb;
    CharacterController controller;
    Transform Target;

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

        // if player out side time will countdown

        // if player inside home time will be reset

        if (GameObject.Find("home1").GetComponent<safe_home>().exit)
        {

            tLeft();

            Debug.Log(timeLeft);
        }

        if (GameObject.Find("home1").GetComponent<safe_home>().enter)
        {
            enter = true;
            Vector3 dirToPlayer = transform.position - player.transform.position;
            Vector3 newPos = transform.position + dirToPlayer;
            _agent.SetDestination(startPos);
            timeLeft = 5;


        }



         Debug.Log(enter);
        if (player != null)
        {
            if (timeLeft < 0f) {



                Vector3 dirToPlayer = transform.position - player.transform.position;
                Vector3 newPos = transform.position + dirToPlayer;
                _agent.SetDestination(player.position);



            } else
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
                    Vector3 dirToPlayer = transform.position - player.transform.position;
                    Vector3 newPos = transform.position + dirToPlayer;
                    _agent.SetDestination(startPos);

                }


            }



        }
        else
        {

            this.transform.position = startPos;
            

        }

    }

    void tLeft()
    {
        timeLeft -= Time.deltaTime;
    }
    void go_startPos()
    {
        Vector3 dirToPlayer = transform.position + player.transform.position;
        Vector3 newPos = transform.position - dirToPlayer;
        _agent.SetDestination(startPos);
    }

}