using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireBehaviour : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float horizontalForce;
    [SerializeField] private float lauchForce;
    [SerializeField] private Vector2 vector;
	[SerializeField] private int reboucingTimes;

    void Start() {
		rb.AddForce(Vector2.up * lauchForce);
   }	
    void FixedUpdate() {
        // rb.velocity = transform.right * horizontalForce * Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D other) {
      if(other.gameObject.tag == "Player"){
		print("Colidiu com o Player");
		Destroy(this.gameObject);
      	// this.GetComponent<Collider2D>().isTrigger = true;
       }
	   if(other.gameObject.tag != this.gameObject.tag) {
		   print(reboucingTimes);
		   if(reboucingTimes <= 4) 
				reboucingTimes++;
			else if(reboucingTimes > 4)
				Destroy(this.gameObject);
	   }
    }
    
    // void OnTriggerExit2D(Collider2D other) {
		// if(other.gameObject.tag == "Player"){
      		// this.GetComponent<Collider2D>().isTrigger = false;
        // }
    // }
	
	// void OnCollisionExit2D(Collision2D other) {
		// if(other.gameObject.tag == "Player"){
      		// this.GetComponent<Collider2D>().isTrigger = false;
        // }
    // }
}
