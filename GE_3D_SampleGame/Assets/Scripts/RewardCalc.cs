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

    [ContextMenu("과제")]
    void Print()
    {
        int a = PlaySeconds / 60; // 분
        int d = PlaySeconds % 60; // 나머지
        int b = a / 60; //시간
        int c = a % 60; //나머지 분


    }
}
