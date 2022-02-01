using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlucoseControl.Enums
{
    /// <summary>
    /// Possíveis condições antes da realização do teste de glicose
    /// </summary>a
    public enum MealType
    {
        /// <summary>
        /// Use for breakfast meals
        /// </summary>
        Breakfast = 1,

        /// <summary>
        /// Use for lunch meals
        /// </summary>
        Lunch = 2,

        /// <summary>
        /// Use for dinner meals
        /// </summary>
        Dinner = 3,

        /// <summary>
        /// Use for any snack meals
        /// </summary>
        Snack = 4
    }
}
