using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantEmitter : MonoBehaviour
{

    public Light lightSource;
    public ParticleSystem particles;

    // Start is called before the first frame update
    void Start()
    {
        lightSource = GetComponentInChildren<Light>();
        particles = Instantiate(particles, transform);
        particles.transform.position = transform.position;
        particles.transform.localScale = transform.localScale;
        particles.transform.rotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (particles.particleCount == 0)
        {
            particles.Play();
            particles.Emit(25);
        }
        lightSource.enabled = particles.particleCount > 1;
        lightSource.intensity = particles.particleCount * 0.1f;
        if (! lightSource.enabled)
        {
            particles.Stop();
        }
    }
}
