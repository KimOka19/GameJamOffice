using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelReferences : Singleton<LevelReferences>
{ 
	[SerializeField]
	private Timer _timer = null;

	public Timer timer => _timer;
}
