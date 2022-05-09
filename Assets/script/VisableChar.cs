using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisableChar : MonoBehaviour
{
    SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }
    IEnumerator VisableSprite()
    {
        for (float f = 1f; f >= -0.05; f -= 0.2f)
        {
            Color color = sprite.material.color;
            color.a = f;
            sprite.material.color = color;
            yield return new WaitForSeconds(0.05f);
        }
    }

    public void StartVisable()
    {
        StartCoroutine("VisableSprite");
    }
}
