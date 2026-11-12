using Unity.VisualScripting;
using UnityEngine;

public class RewardCalc : MonoBehaviour
{
    public int PlaySeconds = 3725;
    public int Gold = 1234;
    public int Members = 4;
    public int Kills = 7;
    public int ExpPerKill = 35;
    public int TotalDamage = 250;
    public int Hits = 20;

    public float ExpRate = 1.5f;

    [ContextMenu("정산")]
    void Print()
    {
        int Min = PlaySeconds / 60;
        int sec = PlaySeconds % 60;
        int Hour = Min / 60;
        Debug.Log("플레이 시간:" + Hour + ":" + Min + ":" + sec);

        int gold = Gold / Members;
        int bonus = Gold % Members;
        Debug.Log("1인 G" + Gold + "리더 보너스" + bonus);

        float exp = Kills * ExpPerKill;
        float totalexp = exp * ExpRate;
        Debug.Log("경험치" + totalexp + "기본" + exp);

        int level = (int)totalexp / 100;
        int ExcessexperiencePoints = (int)totalexp % 100;
        int RemainingEXP = 100 - ExcessexperiencePoints;
        Debug.Log("LV " + level + "다음 레벨까지" + RemainingEXP);


    }
}
