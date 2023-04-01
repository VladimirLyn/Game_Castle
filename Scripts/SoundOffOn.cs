using UnityEngine;

public class SoundOffOn : MonoBehaviour
{
    public AudioSource Audio;
    bool sound = true;

    public void Sound()
    {
        if (sound)
        {
            Audio.Pause();
            sound = false;
        }
        else if (!sound)
        {
            Audio.Play();
            sound = true;
        }
    }
}
