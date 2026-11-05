using UnityEngine;

public class Lesson09 : MonoBehaviour
{
    //기본 구조 (변수, 함수)
    public int attack = 10; //필드 전역변수
    int killCount = 0; //필드 전역변수

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      Debug.Log(attack);
    }

    void Hit()
    {
        killCount = killCount + 1;
    }

    //어트리뷰트 (일종의 유니티의 에디터 기능)

    [ContextMenu("Hello")] // <- 해당 [] 사용 시 하단의 하나의 함수가 상속됨. 인스턴트뷰에서 호출 가능. 일종의 유니티 기능
    void Hello()
    {
        Debug.Log("Hello");
    }

    //지역변수
    [ContextMenu("처치")]
    void CountKill()
    {
        int defense = 3;     // <- 지역 변수: 함수내에 적는 변수 / 해당 함수내에서만 존재함. 만일 함수를 호출할 경우 해당 변수는 선언되지 못함
        killCount = killCount + 1;
        Debug.Log(attack - defense);
        Debug.Log(killCount);
    }

    //정수 오버플로 하기
    [ContextMenu("오버플로")]
    void Overflow()
    {
        int gold = int.MaxValue;
        Debug.Log(gold);
        gold = gold + 1;
        Debug.Log(gold);
        byte red = 255;
        red++;
        Debug.Log(red);
    }

    //예측: 실수의 정밀도
    [ContextMenu("정밀도")]
    void Precision()
    {
        double d = 0.1 + 0.2;
        Debug.Log(d == 0.3); // <- 실수는 정확히 떨어지는 숫자가 아니라 0.3이 아닌 0.30000000000000004이 되어버림

        float half = 1 / 2; // <- f 없음 실수가 아닌 정수
        Debug.Log(half); // <- 1 / 2 는 int 나눗셈이 먼저라 0으로 계산. float 변수에 넣어도 0

        half = 1.0f / 2.0f;
        Debug.Log(half);
    }



    //정수 나눗셈
    [ContextMenu("예측 2")]
    void Predict2()
    {
        int hp = 7;
        int maxHp = 10;
        Debug.Log(hp / maxHp); // = 0
        Debug.Log((float)hp / maxHp); // = 0.7
        Debug.Log(hp / 2); // = 3
        Debug.Log(hp / 2f); // = 3.5
        Debug.Log(hp % 2); // = 1
    }

    //나머지 % 활용
    [ContextMenu("나머지")]
    void Remainder()
    {
        int shotCount = 6;
        int totalSeconds = 135;
 
        bool isEven = shotCount % 2 == 0; // = true
        bool strongShot = shotCount % 3 == 0; // = true 
        int min = totalSeconds / 60; // = 2
        int sec = totalSeconds % 60; // = 15
        Debug.Log(min + ":" + sec); // = 2:15
    }


    //문자열 이어붙이기
    [ContextMenu("예측 3")]
    void Predict3()
    {
        int a = 1;
        int b = 2;
        Debug.Log("합: " + a + b); // = 합: 12
        Debug.Log("합: " + (a + b)); // = 합: 3
        Debug.Log(a + b + "점"); // = 3점
        Debug.Log("HP " + 7 / 2); // = HP 3
    }




}
