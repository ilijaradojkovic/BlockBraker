using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour
{
    [SerializeField] GameObject particleEffect;
 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (gameObject.tag != "ImmortalBlock" && collision.gameObject.tag=="Ball")
        {
           
            Destroy(gameObject, 0.05f);
            TriggerParticleEffect();
        }
        else if(gameObject.tag=="ImmortalBlock")
        {
            
            GetComponent<SpriteRenderer>().color = Color.black;
            Destroy(gameObject, 10f);
            gameObject.SetActive(true);
            TriggerParticleEffect();
        }
    }
    public void TriggerParticleEffect()
    {
        Vector3 novaPosParticle = new Vector3();
        novaPosParticle.x = transform.position.x;
        novaPosParticle.y = transform.position.y;
        novaPosParticle.z = -2;
        GameObject particleEffectInstantieted = Instantiate(particleEffect, novaPosParticle, transform.rotation);
        
    }
    


}
