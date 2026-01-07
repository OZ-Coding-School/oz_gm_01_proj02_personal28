using DG.Tweening;
using UnityEngine;

public class CardButton : MonoBehaviour
{
    [SerializeField] private UnityEngine.UI.Button playButton;
    [SerializeField] private UnityEngine.UI.RawImage shild;
    private Tween ScaleTween;

    public void UseFor()
    {
        shild.gameObject.SetActive(true);
        ButtonDeactivation();
    }
    private void ButtonDeactivation()
    {
       ScaleTween = transform.DOScaleX(0, 1f).OnComplete(() =>
        {
            gameObject.SetActive(false);
            ScaleTween.Kill();
            
            // 이것이 완료 될때까지. 앞에 투명 패널로 가려, 버튼이 안눌리게 하자.
        });
    }
}
