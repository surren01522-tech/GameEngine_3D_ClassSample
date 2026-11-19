using System.Collections.Generic;
using UnityEngine;

public class ArrayPractice : MonoBehaviour
{
    public int[] golds = { 300, 1200, 50, 800};

    [ContextMenu("배열 실습")]
    void df()
    {
        
    }

    [ContextMenu("List 실습")]
    void ShowInventory()
    {
        List<string> items = new List<string>();
        items.Add("포션");
        items.Add("화살");
        items.Add("포션");
        items.Remove("포션");

        List<string> keys = new List<string>();
        keys.Add("열쇠");
        

        Debug.Log( "아이템" + items.Count + "열쇠 있음");
    }
}
