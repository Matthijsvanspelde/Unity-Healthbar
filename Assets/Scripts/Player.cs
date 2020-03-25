using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public Healthbar healthbar;
    public UnityEvent OnHealthChange;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(5);
        }
    }

    private void OnEnable()
    {
        OnHealthChange.Invoke();
    }

    public void TakeDamage(int damage) 
    {
        currentHealth -= damage;
        healthbar.SetHealth(currentHealth);
    }
}
