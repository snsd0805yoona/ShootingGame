using Timers;
using UnityEngine;
using UnityEngine.Events;

public class MagicMissle : MonoBehaviour
{
    [SerializeField] private MissleCreator missleCreator;
    [SerializeField] private UnityEvent missleLaunch;
    private void LaunchMissle() {
        missleCreator.CreateMissle();
        missleLaunch.Invoke();
    }

    private void Awake()
    {
        TimersManager.SetLoopableTimer(this, 1, LaunchMissle);
    }
}
