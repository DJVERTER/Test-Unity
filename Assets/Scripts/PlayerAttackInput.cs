using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackInput : MonoBehaviour
{
    private CharacterAnimations playerAnimation;

    public GameObject attackPoint;

    private PlayerShield shield;

    private CharacterSoundFX soundFX;
    void Awake()
    {
        playerAnimation = GetComponent<CharacterAnimations>();
        shield = GetComponent<PlayerShield>();

        soundFX = GetComponentInChildren<CharacterSoundFX>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            playerAnimation.Defend(true);

            shield.ActivateShield(true);
        }

        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            playerAnimation.UnFreezeAnimation();
            playerAnimation.Defend(false);

            shield.ActivateShield(false);
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //if (Random.Range(0, 2) > 0)
            //{
                playerAnimation.Attack_2();
                soundFX.Attack_2();
            //}
            //else
            //{
            //    playerAnimation.Attack_2();
            //    soundFX.Attack_2();
            //}
        }
    }

    void Activate_AttackPoint()
    {
        attackPoint.SetActive(true);
    }

    void Deactivate_AttackPoint()
    {
        if (attackPoint.activeInHierarchy)
        {
            attackPoint.SetActive(false);
        }
    }
}
