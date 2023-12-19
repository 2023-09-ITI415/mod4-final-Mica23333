using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownBar : MonoBehaviour
{
    public Slider countdownSlider;
    public float countdownTime = 240f;
    public GameObject loseTextObject;

    private float currentTime;

    void Start()
    {
        currentTime = countdownTime;
        UpdateSlider();
        loseTextObject.SetActive(false);
    }

    void Update()
    {
        if (currentTime > 0f)
        {
            currentTime -= Time.deltaTime;
            UpdateSlider();
        }
        else
        {
            GameOver();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("House"))
        {
            ResetCountdown();
        }
    }

    void GameOver()
    {
        loseTextObject.SetActive(true);
        // Add any additional logic for game over (e.g., resetting player position, etc.)
    }

    void UpdateSlider()
    {
        float fillAmount = currentTime / countdownTime;
        countdownSlider.value = fillAmount;
    }

    void ResetCountdown()
    {
        currentTime = countdownTime;
        UpdateSlider();
    }
}