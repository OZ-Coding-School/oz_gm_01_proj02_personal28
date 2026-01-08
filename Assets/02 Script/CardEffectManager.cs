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
        //방탄조끼 : 게임 오버관련 임으로 살인마의 함정 이후작성
        Debug.Log("방탄조끼");
    }
    private void HypnoticGas()
    {
        //최면가스 : 기능 자체는 이미 되어있음.
        Debug.Log("최면가스");
    }
    private void EmptyRoom()
    {
        //아무것도없는방
        Debug.Log("아무것도없는방.");
    }
    private void KillersTrap()
    {
        // 살인마의함정 게임오버 기능
        Debug.Log("살인마의 함정");
    }
    private void SilverKey()
    {
        //은열쇠 
        Debug.Log("은열쇠");
    }
    private void LittleProviso()
    {
        //작은단서 - 어떻게 구현할까?
        //다른 방식으로?
        Debug.Log("작은단서");
    }
    private void WayOut()
    {
        //탈출구 게임 클리어 기능
        Debug.Log("탈출구");
    }
}
