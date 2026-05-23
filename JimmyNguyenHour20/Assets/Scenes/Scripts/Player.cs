using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update

    private ParticleSystemRenderer particleRenderer;


    [Header("references")]
    public GameManager manager;
    public Material phaseMat;

    [Header("Gameplay")]
    public float bounds = 3f;
    public float strafeSpeed = 4f;
    public float phaseCooldown = 2f;

    Renderer mesh;
    Collider collision;
    bool canPhase = true;

    void Start()
    {
        particleRenderer = GetComponentInChildren<ParticleSystemRenderer>();
        collision = GetComponent<Collider>();

       
        if (particleRenderer != null)
        {
            particleRenderer.GetComponent<ParticleSystem>().Stop();
        }
    }

   
    void Update()
    {
        float xMove = Input.GetAxis("Horizontal") * Time.deltaTime * strafeSpeed;

        Vector3 position = transform.position;
        position.x += xMove;
        position.x = Mathf.Clamp(position.x, -bounds, bounds);
        transform.position = position;

        
        if (Input.GetKeyDown(KeyCode.Space) && canPhase)
        {
            canPhase = false;
            collision.enabled = false;

            particleRenderer.material = phaseMat;
            particleRenderer.GetComponent<ParticleSystem>().Play(); 

            Invoke("PhaseIn", phaseCooldown);
        }
    }

    void PhaseIn()
    {
        canPhase = true;
        collision.enabled = true;

        particleRenderer.GetComponent<ParticleSystem>().Stop();
    }
}