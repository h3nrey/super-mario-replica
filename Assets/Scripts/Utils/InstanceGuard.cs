using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceGuard : MonoBehaviour {
   private void Awake() {
       //if(GameObject.FindObjectsOfType(PlayerStats) < 1)
       DontDestroyOnLoad(this.gameObject);
   }
}
