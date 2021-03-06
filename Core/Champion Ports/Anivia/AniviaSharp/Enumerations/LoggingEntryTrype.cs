// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LoggingEntryTrype.cs" company="LeagueSharp">
//   Copyright legacy@joduska.me
// </copyright>
// <summary>
//   The entry type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using EloBuddy; 
 using LeagueSharp.Common; 
 namespace AniviaSharp.Enumerations
{
    /// <summary>
    ///     The entry type.
    /// </summary>
    internal enum LoggingEntryTrype
    {
        /// <summary>
        ///     A debug entry.
        /// </summary>
        Debug, 

        /// <summary>
        ///     An error entry.
        /// </summary>
        Error, 

        /// <summary>
        ///     A generic entry.
        /// </summary>
        Generic, 

        /// <summary>
        ///     An info entry.
        /// </summary>
        Info, 

        /// <summary>
        ///     A warning entry.
        /// </summary>
        Warning
    }
}