using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public List<AudioSource> audioSources = new List<AudioSource>();
    public List<KeyCode> ButtonInput = new List<KeyCode>();
    private IEnumerator coroutine;

    public void PlayNote(int listIndex)
    {
        audioSources[listIndex].Play();
    }

    private void Update()
    {
        for (int i = 0; i < ButtonInput.Count; i++)
        {
            if (Input.GetKeyDown(ButtonInput[i]))
            {
                audioSources[i].Play();
            }
        }
    }

    public void PlayPreview()
    {
        StartCoroutine(coroutine = Preview());
    }

    public void StopPreview()
    {
        StopCoroutine(coroutine);
    }

    private IEnumerator Preview()
    {
        audioSources[0].Play();
        yield return new WaitWhile(() => audioSources[0].isPlaying);
        audioSources[11].Play();
        yield return new WaitWhile(()=> audioSources[11].isPlaying);
        audioSources[2].Play();
        yield return new WaitWhile(() => audioSources[2].isPlaying);
        audioSources[15].Play();
        yield return new WaitWhile(() => audioSources[15].isPlaying);
        audioSources[7].Play();
        yield return new WaitWhile(() => audioSources[7].isPlaying);
        audioSources[5].Play();
        yield return new WaitWhile(() => audioSources[5].isPlaying);
        audioSources[8].Play();
        yield return new WaitWhile(() => audioSources[8].isPlaying);
        audioSources[13].Play();
        yield return new WaitWhile(() => audioSources[13].isPlaying);
    }
}