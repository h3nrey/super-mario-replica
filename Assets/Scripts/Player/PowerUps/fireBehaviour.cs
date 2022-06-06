using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireBehaviour : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float lauchForceHorizontal, lauchForceVertical;
    [SerializeField] private float horizontalSpeed;
    [SerializeField] private Vector2 vector;
	[SerializeField] private int reboucingTimes, maxReboucingTimes;

    void Start() {
		//rb.AddForce(Vector2.up * lauchForce);
        rb.AddForce(new Vector2(lauchForceHorizontal, lauchForceVertical), ForceMode2D.Impulse);
   }	
    void FixedUpdate() {
        rb.AddForce(horizontalSpeed * Time.fixedDeltaTime * transform.right);
    }

    void OnCollisionEnter2D(Collision2D other) {
      if(other.gameObject.tag == "Player"){
		print("Colidiu com o Player");
		Destroy(this.gameObject);
      	// this.GetComponent<Collider2D>().isTrigger = true;
       }
        if (other.gameObject.tag != this.gameObject.tag) {
            print(reboucingTimes);
            if (reboucingTimes <= 8)
                reboucingTimes++;
            else if (reboucingTimes > 8)
                Destroy(this.gameObject);
        }
    }
}
