
using UnityEngine;

public class AudioSFX : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip gameOverClip;
    [SerializeField] private AudioClip magicMissleLaunchClip;
    [SerializeField] private AudioClip takeDamageClip;

    public void PlayGameOver() {
        audioSource.PlayOneShot(gameOverClip);
    }

    public void PlayMagicMissleLaunch() {
        audioSource.PlayOneShot(magicMissleLaunchClip);
    }

    public void PlayTakeDamage() { 
        audioSource.PlayOneShot(takeDamageClip);
    }
}
