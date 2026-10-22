using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int maxHP =3;
    public int currentHp;
    public Slider hpSlider;
    public float invincibleTime = 0f;   // 플레이어는 0.5
    float lastHitTime = -999f;

    public static int KillCount;

    public GameObject dropPrefab;
    public float dropChance = 0.3f;

    public GameObject hitEffect;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHp = maxHP;
        UpdateBar();   
    }

    public void TakeDamage(int damage)
    {
        if (currentHp <= 0) return;
        if (Time.time < lastHitTime + invincibleTime) return;
        lastHitTime = Time.time;
 
        currentHp -= damage;
        Debug.Log(name + " HP: " + currentHp);
        UpdateBar();

        Vector3 hitPos = transform.position + Vector3.up;
        if (hitEffect != null)
            Instantiate(hitEffect, hitPos, Quaternion.identity);

 
        if (currentHp <= 0) Die();
        else Blink();

    }

    void UpdateBar()
    {
        if (hpSlider != null)
            hpSlider.value = (float)currentHp / maxHP;
    }

    void Die()
    {
        if (CompareTag("Player"))
        {
            GameManager.Instance.GameOver();
        }

        else
        {
            KillCount++;

            if (dropPrefab != null && Random.value < dropChance)
            {
                Vector3 pos = transform.position + Vector3.up * 0.5f;
                Instantiate(dropPrefab, pos, Quaternion.identity);
            }

            Destroy(gameObject);
        }
    }

    void Blink()
    {
        SetVisible(false);
        Invoke(nameof(ShowAgain), 0.1f);
    }
 
    void ShowAgain()
    {
        SetVisible(true);
    }
 
    void SetVisible(bool on)
    {
        foreach (Renderer r in GetComponentsInChildren<Renderer>())
            r.enabled = on;
    }

    public void Heal(int amount)
    {
        currentHp = Mathf.Min(currentHp + amount + maxHP);
        UpdateBar();
    }


    // Update is called once per frame 
    void Update()
    {
        
    }

    
}
