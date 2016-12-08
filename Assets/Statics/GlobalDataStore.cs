using AK;

public static class GlobalDataStore
{
    private static AK.ExpressionSolver solver;
    private static AK.Expression zFn;

    public static AK.ExpressionSolver getSolver()
    {
        return solver;
    }

    public static void setSolver(AK.ExpressionSolver _solver)
    {
        solver = _solver;
    }

    public static AK.Expression getZFn()
    {
        return zFn;
    }

    public static void setZFn(AK.Expression _zFn)
    {
        zFn = _zFn;
    }
}