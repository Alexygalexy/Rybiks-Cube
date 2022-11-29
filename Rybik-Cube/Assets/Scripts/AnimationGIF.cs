using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationGIF : MonoBehaviour
{
    public Sprite[] animImages;
    public SpriteRenderer animImageObj;


    void Start()
    {
        
    }


    void Update()
    {
        animImageObj.sprite = animImages[(int)(Time.time * 45) % animImages.Length];
    }
}
