using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewArmorItem", menuName = "Inventory/items/NewArmorItem")]
public class ArmorItemScriptable : GenericItemScriptable
{
   [SerializeField]
   private List<GenericActionScriptable> actionEquipList;

   public override void ActionEquipAndUnequipListDispatch() {
      actionManagerEvent = new ActionManagerEvent();
      actionManagerEvent.DispatchAllGenericActionListEvent(actionEquipList);
   }
}
