using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewPlaySoundAction", menuName = "Action/NewPlaySoundAction")]
public class PlaySoundActionScriptable : GenericActionScriptable
{
   [SerializeField]
   private AudioClip audioFile;

   public override IEnumerator Execute() {

      yield return new WaitForSeconds(DelayToStart);

      if(audioFile != null) {
         //GameController => Funcao()
      } else {
         Debug.LogWarning("There is no audio file in this PlaySound Scriptable Object");
      }
   }
}
