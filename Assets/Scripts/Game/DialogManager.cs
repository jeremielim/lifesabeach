using UnityEngine;
using UnityEngine.UI;
using System;

public class DialogManager : MonoBehaviour
{
    [Serializable]
	public struct DialogInfo
    {
        public string key;
        public string text;
    }

	public DialogInfo[] dialogEntries;

    public Text dialogText;

	public String GetDialogEntry(string key) {
		foreach (DialogInfo info in dialogEntries )
		{
			if ( info.key == key )
			{
				return info.text;
			}
		}
		return "Newp";
	}

	public void SetState ( string key )
	{
		string text = GetDialogEntry ( key );
		dialogText.text = text;
	}
}
