using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class CardPlacementManger : MonoBehaviour
{
    [SerializeField] private List<GameObject> Cards;
    [SerializeField] private List<GameObject> slots;
    [SerializeField] private List<string> usingCard;

    private void Awake()
    {   // usingCard 리스트에 16장의 카드를 추가
        usingCard = new List<string>();
        //0,1,2 은열쇠
        for (int i = 0; i <= 2; i++)
        {
            usingCard.Add("은열쇠");
        }
        //3,4 살인마의 함정
        for (int i = 0; i <= 1; i++)
        {
            usingCard.Add("살인마의 함정");
        }
        //5,6,7,8 최면가스
        for (int i = 0; i <= 3; i++)
        {
            usingCard.Add("최면가스");
        }
        // 9,10,11 작은단서
        for (int i = 0;i<=2;i++)
        {
            usingCard.Add("작은단서");
        }
        // 12,13 아무것도없는방
        for (int i = 0; i <= 1; i++)
        {
            usingCard.Add("아무것도없는방");
        }
        usingCard.Add("방탄조끼");
        usingCard.Add("탈출구");

    }

    private void shuffle<T>(List<T> list)
    {
        for(int i=0; i<list.Count; i++)
        {
            int rand= Random.Range(i, list.Count);
            (list[i], list[rand]) = (list[rand], list[i]);
        }
    }

    public void Placement()
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

    private void RePlaceMent()
    {
        // 이미뽑아낸 은열쇠를 제외한 카드 회수

        // 카드 셔플

        // 모든 카드를 다시 뒤집기

        // 각 뒤집혀진 카드에 데이터를 배치하기 

    }

   
}
