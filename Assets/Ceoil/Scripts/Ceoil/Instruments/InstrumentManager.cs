using System;
using System.Collections.Generic;
using UnityEngine;

namespace Ceoil.Instruments
{
    public class InstrumentManager : MonoBehaviour
    {
        public List<Instrument> instruments;
        
        void Start()
        {
            instruments = new List<Instrument>
            {
                new SquareWave(),
                new TriangleWave()
            };
        }
    }
}