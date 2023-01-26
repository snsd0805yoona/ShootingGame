using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Windows.Speech;

public class Damageble : MonoBehaviour
{
    [SerializeField] private Health health;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private UnityEvent damaged;

    private Color _defaultColor;
    public void TakeDamage(int damage) {
        health.DecreaseHealth(damage);
        spriteRenderer.DOColor(Color.red, 0.2f).SetLoops(2, LoopType.Yoyo).ChangeStartValue(_defaultColor);
        damaged.Invoke();

    }

    private void Awake()
    {
        _defaultColor = spriteRenderer.color;
    }
}