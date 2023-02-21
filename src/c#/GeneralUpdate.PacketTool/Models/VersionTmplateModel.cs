﻿namespace GeneralUpdate.PacketTool.Models
{
    public class VersionTmplateModel
    {
        /// <summary>
        /// Update package release time.
        /// </summary>
        public long PubTime { get; set; }

        /// <summary>
        /// Update package name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Compare and verify with the downloaded update package.
        /// </summary>
        public string MD5 { get; set; }

        /// <summary>
        /// The version number.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Remote service url address.
        /// </summary>
        public string Url { get; set; }
    }
}
