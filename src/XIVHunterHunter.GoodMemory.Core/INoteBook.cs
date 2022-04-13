using System.Numerics;

namespace XIVHunter.GoodMemory
{
    /// <summary>
    /// 记事本
    /// </summary>
    public interface INoteBook
    {
        /// <summary>
        /// 记录一条怪物击杀报告
        /// </summary>
        /// <param name="report">怪物击杀报告</param>
        void Record(KillReport report);

        /// <summary>
        /// 记录一条怪物目击报告
        /// </summary>
        /// <param name="report">怪物目击报告</param>
        void Record(SightingReport report);

        /// <summary>
        /// 获取怪物的所有重生点
        /// </summary>
        /// <param name="MonsterID">怪物ID</param>
        /// <returns>重生点</returns>
        (uint MapID, Vector2[] Positions) GetAllRebirthPositions(uint MonsterID);

        /// <summary>
        /// 预测怪物的重生点
        /// </summary>
        /// <param name="MonsterID">怪物ID</param>
        /// <returns>可能的重生点</returns>
        (uint MapID, Vector2[] Positions) PredictRebirthPositions(uint MonsterID);
    }
}