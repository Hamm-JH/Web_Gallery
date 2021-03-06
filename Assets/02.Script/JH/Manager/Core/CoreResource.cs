using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Management.Core
{
	/// <summary>
	/// 시스템 관리자 관리용 고유 변수
	/// </summary>
	[System.Serializable]
	public class CoreResource
	{
		public Person.Character character;

		/// <summary>
		/// 관리자 Fade 컨트롤 animator
		/// </summary>
		public Animator animator;

		/// <summary>
		/// 주로 사용하는 카메라 변수
		/// </summary>
		public Camera mainCamera;

		/// <summary>
		/// 사용자 화면 영역을 확인하기 위한 오버레이 모드 캔버스
		/// </summary>
		public Canvas rootCanvas;

		/// <summary>
		/// 배경음으로 사용가능한 오디오
		/// </summary>
		public AudioSource mainAudio;

		/// <summary>
		/// Fade In, Fade Out을 구현할 타이틀 이미지 패널
		/// </summary>
		public Image curtain;

		/// <summary>
		/// 현재 씬을 나타내는 열거변수
		/// </summary>
		public Def.SceneName currentScene;

		/// <summary>
		/// 프로그레스바
		/// </summary>
		public Michsky.UI.ModernUIPack.ProgressBar progressbar;
	}
}
