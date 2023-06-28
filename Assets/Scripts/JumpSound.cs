using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    public AudioClip soundClip;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlaySound();
    }

    private void PlaySound()
    {
        audioSource.PlayOneShot(soundClip);
    }
}
