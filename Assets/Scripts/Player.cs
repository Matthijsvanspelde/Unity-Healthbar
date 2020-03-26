using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public Healthbar healthbar;
    public UnityEvent OnHealthChange;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        audioSource.GetComponent<AudioSource>();
    }

    public void TakeDamage(int damage) 
    {
        currentHealth -= damage;
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Trap")
        {
            Debug.Log(currentHealth);
            Trap Trap = collider.gameObject.GetComponent<Trap>();
            TakeDamage(Trap.Damage);
            audioSource.Play();
        }       
        OnHealthChange.Invoke();
    }
}
