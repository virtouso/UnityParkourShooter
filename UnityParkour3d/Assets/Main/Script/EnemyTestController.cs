using System;
using UnityEngine;

namespace Main.Script
{
    public class EnemyTestController : MonoBehaviour
    {
        public void PlayVictim( Vector3  attackerPosition )
        {
            anim.PlayVictim();

            var dir = attackerPosition - transform.position;

            
            transform.rotation = Quaternion.LookRotation(dir, Vector3.up);
        }
        
        
        
        [SerializeField] private AnimatorController anim;


        private void Update()
        {
            transform.position += anim.AnimatorPositionChange;
            anim.AnimatorPositionChange = Vector3.zero;
        }
    }
}
