using System;
using UnityEngine;

namespace Main.Script
{
    public class AnimatorController : MonoBehaviour
    {
        
        public Vector3 AnimatorPositionChange { get;  set; }
        [SerializeField] private Animator anim;


        public void PlayVictim()
        {
            anim.Play("victim");
        }

        public void PlayAttack()
        {
            anim.Play("attack");
        }
        
        


        private void Start()
        {
            anim = GetComponent<Animator>();
        }

        private void OnAnimatorMove()
        {
           // Debug.Log($"{anim.deltaPosition}|{anim.deltaRotation}");

           AnimatorPositionChange = anim.deltaPosition;
        }
    }
}
