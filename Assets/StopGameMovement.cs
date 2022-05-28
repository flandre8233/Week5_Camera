using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopGameMovement : MonoBehaviour
{
    [SerializeField] PlayerMovement PlayerMovement;
    [SerializeField] PlayerPeep playerPeep;
    [SerializeField] PlayerRotation PlayerRotation;
    [SerializeField] RightCameraSwitcher switcher;
    [SerializeField] WatcherReporter reporter;
    [SerializeField] Footsteps.CharacterFootsteps footsteps;

    private void OnEnable()
    {
        PlayerMovement.enabled = false;
        playerPeep.enabled = false;
        PlayerRotation.enabled = false;
        switcher.enabled = false;
        reporter.enabled = false;
        footsteps.enabled = false;
        GlobalResourceSound.SpawnSound("Gameover", transform.position);
    }
}
