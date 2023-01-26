using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;
    [SerializeField] private UnityEvent<Vector2> moveDirection;

    private void FixedUpdate()
    {
        var playerPosition = PlayerManager.Position;
        var enemyPosition = (Vector2)transform.position;
        var direction = playerPosition - enemyPosition;
        direction.Normalize();
        var targetPosition = enemyPosition + direction;
        rb.DOMove(targetPosition, speed).SetSpeedBased();
        moveDirection.Invoke(direction);
    }
}
