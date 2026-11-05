using UnityEngine;

public class HpPractice : MonoBehaviour
{

    [ContextMenu("체력")]
    void PrintHP()
    {
        int CurrentHP = 7;
        int MaxHP = 10;
        Debug.Log( "HP " + ( (float) CurrentHP / MaxHP * 100 ) + "%");

        CurrentHP = 1;
        MaxHP = 3;
        print( "HP" + ( (float)CurrentHP / MaxHP * 100 ) + "%");

        CurrentHP = 10;
        MaxHP = 10;
        print( "HP" + ( (float)CurrentHP / MaxHP * 100 ) + "%" );

        CurrentHP = 0;
        MaxHP = 10;
        print( "HP" + ( (float) CurrentHP / MaxHP * 100) + "%" );

        
    }
}
