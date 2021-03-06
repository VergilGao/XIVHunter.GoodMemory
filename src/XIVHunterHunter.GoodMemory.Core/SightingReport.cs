using System;
using System.Numerics;

namespace XIVHunter.GoodMemory
{
    /// <summary>
    /// 目击报告
    /// </summary>
    public record SightingReport(DateTime DateTime, uint ZoneID, byte LineIndex, uint MonsterID, Vector2 Position);
}