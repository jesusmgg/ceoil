using System;
using System.Threading;
using NAudio.Midi;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Ceoil
{
    public class PlaySoundGenerated : MonoBehaviour
    {
        public float gain = 0.4f;
        public int toneLength = 1000;
        public SignalGeneratorType signalType = SignalGeneratorType.Sin;

        bool isHoldingSpace = false;

        void Play(Note note, int length=1000)
        {
            Thread thread = new Thread(() =>
            {
                Debug.Log($"Playing {signalType} tone: {note} for {length}ms");
                
                SignalGenerator signal = new SignalGenerator()
                {
                    Gain = gain,
                    Frequency = note.Frequency,
                    Type = signalType,
                };

                using (WaveOutEvent wo = new WaveOutEvent())
                {
                    wo.Init(signal.Take(TimeSpan.FromMilliseconds(length)));
                    wo.Volume = 1.0f;
                    wo.Play();
                    while (wo.PlaybackState == PlaybackState.Playing)
                    {
                        Thread.Sleep(50);
                    }
                }
            });

            thread.Start();
        }

        void Update()
        {
            isHoldingSpace = Input.GetKey(KeyCode.Space);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Play(Note.B3, toneLength);
            }
        }
    }
}