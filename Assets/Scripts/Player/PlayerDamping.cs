using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamping : MonoBehaviour
{
    [SerializeField] internal PlayerBehaviour _playerBehaviour;
	
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	internal void CheckVelocity(float playerVelocity){
		if(playerVelocity > 0) {
			print($"have this {playerVelocity} positive velocity");
		} else if(playerVelocity < 0) {
			print($"have this {playerVelocity} negative velocity");
		}
	}
}
