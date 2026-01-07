using System;
using UnityEngine;

public class Card : MonoBehaviour
{
    [SerializeField] private CardEffectManager cardEffectManager;
    [SerializeField] private string cardName;

    

    private void showEffect()
    {
        cardEffectManager.activate(cardName);
    }

}
