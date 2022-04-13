using System;
using System.Numerics;

namespace XIVHunter.GoodMemory
{
    public record KillReport(DateTime DateTime, uint ZoneID, byte LineIndex, uint MonsterID, Vector2 Position);
}