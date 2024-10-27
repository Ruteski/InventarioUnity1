using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewChangeCharPropertiesAction", menuName = "Action/NewChangeCharPropertiesAction")]
public class ChangeCharPropertiesActionScriptable : GenericActionScriptable
{
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
   private Vector3 newPos;

   [SerializeField]
   private bool resetJump;

   [SerializeField]
   private bool resetGravity;

   [SerializeField]
   private bool resetSpeed;



   public override IEnumerator Execute() {
      yield return new WaitForSeconds(DelayToStart);

      // GameController -> ShowPopup
   }
}
