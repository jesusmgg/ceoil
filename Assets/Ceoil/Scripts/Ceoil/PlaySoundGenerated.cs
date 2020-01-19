using Ceoil.Instruments;
using UnityEngine;

namespace Ceoil
{
    public class PlaySoundGenerated : MonoBehaviour
    {
        public int toneLength = 1000;

        bool isHoldingSpace = false;

        Instrument instrument;
        Instrument instrument2;

        void Start()
        {
            instrument = new TriangleWave();
            instrument2 = new SquareWave();
        }

        void Update()
        {
            isHoldingSpace = Input.GetKey(KeyCode.Space);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                instrument.Play(Note.B3, toneLength);
            }
            if (Input.GetKeyDown(KeyCode.LeftControl))
            {
                instrument2.Play(Note.B3, toneLength);
            }
        }
    }
}