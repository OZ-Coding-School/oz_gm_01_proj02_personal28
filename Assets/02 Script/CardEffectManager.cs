
using UnityEngine;

public class CardEffectManager : MonoBehaviour
{
  
    public void activate(string name)
    {
        Effect(name);
    }

    private void Effect(string effectName)
    { // 각 종류의 카드 효과를 일괄 관리
        switch(effectName)
        {
            case "방탄조끼":
                BulletProof();
                break;
            case "최면가스":
                HypnoticGas();
                break;
            case "아무것도없는방":
                EmptyRoom();
                break;
            case "은열쇠":
                SilverKey();
                    break;
            case "살인마의함정":
                KillersTrap();
                break;
            case "작은단서":
                LittleProviso();
                break;
            case "탈출구":
                WayOut();
                break;

        }
    }

    private void BulletProof()
    {
        //방탄조끼
    }
    private void HypnoticGas()
    {
        //최면가스
    }
    private void EmptyRoom()
    {
        //아무것도없는방
    }
    private void KillersTrap()
    {
        // 살인마의함정
    }
    private void SilverKey()
    {
        //은열쇠
    }
    private void LittleProviso()
    {
        //작은단서
    }
    private void WayOut()
    {
        //탈출구
    }
}
