using UnityEngine;

public class Lesson10 : MonoBehaviour
{
    [ContextMenu("판단")]
    void Judge()
    {
        int hp = 20;
        int maxHp = 100;
        bool isStunned = false;
        bool hasPoison = false;

        bool canAttack = hp > 0 && ! isStunned;
        bool isDanger = hp <= maxHp/4 || hasPoison;
    }

    [ContextMenu("계단")]
    void Stairs()
    {
        string text = "";
        int height = 3;
        int len = 1;

        for (int i=0; i < height; i++)
        {
            for (int j = 0; j> 0; j++)
            {
                text += "*";
            }
            len++;
            text += "\n";
        }
        Debug.Log(text);
    }

    [ContextMenu("역계단")]
    void ReStairs()
    {
        
    }


}
