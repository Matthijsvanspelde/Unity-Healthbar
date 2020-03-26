using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    private Player player;

    private void Start()
    {

        player = GameObject.Find("Player").GetComponent<Player>();
        SetMaxHealth();
    }

    public void SetMaxHealth() 
    {
        slider.maxValue = player.maxHealth;
        slider.value = slider.maxValue;
        fill.color = gradient.Evaluate(1f);
    }

    public void SetHealth() 
    {
        slider.value = player.currentHealth;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
