﻿namespace OpusDotNet
{
    internal enum EControl
    {
        SetBitrate = 4002,
        //GetBitrate = 4003,

        SetVBR = 4006,
        GetVBR = 4007,

        SetComplexity = 4010,
        GetComplexity = 4011,

        SetInbandFEC = 4012,
        GetInbandFEC = 4013,

        SetPacketLossPerc = 4014,
        GetPacketLossPerc = 4015,

        SetDTX = 4016,
        GetDTX = 4017,

        SetForceChannels = 4022,
        GetForceChannels = 4023
    }
}
