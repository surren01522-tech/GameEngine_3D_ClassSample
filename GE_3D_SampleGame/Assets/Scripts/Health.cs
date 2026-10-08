using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int maxHP =3;
    public int currentHP;
    public Slider hpSlider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHP = maxHP;
        UpdateBar();   
    }

    public void TakeDamage(int damage)
    {
        if (currentHP <= 0) return;

        currentHP -= damage;
        Debug.Log(name + " HP: " + currentHP);
        UpdateBar();

        if (currentHP <= 0) Die();
    }

    void UpdateBar()
    {
        if (hpSlider != null)
            hpSlider.value = (float)currentHP / maxHP;
    }

    void Die()
    {
        if (CompareTag("Player"))
        {
            Debug.Log("게임 오버");
            Time.timeScale = 0f;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
