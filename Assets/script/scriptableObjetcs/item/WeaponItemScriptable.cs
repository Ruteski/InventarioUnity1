using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewWeaponItem", menuName = "Inventory/items/NewWeaponItem")]
public class WeaponItemScriptable : GenericItemScriptable
{
   [SerializeField]
   private List<GenericActionScriptable> actionEquipList;

   public override void ActionEquipAndUnequipListDispatch() {
      actionManagerEvent = new ActionManagerEvent();
      actionManagerEvent.DispatchAllGenericActionListEvent(actionEquipList);
   }
}
