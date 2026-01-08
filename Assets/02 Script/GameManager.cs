
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private CardPlacementManger cardPlacement;
    [SerializeField] private CardEffectManager cardEffect;
    [SerializeField] private List<CardSlot> slots;
    [SerializeField] private List<CardButton> Buttons;
    [SerializeField] private int ReversCount;



    //private bool gameover = false;
   // private bool gameClear = false;




    private void Start()
    {
        cardPlacement.useLogic();
    }
   
    

    private void ReStartGame()
    {

    }
}
