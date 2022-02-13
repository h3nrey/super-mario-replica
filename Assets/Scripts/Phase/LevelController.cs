using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LevelController : MonoBehaviour {

    [Header("Texts")]
    [SerializeField] private TMP_Text[] texts;

    [Header("Timer")]
    [SerializeField] internal float levelTime = 400;
    private float currentTime;

    [Header("Coins")]

    [Header("Externals")]
    [SerializeField] private PlayerBehaviour _player;
    void Start() {
        currentTime = levelTime;
    }

    void Update() {
        SetTextsContent("score", _player.playerScore, 0);
        SetTextsContent("coins", _player.playerCoins, 1);
        SetTextsContent("world", "1-1", 2);
        SetTextsContent("time", TimerController(), 3);
        SetTextsContent("lives", _player.playerLife, 4);
    }

    private int TimerController(){
        if(currentTime > 0)
            currentTime -= Time.deltaTime;
        return Mathf.RoundToInt(currentTime);
    }

    private void CoinController(){
        SetTextsContent("coins", _player.playerCoins, 1);
    }

    private void SetTextsContent(string textType, dynamic value, int textIndex){
        texts[textIndex].text = $"{textType} {value}".ToUpper();
    }
}
