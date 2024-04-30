using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UniRx;


public class ManagerAudio : Singleton<ManagerAudio>
{

  [Header("¿Àµð¿À ¹Í¼­")]
  [SerializeField] public AudioMixer AudioMixer;

  [Header("AudioSourceBGM")]
  [SerializeField] private AudioSource AudioSourceBGM;

  [Header("AudioSourceSFX")]
  [SerializeField] private AudioSource AudioSourceSFX;


  private Dictionary<AudioType, ReactiveProperty<float>> AudioVolume = new();


  protected CompositeDisposable disposables = new CompositeDisposable();



  private void OnEnable() => SubScribeVolume();

  private void OnDisable() => disposables.Clear();


  private void SubScribeVolume()
  {
    foreach (var audio in AudioVolume)
    {
      audio.Value.Subscribe(volume =>
      {
        AudioMixer.SetFloat(audio.Key.ToString(), Mathf.Log10(volume) * 20);

      }).AddTo(disposables);
    }
  }


}
