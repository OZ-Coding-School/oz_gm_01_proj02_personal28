using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CardSlot : MonoBehaviour
{
    [SerializeField] private string cardName;
    [SerializeField] private List<GameObject> Cards;
    [SerializeField] private CardPlacementManger cardPlacementManger;
    [SerializeField] private CardEffectManager cardEffectManager;
    [SerializeField] private Transform parent;
    [SerializeField] private GameObject currentCard;
    [SerializeField] private List<GameObject> Keyslots;
    [SerializeField] private List<GameObject> buttons;
    [SerializeField] private UnityEngine.UI.RawImage shild;
    [SerializeField] private UnityEngine.UI.RawImage shild2;
    [SerializeField] private int keyCount;


   private Tween ScaleTween;

    public void Indata(string name)
    {
        cardName = name;
    }

    public void callingcardOut()
    {
        CardCall(cardName);

        //최면가스 발동시에 버튼 활성화 하는 메서드도 필요.
    }



    private void CardCall(string name)
    {
        switch (name)
        {
            case "방탄조끼":
                spawn(Cards[0]);
                break;
            case "최면가스":
                spawn(Cards[1]);
                break;
            case "아무것도없는방":
                spawn(Cards[2]);
                break;
            case "은열쇠":
                spawn(Cards[3]);
                
                cardPlacementManger.AddKeyCount();
                Cueingslot();
                keyCardListDel();
                break;
            case "살인마의함정":
                spawn(Cards[4]);
                break;
            case "작은단서":
                spawn(Cards[5]);
                break;
            case "탈출구":
                ExitCard();
                break;
        }
        cardEffectManager.activate(name);

    }
    public void CallKeyCount()
    {
        cardPlacementManger.UseingKeycount();
        keyCount = cardPlacementManger.usekeyCount ;
    }
    private void ExitCard()
    {
        CallKeyCount();
        if (keyCount == 3)
        {
            spawn(Cards[6]);
        }
        else
        {
            spawn(Cards[2]);
        }
    }

    private void keyCardListDel()
    {
        //열쇠가 뽑히면 Card PlacementManager에서 은열쇠 데이터를 하나를 지움
        cardPlacementManger.UseExcludingkey();
    }
    private void slotMove(Transform target, Transform newParent)
    {
       StartCoroutine(MovingSlot(target, newParent));
    }
    private IEnumerator MovingSlot(Transform target, Transform newParent)
    {
        //은열쇠를 열쇠 슬롯의 자식으로 만들고 해당 위치로 옮겨줘야 함.
        shild2.gameObject.SetActive(true); // 패널로 가려서 버튼이 안눌리게
        Vector3 wordposition = target.position;

        yield return new WaitForSeconds(2f);
        
        target.DOMove(newParent.position, 1.0f).SetEase(Ease.InOutSine).OnComplete(() =>
        {
            target.SetParent(newParent, true);
            shild2.gameObject.SetActive(false); //끝나고나서 패널 치워서 버튼 눌리게
        });
        

    }

    private void Cueingslot()
    {
        for (int i = 0; i < Keyslots.Count; i++)
        {
            if (Keyslots[i].transform.childCount == 0)
            {
                // 열쇠슬롯의 자식 오브젝트의 갯수가 0이라면, SlotMove를 실행한다.
                //해당 번호수의 키슬롯으로 이동 시킨다.
               
                slotMove(currentCard.transform, Keyslots[i].transform);
                return;
            }
        }

        Debug.Log("열쇠 슬롯이 없습니다. 비정상적인 열쇠 갯수입니다.");

    }
    private void spawn(GameObject Prefabs)
    {
        currentCard = Instantiate(Prefabs, parent);
        currentCard.transform.localPosition = Vector3.zero;
        currentCard.transform.DOScaleX(0, 0);
        StartCoroutine(Dlaying());
        
    }

    private IEnumerator Dlaying()
    {
        yield return new WaitForSeconds(1);
        currentCard.transform.DOScaleX(1, 1).OnComplete(()=>
        {
            shild.gameObject.SetActive(false);
        });

    }
}
