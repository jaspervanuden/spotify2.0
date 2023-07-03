﻿namespace spotify
{
    public interface iPlayable
    {
        public void Play();
        public void Pause();
        public void Next();
        public void Stop();
        public int Length
        {
            get;set;
        }
    }
}