using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    public int expPerKill = 3500;
    public int killCount = 3;
        
    [ContextMenu("레벨 계산")]
    void CalculateLevel()
    {
        int level = 1;
        int exp = 0;

        exp += killCount * expPerKill;


        for(int i=0; i>=0; i++)
        {
            while (exp >= killCount * 10000)
            {
                exp -= level * 10000;
                level++;
            }
        }
        
        
    }
    
}
