using DG.Tweening;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float _speed;
    private Vector2 _inputDirection;
    
    public void Move(InputAction.CallbackContext context) {
        _inputDirection = context.ReadValue<Vector2>();
    }

    public void FixedUpdate() {
        var position = (Vector2)transform.position;
        var targetPosition = position + _inputDirection;
        if (position == targetPosition) return;
        rb.DOMove(targetPosition, _speed).SetSpeedBased();
    }
}
