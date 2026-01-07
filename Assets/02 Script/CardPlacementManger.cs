using System;
using System.Collections.Generic;
using UnityEngine;

public class CardPlacementManger : MonoBehaviour
{
    [SerializeField] private List<GameObject> slots;
    [SerializeField] private List<string> usingCard;
    [SerializeField] private List<string> rememberCard;
    [SerializeField] private int keyNum = 15;
    [SerializeField] private int keyCount = 0;
    public int usekeyCount = 0;
    private void Awake()
    {   // usingCard 리스트에 16장의 카드를 추가
        usingCard = new List<string>();
        rememberCard = new List<string>();
        RegistrationCard(usingCard);
        RegistrationCard(rememberCard);
    }

    public void UseingKeycount()
    {
        usekeyCount = keyCount;
    }
    public void AddKeyCount()
    {
        usekeyCount++;
        keyCount = usekeyCount;
    }

    public void useLogic()
    {
        //버튼으로 사용하기 위함. 나중엔 게임 메니저로 돌릴것.
        Placement();
    }
    private void RegistrationCard(List<string>Card)
    {
        //0,1 살인마의 함정
        for (int i = 0; i <= 1; i++)
        {
            Card.Add("살인마의함정");
        }
        //2,3,4,5 최면가스
        for (int i = 0; i <= 3; i++)
        {
            Card.Add("최면가스");
        }
        // 6,7,8 작은단서
        for (int i = 0; i <= 2; i++)
        {
            Card.Add("작은단서");
        }
        // 9,10 아무것도없는방
        for (int i = 0; i <= 1; i++)
        {
            Card.Add("아무것도없는방");
        }
        Card.Add("방탄조끼");
        Card.Add("탈출구");

        //13,14,15 은열쇠
        for (int i = 0; i <= 2; i++)
        {
            Card.Add("은열쇠");
        }
    }

    private void shuffle<T>(List<T> list)
    {
        for(int i=0; i<list.Count; i++)
        {
            int rand= UnityEngine.Random.Range(i, list.Count);
            (list[i], list[rand]) = (list[rand], list[i]);
        }
    }

   private void Placement() 
    {
        // 16장의 카드 셔플
        shuffle(usingCard);

        // 각 뒤집혀진 카드에 데이터를 배치하기 
        for (int i = 0; i<usingCard.Count;i++)
        {
            CardSlot slot = slots[i].GetComponent<CardSlot>();
            slot.Indata(usingCard[i]);
        }

    }

    public void UseExcludingkey()
    {
        ExcludingKey();
    }
    private void ExcludingKey()
    {
        // RememberCard에 찾은 은열쇠를 제외하기.
        if(keyNum == 15)
        {
            rememberCard.Remove(rememberCard[keyNum]);
            keyNum--;
        }
        else if (keyNum == 14)
        {
            rememberCard.Remove(rememberCard[keyNum]);
            keyNum--;
        }
        else if (keyNum == 13)
        {
            rememberCard.Remove(rememberCard[keyNum]);
            keyNum--;
        }

    }

    private void RePlaceMent()
    {
        //usingCard를 싹 비우고, 이미뽑아낸 은열쇠가 제외된 rememberCard를 넣음
        usingCard.Clear();
        usingCard = rememberCard;

        // 모든 카드를 뒤집기 - 비활성화된 카드뒷면 버튼의 스케일 복원 및 활성화

        // 셔플 후 각 뒤집혀진 카드에 데이터를 배치하기 
        Placement();
    }

}