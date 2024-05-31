using System;

static class AssemblyLine
{
    private const double _baseCarRate = 221.0;
    public static double SuccessRate(int speed) =>
        speed switch
        {
            0 => 0,
            < 5 => 1.0,
            < 9 => 0.9,
            9 => 0.8,
            10 => 0.77,
            _ => 0
        };

    public static double ProductionRatePerHour(int speed) =>
        speed * _baseCarRate * SuccessRate(speed);

    public static int WorkingItemsPerMinute(int speed) =>
        (int)(ProductionRatePerHour(speed) / 60);
}
