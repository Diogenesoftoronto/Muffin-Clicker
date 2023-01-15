using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeSlider : MonoBehaviour
{
    // Start is called before the first frame update
    // Create a integer variable that is public called default volume
    public static int defaultVolume = 45;
    public GameObject Music;
    void Start()
    {
        // On start we want set the volume to the default
        // Find the BackgroundMusic Game Object.
        Music = GameObject.Find("Music");
        if (Music != null) {
            print(Music);
            return null;
        }
       Component MusicAudioComponent = Music.GetComponent<AudioSource>();
        if (MusicAudioComponent != null) {
            print(MusicAudioComponent);
            return null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        /* check to see the position of the slider 
        and set the volume at that position. */
        

    }
}
