using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    [SerializeField]
    private GameObject winGame;
    [SerializeField]
    private float timeDelay;
    [SerializeField]
    private GameObject gameOver;
    // Start is called before the first frame update
    void Start()
    {
     
        winGame.SetActive(false);
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator DelayWin()
    {
        yield return new WaitForSeconds(timeDelay);
        Time.timeScale = 0f;
        winGame.SetActive(true);
    }
    IEnumerable
}
