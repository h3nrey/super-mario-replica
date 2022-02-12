using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCaller : MonoBehaviour {
    static public void CallScene(string sceneName){
        print(sceneName);
        SceneManager.LoadScene(sceneName);
    }
}
