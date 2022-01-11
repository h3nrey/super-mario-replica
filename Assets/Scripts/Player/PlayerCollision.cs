using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    private PlayerBehaviour _playerBehaviour;
    private void Awake() {
        _playerBehaviour = FindObjectOfType<PlayerBehaviour>();
    }
    
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "floor") {
            _playerBehaviour._jump.canJump = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.tag == "floor") {
            _playerBehaviour._jump.canJump = false;
        }
    }
    
}
