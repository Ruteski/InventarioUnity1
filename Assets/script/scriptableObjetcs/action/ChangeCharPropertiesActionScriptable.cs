using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewChangeCharPropertiesAction", menuName = "Action/NewChangeCharPropertiesAction")]
public class ChangeCharPropertiesActionScriptable : GenericActionScriptable
{
   #region Declaration

   [SerializeField]
   [Range(-100f, 100f)]
   private float life;

   [SerializeField]
   [Range(-100f, 100f)]
   private float mana;

   [SerializeField]
   [Range(0f, 4f)]
   private float speed;

   [SerializeField]
   [Range(0f, 10f)]
   private float jump;

   [SerializeField]
   private bool applyNewGravity;

   [SerializeField]
   [Range(1f, 4f)]
   private bool gravity;

   [SerializeField]
   private bool applyNewPos;

   [SerializeField]
   private Vector3 newPos;

   [SerializeField]
   private bool resetJump;

   [SerializeField]
   private bool resetGravity;

   [SerializeField]
   private bool resetSpeed;

   #endregion

   #region Methods

   public override IEnumerator Execute() {
      yield return new WaitForSeconds(DelayToStart);

      if(life != 0) {
         //GameController => Funcao()
      }

      if(mana != 0) {
         //GameController => Funcao()
      }

      if(speed != 0) {
         //GameController => Funcao()
      }

      if(jump != 0) {
         //GameController => Funcao()
      }

      if(applyNewGravity) {
         //GameController => Funcao()
      }

      if(applyNewPos) {
         //GameController => Funcao()
      }

      if(resetJump) {
         //GameController => Funcao()
      }

      if(resetGravity) {
         //GameController => Funcao()
      }

      if(resetSpeed) {
         //GameController => Funcao()
      }
   }

   #endregion
}
