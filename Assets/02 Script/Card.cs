using System;
using UnityEngine;

public class Card : MonoBehaviour
{
    [SerializeField] private CardEffectManager cardEffectManager;
    [SerializeField] private string cardName;

    private void Awake()
    { // 카드 이팩트매니저 불러오기
        cardEffectManager = cardEffectManager.GetComponent<CardEffectManager>();
    }

    private void showEffect()
    {
        cardEffectManager.activate(cardName);
    }

}
