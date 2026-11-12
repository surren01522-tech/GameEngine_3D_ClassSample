using UnityEngine;

public class DamagePractice : MonoBehaviour
{
    int attack = 12;
    int defense = 5;
    bool isCritical = false;
    bool targetIsBoss = false;

    [ContextMenu("데미지")]
    void Calc()
    {
        int Damage = attack - defense;
        if (Damage < 1)
        {
            Damage = 1;
        }

        if (isCritical == true)
        {
            Damage = Damage * 2;
        }

        if (targetIsBoss == true)
        {
            Damage = Damage / 2;
        }
        Debug.Log(Damage);
    }
}
