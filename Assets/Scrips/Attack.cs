using UnityEngine;

public class Attack : MonoBehaviour
{

    public GameObject Melee;
    bool isAttacking = false;
    float atkDuration = 0.3f;
    float atkTimer = 0f;

    void Update()
    {

        MeleeTimer();

        if (Input.GetKeyDown(KeyCode.E))
        {
            OnAttack();
        }
    }


    void OnAttack()
    {
        if (!isAttacking)
        {
            Melee.SetActive(true);
            isAttacking = true;
        }
    }

    void MeleeTimer()
    {
        if (isAttacking)
        {
            atkTimer += Time.deltaTime;
            if (atkTimer >= atkDuration)
            {
                atkTimer = 0f;
                isAttacking = false;
                Melee.SetActive(false);
            }
        }
    }


}
