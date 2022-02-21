using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

  private PlayerBehaviour _playerBehaviour;

  [Header("Enemy Checking")]
  private bool hitted;
  [SerializeField] private LayerMask enemyMask;
  [Range(0.1f, 0.5f)][SerializeField] private float enemyCheckerRange = 0.5f;  
  private bool canHit = true;

  [Header("Gizmos")]
  [SerializeField] private Color32 corzinha;

  private void Awake() {
    _playerBehaviour = FindObjectOfType<PlayerBehaviour>();
  }
  private void OnTriggerEnter2D(Collider2D other) {
    switch(other.gameObject.tag){
    case "coin" :
      _playerBehaviour.playerCoins++;
      other.gameObject.GetComponent<SelfDestruction>().DestroyMe();
      break;
    case "mushroom":
      _playerBehaviour._powerups.GivePowerUps("mushroom");
      other.gameObject.GetComponent<SelfDestruction>().DestroyMe();
      break;
    case "flower":
      _playerBehaviour._powerups.GivePowerUps("flower");
      other.gameObject.GetComponent<SelfDestruction>().DestroyMe();
      break;
    }
  }
    
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "floor") {
            // _playerBehaviour._jump.canJump = true;
            _playerBehaviour._animation.SetBolleans(_playerBehaviour._animation.groundParam, true);
        }

        // if(other.gameObject.tag == "enemy") {
		    //    _playerBehaviour._playerLife.TakeDamage();
	      // }
    }

  private void OnCollisionExit2D(Collision2D other) {
    if(other.gameObject.tag == "floor") {
        // _playerBehaviour._jump.canJump = false;
      _playerBehaviour._animation.SetBolleans(_playerBehaviour._animation.groundParam, false);
    }
  }
    
  private void FixedUpdate() {
    hitted = Physics2D.OverlapCircle(this.transform.position, enemyCheckerRange, enemyMask);
  }

  private void Update() {
    if(hitted && canHit) {
      _playerBehaviour._playerLife.TakeDamage();
      StartCoroutine(disableRange());
    }
  }

  private IEnumerator disableRange(){
    canHit = false;
    yield return new WaitForSeconds(0.5f);
    canHit = true;
  }
  void OnDrawGizmosSelected() {
		Gizmos.color = corzinha;
		Gizmos.DrawWireSphere(this.transform.position, enemyCheckerRange);
	}  
}
