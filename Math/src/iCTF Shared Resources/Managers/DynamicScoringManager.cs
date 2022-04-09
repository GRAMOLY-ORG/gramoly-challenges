using iCTF_Shared_Resources.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace iCTF_Shared_Resources.Managers
{
    public static class DynamicScoringManager
    {
        public static Expression<Func<int, int>> SolvePoints { get; } = 
            x => Math.Max(Convert.ToInt32((10 - 100) / 900f * Convert.ToInt32(Math.Pow(x, 2)) + 100), 10);

        public static int GetPointsFromSolvesCount(int solvesCount) => SolvePoints.Compile().Invoke(solvesCount);
    }
}
