using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Transform Target;
    public GameMaster gameMaster;

    private void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Target.position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, Target.position) < .2)
        {
            gameMaster.Death();
        }
    }
}
