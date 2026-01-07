using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSlot : MonoBehaviour
{
    [SerializeField] private string cardName;
    [SerializeField] private CardPlacementManger cardPlacementManger;

    
    public void Indata(string name)
    {
        cardName = name;
    }

    public void CallingCard()
    {
        
            
    }


}
