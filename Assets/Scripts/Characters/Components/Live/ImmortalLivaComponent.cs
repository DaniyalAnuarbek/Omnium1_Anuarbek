using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImmortalLivaComponent : ILiveComponent
{
    float ILiveComponent.MaxHealth 
    {
        get => 1; 
       
    }
    float ILiveComponent.Health 
    { 
        get => 1; 
        
    }

    public event Action<Character> OnCharacterDeath;

    public void Initialize(Character selfCharacter)
    {
        // throw new NotImplementedException();
    }

    public void SetDamage(float damage)
    {
        Debug.Log("I am immortal");
    }

    void ILiveComponent.SetDamage(float damage)
    {
        
    }
}
