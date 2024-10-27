using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewChangeCharPropertiesAction", menuName = "Action/NewChangeCharPropertiesAction")]
public class ChangeCharPropertiesActionScriptable : GenericActionScriptable
{
   public override IEnumerator Execute() {
      yield return new WaitForSeconds(DelayToStart);

      // GameController -> ShowPopup
   }
}
