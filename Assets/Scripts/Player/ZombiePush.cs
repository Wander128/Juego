using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombiePush : MonoBehaviour
{
    Animator zombMoves;
    //float yDir;

    void Start()
    {
        zombMoves = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            zombMoves.SetTrigger("Push");
        }
    }
}
