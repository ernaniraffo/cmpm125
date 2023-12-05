using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public ParticleManager particleManager;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        particleManager = FindObjectOfType<ParticleManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAudio(AudioClip clip)
    {
        audioSource.PlayOneShot(clip, 0.9f);
        ParticleSystem ps = Instantiate(particleManager.particles, transform);
        ps.transform.SetParent(transform);
        ps.transform.position = transform.position;
        ps.Play();
        ps.Emit(5);
    }
}
