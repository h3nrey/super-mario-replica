using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private int sense = -1;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private int wallLayer = 7;
    void Update() {
        rb.velocity = Vector2.right * speed * sense * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D other) {	
      if(other.gameObject.layer == wallLayer) {
        sense *= -1;
      }
    }
}
