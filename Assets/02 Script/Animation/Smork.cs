using UnityEngine;
using UnityEngine.UI;

public class Smork : MonoBehaviour
{
    [SerializeField] private float x = 0f, y = 0.02f;
    [SerializeField] private RawImage BackImage;

    private Coroutine _scrollcoroutine;

    void Update()
    {
        BackImage.uvRect = new Rect(BackImage.uvRect.position + new Vector2(x, y) * Time.deltaTime, BackImage.uvRect.size);
    }
}
