using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mushroomBehaviour : MonoBehaviour
{
    [SerializeField] private Collider2D coll;
    [SerializeField] private int enemiesLayer;
    [SerializeField] private Rigidbody2D rb;
    void Update() {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.layer == enemiesLayer) {
            coll.enabled = false;
            this.GetComponent<SimpleMovement>().enabled = false;
            rb.gravityScale = 0;
        }
    }
    private void OnTriggerExit2D(Collision2D other) {
        if(other.gameObject.layer == enemiesLayer) {
            coll.enabled = true;
            this.GetComponent<SimpleMovement>().enabled = true;
            rb.gravityScale = 1;
        }
    }
}
