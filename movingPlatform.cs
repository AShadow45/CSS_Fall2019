using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlatform : MonoBehaviour
{
    [SerializeField]
    private Vector3 velocity;

    private bool moving;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player1"))
        {
            moving = true;
            collision.collider.transform.SetParent(transform);
        }
    }
}
