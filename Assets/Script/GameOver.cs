using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public float threshold;
    public GameObject gameOver;

    private void Start()
    {
        gameOver.gameObject.SetActive(false);
    }
    void Update()
    {
            if (transform.position.y < threshold)
            {
                Debug.Log("Game Over");
                gameOver.gameObject.SetActive(true);
                Time.timeScale = 0;
            }
    }
}
