namespace GBEvaluationLibrary
{/// <summary>
/// This enum has two values used to chose appropriate database model
/// </summary>
    public enum DatabaseType
    {
        Sql,
        TextFile
    }
    /// <summary>
    /// This static class has mixed datatype constant value. These are according to the physical nature of current project.
    /// </summary>
    public static class DataValidity
    {
        public const int userIDlength = 4;
        public const double maxGBEnergy = 0;
        public const double minSoliFactor = 0;
        public const double maxSoliFactor = 1;
        public const double maxThermalGrad = 1000;
    }
}
