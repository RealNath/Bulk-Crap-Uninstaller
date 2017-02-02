/*
    Copyright (c) 2017 Marcin Szeniak (https://github.com/Klocman/)
    Apache License Version 2.0
*/

using System.Threading;

namespace UninstallTools.Factory.InfoAdders
{
    public interface IMissingInfoAdder
    {
        /// <summary>
        /// Try to add missing information to the target entry.
        /// </summary>
        void AddMissingInformation(ApplicationUninstallerEntry target);

        /// <summary>
        /// Names of values this InfoAdder requires to work.
        /// </summary>
        string[] RequiredValueNames { get; }

        /// <summary>
        /// True if all Required Values need to be defined.
        /// False if only one needs to be defined.
        /// </summary>
        bool RequiresAllValues { get; }

        /// <summary>
        /// Names of values this InfoAdder can fill in.
        /// </summary>
        string[] ProducedValueNames { get; }

        /// <summary>
        /// Higher priority InfoAdders are executed first.
        /// </summary>
        ThreadPriority Priority { get; }
    }
}