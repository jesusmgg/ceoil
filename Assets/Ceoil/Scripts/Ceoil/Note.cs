namespace Ceoil
{
    public struct Note
    {
        public string Name { get; }
        public float Frequency { get; }

        Note(string name, float frequency)
        {
            Name = name;
            Frequency = frequency;
        }

        public override string ToString()
        {
            return Name;
        }

        public static Note C0 => new Note("C0", 16.35f);
        public static Note Ch0 => new Note("Ch0", 17.32f);
        public static Note Db0 => new Note("Db0", 17.32f);
        public static Note D0 => new Note("D0", 18.35f);
        public static Note Dh0 => new Note("Dh0", 19.45f);
        public static Note Eb0 => new Note("Eb0", 19.45f);
        public static Note E0 => new Note("E0", 20.6f);
        public static Note F0 => new Note("F0", 21.83f);
        public static Note Fh0 => new Note("Fh0", 23.12f);
        public static Note Gb0 => new Note("Gb0", 23.12f);
        public static Note G0 => new Note("G0", 24.5f);
        public static Note Gh0 => new Note("Gh0", 25.96f);
        public static Note Ab0 => new Note("Ab0", 25.96f);
        public static Note A0 => new Note("A0", 27.5f);
        public static Note Ah0 => new Note("Ah0", 29.14f);
        public static Note Bb0 => new Note("Bb0", 29.14f);
        public static Note B0 => new Note("B0", 30.87f);
        public static Note C1 => new Note("C1", 32.7f);
        public static Note Ch1 => new Note("Ch1", 34.65f);
        public static Note Db1 => new Note("Db1", 34.65f);
        public static Note D1 => new Note("D1", 36.71f);
        public static Note Dh1 => new Note("Dh1", 38.89f);
        public static Note Eb1 => new Note("Eb1", 38.89f);
        public static Note E1 => new Note("E1", 41.2f);
        public static Note F1 => new Note("F1", 43.65f);
        public static Note Fh1 => new Note("Fh1", 46.25f);
        public static Note Gb1 => new Note("Gb1", 46.25f);
        public static Note G1 => new Note("G1", 49.0f);
        public static Note Gh1 => new Note("Gh1", 51.91f);
        public static Note Ab1 => new Note("Ab1", 51.91f);
        public static Note A1 => new Note("A1", 55.0f);
        public static Note Ah1 => new Note("Ah1", 58.27f);
        public static Note Bb1 => new Note("Bb1", 58.27f);
        public static Note B1 => new Note("B1", 61.74f);
        public static Note C2 => new Note("C2", 65.41f);
        public static Note Ch2 => new Note("Ch2", 69.3f);
        public static Note Db2 => new Note("Db2", 69.3f);
        public static Note D2 => new Note("D2", 73.42f);
        public static Note Dh2 => new Note("Dh2", 77.78f);
        public static Note Eb2 => new Note("Eb2", 77.78f);
        public static Note E2 => new Note("E2", 82.41f);
        public static Note F2 => new Note("F2", 87.31f);
        public static Note Fh2 => new Note("Fh2", 92.5f);
        public static Note Gb2 => new Note("Gb2", 92.5f);
        public static Note G2 => new Note("G2", 98.0f);
        public static Note Gh2 => new Note("Gh2", 103.83f);
        public static Note Ab2 => new Note("Ab2", 103.83f);
        public static Note A2 => new Note("A2", 110.0f);
        public static Note Ah2 => new Note("Ah2", 116.54f);
        public static Note Bb2 => new Note("Bb2", 116.54f);
        public static Note B2 => new Note("B2", 123.47f);
        public static Note C3 => new Note("C3", 130.81f);
        public static Note Ch3 => new Note("Ch3", 138.59f);
        public static Note Db3 => new Note("Db3", 138.59f);
        public static Note D3 => new Note("D3", 146.83f);
        public static Note Dh3 => new Note("Dh3", 155.56f);
        public static Note Eb3 => new Note("Eb3", 155.56f);
        public static Note E3 => new Note("E3", 164.81f);
        public static Note F3 => new Note("F3", 174.61f);
        public static Note Fh3 => new Note("Fh3", 185.0f);
        public static Note Gb3 => new Note("Gb3", 185.0f);
        public static Note G3 => new Note("G3", 196.0f);
        public static Note Gh3 => new Note("Gh3", 207.65f);
        public static Note Ab3 => new Note("Ab3", 207.65f);
        public static Note A3 => new Note("A3", 220.0f);
        public static Note Ah3 => new Note("Ah3", 233.08f);
        public static Note Bb3 => new Note("Bb3", 233.08f);
        public static Note B3 => new Note("B3", 246.94f);
        public static Note C4 => new Note("C4", 261.63f);
        public static Note Ch4 => new Note("Ch4", 277.18f);
        public static Note Db4 => new Note("Db4", 277.18f);
        public static Note D4 => new Note("D4", 293.66f);
        public static Note Dh4 => new Note("Dh4", 311.13f);
        public static Note Eb4 => new Note("Eb4", 311.13f);
        public static Note E4 => new Note("E4", 329.63f);
        public static Note F4 => new Note("F4", 349.23f);
        public static Note Fh4 => new Note("Fh4", 369.99f);
        public static Note Gb4 => new Note("Gb4", 369.99f);
        public static Note G4 => new Note("G4", 392.0f);
        public static Note Gh4 => new Note("Gh4", 415.3f);
        public static Note Ab4 => new Note("Ab4", 415.3f);
        public static Note A4 => new Note("A4", 440.0f);
        public static Note Ah4 => new Note("Ah4", 466.16f);
        public static Note Bb4 => new Note("Bb4", 466.16f);
        public static Note B4 => new Note("B4", 493.88f);
        public static Note C5 => new Note("C5", 523.25f);
        public static Note Ch5 => new Note("Ch5", 554.37f);
        public static Note Db5 => new Note("Db5", 554.37f);
        public static Note D5 => new Note("D5", 587.33f);
        public static Note Dh5 => new Note("Dh5", 622.25f);
        public static Note Eb5 => new Note("Eb5", 622.25f);
        public static Note E5 => new Note("E5", 659.26f);
        public static Note F5 => new Note("F5", 698.46f);
        public static Note Fh5 => new Note("Fh5", 739.99f);
        public static Note Gb5 => new Note("Gb5", 739.99f);
        public static Note G5 => new Note("G5", 783.99f);
        public static Note Gh5 => new Note("Gh5", 830.61f);
        public static Note Ab5 => new Note("Ab5", 830.61f);
        public static Note A5 => new Note("A5", 880.0f);
        public static Note Ah5 => new Note("Ah5", 932.33f);
        public static Note Bb5 => new Note("Bb5", 932.33f);
        public static Note B5 => new Note("B5", 987.77f);
        public static Note C6 => new Note("C6", 1046.5f);
        public static Note Ch6 => new Note("Ch6", 1108.73f);
        public static Note Db6 => new Note("Db6", 1108.73f);
        public static Note D6 => new Note("D6", 1174.66f);
        public static Note Dh6 => new Note("Dh6", 1244.51f);
        public static Note Eb6 => new Note("Eb6", 1244.51f);
        public static Note E6 => new Note("E6", 1318.51f);
        public static Note F6 => new Note("F6", 1396.91f);
        public static Note Fh6 => new Note("Fh6", 1479.98f);
        public static Note Gb6 => new Note("Gb6", 1479.98f);
        public static Note G6 => new Note("G6", 1567.98f);
        public static Note Gh6 => new Note("Gh6", 1661.22f);
        public static Note Ab6 => new Note("Ab6", 1661.22f);
        public static Note A6 => new Note("A6", 1760.0f);
        public static Note Ah6 => new Note("Ah6", 1864.66f);
        public static Note Bb6 => new Note("Bb6", 1864.66f);
        public static Note B6 => new Note("B6", 1975.53f);
        public static Note C7 => new Note("C7", 2093.0f);
        public static Note Ch7 => new Note("Ch7", 2217.46f);
        public static Note Db7 => new Note("Db7", 2217.46f);
        public static Note D7 => new Note("D7", 2349.32f);
        public static Note Dh7 => new Note("Dh7", 2489.02f);
        public static Note Eb7 => new Note("Eb7", 2489.02f);
        public static Note E7 => new Note("E7", 2637.02f);
        public static Note F7 => new Note("F7", 2793.83f);
        public static Note Fh7 => new Note("Fh7", 2959.96f);
        public static Note Gb7 => new Note("Gb7", 2959.96f);
        public static Note G7 => new Note("G7", 3135.96f);
        public static Note Gh7 => new Note("Gh7", 3322.44f);
        public static Note Ab7 => new Note("Ab7", 3322.44f);
        public static Note A7 => new Note("A7", 3520.0f);
        public static Note Ah7 => new Note("Ah7", 3729.31f);
        public static Note Bb7 => new Note("Bb7", 3729.31f);
        public static Note B7 => new Note("B7", 3951.07f);
        public static Note C8 => new Note("C8", 4186.01f);
        public static Note Ch8 => new Note("Ch8", 4434.92f);
        public static Note Db8 => new Note("Db8", 4434.92f);
        public static Note D8 => new Note("D8", 4698.64f);
        public static Note Dh8 => new Note("Dh8", 4978.03f);
        public static Note Eb8 => new Note("Eb8", 4978.03f);
    }
}