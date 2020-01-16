using System;
using System.Threading;
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

        void Play(float frequency = 440.0f, int length=1000)
        {
            Thread thread = new Thread(() =>
            {
                SignalGenerator signal = new SignalGenerator()
                {
                    Gain = gain,
                    Frequency = frequency,
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
                Play(Random.Range(300.0f, 500.0f), toneLength);
            }
        }
    }
}