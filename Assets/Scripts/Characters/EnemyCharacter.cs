using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyCharacter : Character
{
    [SerializeField] private AIState currentState;


   
    public float timeBetweetAttackCounter = 0;

    public override Character CharacterTarget => 
        GameManager.Instance.CharacterFactory.Player;

    public override void Initialize() 
    {
        base.Initialize();

        LiveComponent = new ImmortalLivaComponent();
        DamageComponent = new CharacterDamageComponent();

    }


    public override void Update()
    {
        switch (currentState) 
        {
            case AIState.none:

                break;

            case AIState.MoveToTarget:
                Vector3 direction = CharacterTarget.transform.position - transform.position;
                direction.Normalize();

                MovableComponent.Move(direction);
                MovableComponent.Rotation(direction);


                if (Vector3.Distance(CharacterTarget.transform.position, transform.position) < 3 
                    & timeBetweetAttackCounter <= 0)
                {
                    DamageComponent.MakeDamage(CharacterTarget);
                    timeBetweetAttackCounter = characterData.timeBetweenAttacks;
                }

                if (timeBetweetAttackCounter > 0)
                    timeBetweetAttackCounter -= Time.deltaTime;



                break;

        }
    }
}
