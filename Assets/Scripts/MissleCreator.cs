using UnityEngine;

public class MissleCreator : MonoBehaviour
{
    [SerializeField] private GameObject misslePrefab;
    [SerializeField] private Transform playerTransform;
    public void CreateMissle() {
        Instantiate(misslePrefab, playerTransform.position, Quaternion.identity);
    }
}
