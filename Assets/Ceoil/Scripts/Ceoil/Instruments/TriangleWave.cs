using System;
using System.Threading;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using UnityEngine;

namespace Ceoil.Instruments
{
    public class TriangleWave : Instrument
    {
        public TriangleWave()
        {
            name = "Triangle Wave";
        }
        
        public override void Play(Note note, int length=1000)
        {
            Thread thread = new Thread(() =>
            {
               Debug.Log($"Playing {name}: {note} for {length}ms");
                
                SignalGenerator signal = new SignalGenerator()
                {
                    Gain = 0.4f,
                    Frequency = note.Frequency,
                    Type = SignalGeneratorType.Triangle,
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
    }
}