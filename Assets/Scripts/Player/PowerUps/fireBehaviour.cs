using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireBehaviour : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float horizontalForce;
    [SerializeField] private float lauchForce;
    [SerializeField] private Vector2 vector;	

    void Start() {
	rb.AddForce(Vector2.up * lauchForce);
   }	
    void FixedUpdate() {
        rb.velocity = new Vector2(horizontalForce * Time.deltaTime, rb.velocity.y);
    }

    void OnCollision2D(Collision2D other) {
      if(other.gameObject.tag == "Player"){
      	this.GetComponent<Collider2D>().isTrigger = true;
       }
    }
    
     void OnTriggerExit2D(Collider2D other) {
	 if(other.gameObject.tag == "Player"){
      		this.GetComponent<Collider2D>().isTrigger = false;
              }
     }
}
