﻿namespace Dopamine.Common.Audio
{
    public class PlayerFactory : IPlayerFactory
    {
        public IPlayer Create(string path)
        {
            return CSCorePlayer.Instance;
        }
    }
}
