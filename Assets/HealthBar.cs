using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private Image HealthB;
    public float CurrentHealth;
    private float MaxHealth = 100f;
    FPSController player;

    // Start is called before the first frame update
    void Start()
    {
        HealthB = GetComponent<Image>();
        player = FindObjectOfType<FPSController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        CurrentHealth = player.Health;
        HealthB.fillAmount = CurrentHealth / MaxHealth;
    }
}
