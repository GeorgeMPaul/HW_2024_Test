using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class DestroyAfterRandomTime : MonoBehaviour
{
    public float minTime = 4f;  
    public float maxTime = 5f; 
    float randomTime;
    float countdownTime;
    public Text text;

    void Start()
    {
        randomTime = Random.Range(minTime, maxTime);
        countdownTime = randomTime;
        Destroy(gameObject, randomTime);
    }

    void FixedUpdate()
    {
        if (countdownTime > 0)
        {
            countdownTime -= Time.deltaTime;
            string countdownTimeFormat = countdownTime.ToString("F2");
            //text.text = countdownTimeFormat;
            Debug.Log(countdownTimeFormat);
        }
    }
}
