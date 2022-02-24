using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool isPackagePicked = false;
    [SerializeField] float destroyDelay = 0.5f;

    [SerializeField] Color32 hasPackageColor = new Color32(243,61,241,255); // pink
    [SerializeField] Color32 hasNoPackageColor = new Color32(255, 255, 255, 255); // original color

    SpriteRenderer spriteRenderer;

    void Start(){
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collided !!");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Debug.Log("Trigger Enter !!");

        if (other.tag == "Package" && !isPackagePicked)
        {
            isPackagePicked = true;
            Debug.Log("Package picked !");

            spriteRenderer.color = hasPackageColor;
            
            Destroy(other.gameObject, destroyDelay);
        }
        else if (other.tag == "Customer" && isPackagePicked)
        {
            isPackagePicked = false;
            Debug.Log("Delivered package!");
            spriteRenderer.color = hasNoPackageColor;
            //Destroy(other.gameObject);
        }
    }
}