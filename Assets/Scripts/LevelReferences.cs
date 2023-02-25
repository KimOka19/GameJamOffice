using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelReferences : Singleton<LevelReferences>
{ 
	[SerializeField]
	private Timer _timer = null;

	[SerializeField]
	private PlayerScoring _playerScoring = null;

	[SerializeField]
	private TaskManager _taskManager = null;

	[SerializeField]
	private PlayerInteraction _playerInteraction = null;


	public Timer timer => _timer;
	public PlayerScoring playerScoring => _playerScoring;

	public TaskManager taskManager => _taskManager;

	public PlayerInteraction playerInteraction => _playerInteraction;
}
