
using System.Collections.Generic;

using UnityEngine;


public class CardSlot : MonoBehaviour
{
    [SerializeField] private string cardName;
    [SerializeField] private CardPlacementManger cardPlacementManger;
    [SerializeField] private CardEffectManager cardEffectManager;
    [SerializeField] private int keyCount;
    

    public void Indata(string name)
    {
        cardName = name;
    }

    public void callingcardOut()
    { //버튼용.
        CardCall(cardName);
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
            cardPlacementManger.useCardNum = 6;
            
        }
        else
        {
            cardPlacementManger.useCardNum = 5;
            
        }
    }

    private void CardCall(string name)
    {
        cardPlacementManger.currentSlot = this;
        switch (name)
        {
            case "방탄조끼":
                cardPlacementManger.useCardNum = 0;
                break;
            case "최면가스":
                cardPlacementManger.useCardNum = 1;
                break;
            case "아무것도없는방":
                cardPlacementManger.useCardNum = 5;
                break;
            case "은열쇠":
                cardPlacementManger.useCardNum = 3;
                // 얻은 카드 제외용
                break;
            case "살인마의함정":
                cardPlacementManger.useCardNum = 2;
                break;
            case "작은단서":
                cardPlacementManger.useCardNum = 4;
                break;
            case "탈출구":
                ExitCard();
                break;

        }
        cardPlacementManger.CallingMoveCardImage();
        cardEffectManager.activate(name);

    }
}
