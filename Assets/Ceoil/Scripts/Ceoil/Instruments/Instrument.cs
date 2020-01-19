using System.Collections.Generic;

namespace Ceoil.Instruments
{
    public abstract class Instrument
    {
        public string name;
        
        static List<Instrument> instruments;

        protected Instrument()
        {
            if (instruments == null) { instruments = new List<Instrument>(); }
            instruments.Add(this);
        }
        
        public abstract void Play(Note note, int length=1000);
    }
}