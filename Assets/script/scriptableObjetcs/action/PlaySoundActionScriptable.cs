using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewPlaySoundAction", menuName = "Action/NewPlaySoundAction")]
public class PlaySoundActionScriptable : GenericActionScriptable
{
   public override IEnumerator Execute() {
      yield return new WaitForSeconds(DelayToStart);

      // GameController -> ShowPopup
   }
}
