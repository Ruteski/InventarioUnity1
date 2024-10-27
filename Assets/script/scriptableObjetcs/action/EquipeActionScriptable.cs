using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewEquipAction", menuName = "Action/NewEquipAction")]
public class EquipeActionScriptable : GenericActionScriptable
{
   [SerializeField]
   private ItemEquip ItemEquip;

   public override IEnumerable Execute() {
      yield return new WaitForSeconds(DelayToStart);

      // GameController -> EquipChar(ItemEquip)
   }
}
