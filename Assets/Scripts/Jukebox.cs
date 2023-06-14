using UnityEngine;

public class Jukebox : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] playlist;

    public int playlistIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        PlayClip();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > audioSource.clip.length)
        {
            playlistIndex++;
            PlayClip();
        }
    }

    void PlayClip()
    {
        audioSource.Stop();
        audioSource.clip = playlist[playlistIndex];
        audioSource.Play();
    }
}
