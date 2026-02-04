using UnityEngine;

public abstract class Character : MonoBehaviour
{
    //private variables
    [Header("Character Stats")]
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private int maxHealth = 100;
    [SerializeField] private int currentHealth;

   

    protected bool isDead = false;
    protected Animator anim;
    //public props
    public float MoveSpeed
    {
        get { return moveSpeed; }
    }

    public bool IsDead
    {
        get { return isDead; }
    }

    protected int CurrentHealth
    {
        get { return currentHealth; }
        set { currentHealth = Mathf.Clamp(value, 0, maxHealth); }
    }

    protected virtual void Awake()
    {
        anim = GetComponent<Animator>();
        Debug.Log("Awake in Character.CS");
        currentHealth = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        if (IsDead)
        {
            return;
        }

        CurrentHealth -= amount;
        Debug.Log($"{gameObject.name} HP is now {CurrentHealth}");

        if (CurrentHealth <= 0)
        {
            Die();
        }

    }

 public abstract void Die();


}
