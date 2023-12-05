using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantEmitter : MonoBehaviour
{

    public Light lightSource;
    public ParticleSystem particles;

    public AudioClip clip1;
    public AudioClip clip2;
    public AudioClip clip3;
    AudioSource audioSource;

    public List<AudioClip> clips;

    // Start is called before the first frame update
    void Start()
    {
        lightSource = GetComponentInChildren<Light>();
        particles = Instantiate(particles, transform);
        particles.transform.position = transform.position;
        particles.transform.localScale = transform.localScale;
        particles.transform.rotation = transform.rotation;

        clips = new List<AudioClip>() { clip1, clip2, clip3};
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (particles.particleCount == 0)
        {
            particles.Play();

            if (clip1 && clip2 && clip3)
            {
                int randomIndex = Random.Range(0, 3);
                AudioClip clipToPlay = clips[randomIndex];
                Debug.Log("Playing sound!");
                audioSource.PlayOneShot(clipToPlay, 0.7f);
            }

            StartCoroutine(LightsInSuccession());
        }
        if (particles.particleCount > 15)
        {
            var particlesMain = particles.main;
            particlesMain.startColor = Color.green;
        } else
        {
            var particlesMain = particles.main;
            particlesMain.startColor = Color.white;
        }
        lightSource.enabled = particles.particleCount > 1;
        lightSource.intensity = particles.particleCount * 0.1f * 1e+05f;
        if (! lightSource.enabled)
        {
            particles.Stop();
        }
    }

    IEnumerator LightsInSuccession()
    {
        for (int i = 0; i < 4; i += 1)
        {
            particles.Emit(5);
            yield return new WaitForSeconds(1.5f);
        }
    }
}
