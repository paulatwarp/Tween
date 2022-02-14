using UnityEngine;
using DG.Tweening;

public class Select : MonoBehaviour
{
    void OnMouseEnter()
    {
        DOTween.Complete(transform);
        transform.DOLocalMoveY(0.25f, 0.1f);
    }

    void OnMouseExit()
    {
        DOTween.Complete(transform);
        transform.DOLocalMoveY(0.0f, 0.1f);
    }
}
