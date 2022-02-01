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
    public enum PhysicalActivityType
    {
        /// <summary>
        /// Use for walking trainments
        /// </summary>
        Walking = 1,

        /// <summary>
        /// Use for running trainments
        /// </summary>
        Running = 2,

        /// <summary>
        /// Use when the training to toggles between walking and running
        /// </summary>
        Cardio = 3,

        /// <summary>
        /// Use for karting trainments
        /// </summary>
        Karting = 4
    }
}
