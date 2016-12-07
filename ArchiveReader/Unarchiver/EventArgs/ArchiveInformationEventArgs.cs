﻿namespace Akeeba.Unarchiver.EventArgs
{
    /// <summary>
    /// Arguments for the archiveInformation event
    /// </summary>
    public class ArchiveInformationEventArgs: System.EventArgs
    {
        public ArchiveInformationEventArgs(ArchiveInformation a)
        {
            ArchiveInformation = a;
        }

        public ArchiveInformation ArchiveInformation { get; set; }
    }
}
