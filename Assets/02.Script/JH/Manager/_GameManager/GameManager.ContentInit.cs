using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Management
{
    using Core;

    public partial class GameManager : Manager
    {
        private void ContentInit(CoreResource core, ContentManager _content, EnvSetting env)
		{
            //_content._Data.Character = core.character;
            core.character = _content._Data.Character;
			Camera cam = core.mainCamera;

            // 캐릭터 초기화
            core.character.OnInit(cam, _content._Data.CharacterTransform, env.MoveSpeed);

            // 오디오 세팅
            SetAudio(core.mainAudio, env.BaseAudio);

			// 캔버스 초기화
			foreach (var _canvas in _content._Data.CanvasList)
			{
                _canvas.worldCamera = cam;
			}
		}

        private void SetAudio(AudioSource _source, AudioClip _clip)
		{
            _source.clip = _clip;
            _source.Play();
		}
    }
}
