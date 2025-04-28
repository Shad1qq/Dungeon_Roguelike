using UnityEngine;
using DG.Tweening;

public class ItemRotate : MonoBehaviour
{
    [SerializeField]private float _magnitude;
    [SerializeField]private float _yminPos;

    private void Update()
    {
        transform.Rotate(Vector3.up * _magnitude);
        if(transform.position.y >= 1f)
        {
            transform.DOMoveY(transform.position.y - _yminPos, 1f);
        }
        if (transform.position.y <= 0.8f)
        {
            transform.DOMoveY(transform.position.y + _yminPos, 1f);
        }

    }
    private void OnDisable()
    {
        DOTween.Clear(true);
    }
}
