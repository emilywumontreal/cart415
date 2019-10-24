using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicControl : MonoBehaviour
{

    public AudioSource aud;
   public  float average = 0f;
    // Start is called before the first frame update
    void Start()
    {
        foreach (var device in Microphone.devices)
        {
           // Debug.Log("Name: " + device);
        }
        // AudioSource aud = GetComponent<AudioSource>();
        aud.clip = Microphone.Start(Microphone.devices[0], true, 1, 4400);
        aud.loop = true;
        while (!(Microphone.GetPosition(null) > 0)) { }
        aud.Play();
        //Debug.Log("start playing... position is " + 
        Microphone.GetPosition(null);
    }

    // Update is called once per frame
    void Update()
    {
        float[] spectrum = new float[256];
        // Get all of our samples from the mic. and access the 
        //frequencies...
        aud.GetOutputData(spectrum, 0);

        aud.GetSpectrumData(spectrum, 0, FFTWindow.Rectangular);
       
        for (int i = 0; i < spectrum.Length - 1; i++)
        {
            average += spectrum[i];
        }
        average = average / spectrum.Length;
        //average = average * 10000;
        //Debug.Log("average freq " + average*10000);

        //Debug.Log(aud.clip.frequency);
    }
}


/*public class MicControl : MonoBehaviour
{
    AudioClip microphoneInput;
    bool microphoneInitialized;
    public float sensitivity;
    public bool flapped;

    private void Start()
    {
        if (Microphone.devices.Length > 0)
        {
            microphoneInput = Microphone.Start(Microphone.devices[0], true, 999, 44100);
            microphoneInitialized = true;
        }
    }
    private void FixedUpdate()
    {
        //get mic volume
        int dec = 128;
        float[] waveData = new float[dec];
        int micPosition = Microphone.GetPosition(null) - (dec + 1); // null means the first microphone
        microphoneInput.GetData(waveData, micPosition);

        // Getting a peak on the last 128 samples
        float levelMax = 0;
        for (int i = 0; i < dec; i++)
        {
            float wavePeak = waveData[i] * waveData[i];
            if (levelMax < wavePeak)
            {
                levelMax = wavePeak;
            }
        }
        float level = Mathf.Sqrt(Mathf.Sqrt(levelMax));
        //check if level is above the threshold:sensitivity.

        if (level > sensitivity && !flapped)
        {
          //  AndriodJump();
            flapped = true;
        }
        if (level < sensitivity && flapped)
            flapped = false;
    }

}


}
/*
AudioClip microphoneInput;
bool microphoneInitialized;
public float sensitivity;
public bool flapped;
You've gotta init the mic in Awake():

    //init microphone input
    if (Microphone.devices.Length>0){
        microphoneInput = Microphone.Start(Microphone.devices[0],true,999,44100);
        microphoneInitialized = true;
    }
    
//reference that mic in Update():

    //get mic volume
    int dec = 128;
    float[] waveData = new float[dec];
    int micPosition = Microphone.GetPosition(null)-(dec+1); // null means the first microphone
    microphoneInput.GetData(waveData, micPosition);
    
    // Getting a peak on the last 128 samples
    float levelMax = 0;
    for (int i = 0; i < dec; i++) {
        float wavePeak = waveData[i] * waveData[i];
        if (levelMax < wavePeak) {
            levelMax = wavePeak;
        }
    }
    float level = Mathf.Sqrt(Mathf.Sqrt(levelMax));
//check if level is above the threshold:sensitivity.

    if (level>sensitivity && !flapped){
        Flap ();
        flapped = true
    }
    if (level<sensitivity && flapped)
        flapped = false;
    }
    
//need a slider to adjust the sensitivity variable on the jump to adjust for the mic being able to pick up a wider range of volumes.

    */
