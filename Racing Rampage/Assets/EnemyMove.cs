using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] float chaseDistance = 5.0f;
    [SerializeField] float moveSpeed = 5;
    Vector3 home;

    void Start()
    {
        home = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = player.transform.position;
        Vector3 moveDirection = playerPosition - transform.position;
        //if the player is close
        if (moveDirection.magnitude < chaseDistance)
        {
            //chase the player
            moveDirection.Normalize();
            GetComponent<Rigidbody2D>().velocity = moveDirection * moveSpeed;
        }
        else
        {
            //the player is too far away
            //return home
            moveDirection = home - transform.position;
            if (moveDirection.magnitude >= 0.2f)
            {
                moveDirection.Normalize();
                GetComponent<Rigidbody2D>().velocity = moveDirection * moveSpeed;
            }
            else
            {
                //close enough
                transform.position = home;
                GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            }

            //GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        }
    }
}
