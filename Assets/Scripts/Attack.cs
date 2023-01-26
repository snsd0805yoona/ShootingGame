using Timers;
using UnityEngine;
using UnityEngine.Events;

public class Attack : MonoBehaviour
{
    [SerializeField] private string targetTag;
    [SerializeField] private UnityEvent attack;
    private bool _canAttack = true;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        DealDamage(collision);
    }

    private void CanAttack() { 
        _canAttack = true;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        DealDamage(collision);    
    }

    private void DealDamage(Collider2D collision) {
        if (!_canAttack) return;
        if (collision.CompareTag(targetTag))
        {
            var damageble = collision.GetComponent<Damageble>();
            damageble.TakeDamage(10);
            TimersManager.SetTimer(this, 1, CanAttack);
            _canAttack = false;
            attack.Invoke();
        }
    }
}
