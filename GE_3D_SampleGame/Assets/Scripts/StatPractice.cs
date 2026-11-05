using UnityEngine;

public class StatPractice : MonoBehaviour
{
    public string PlayerName = "ansmlsp";
    public int Level = 10;
    public float Attack = 3f;
    public bool isBoss = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [ContextMenu("스탯")]
    void ShowStat()
    {
        Debug.Log(PlayerName);
        Debug.Log(Level);
        Debug.Log(Attack);
        Debug.Log(isBoss);
    }

    

}
