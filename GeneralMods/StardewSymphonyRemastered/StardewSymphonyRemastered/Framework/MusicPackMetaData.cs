﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StardewSymphonyRemastered.Framework
{
    /// <summary>
    /// Holds information regarding information relating to music packs such as name, description, author, and version.
    /// </summary>
    public class MusicPackMetaData
    {

        public string name;
        public string author;
        public string description;
        public string versionInfo;

        /// <summary>
        /// Constrctor
        /// </summary>
        /// <param name="Name">The name to be displayed for the music pack.</param>
        /// <param name="Author">The author who compiled ths music pack.</param>
        /// <param name="Description">The description of</param>
        /// <param name="VersionInfo"></param>
        public MusicPackMetaData(string Name,string Author,string Description,string VersionInfo)
        {
            this.name = Name;
            this.author = Author;
            this.description = Description;
            this.versionInfo = VersionInfo;
        }
        /// <summary>
        /// Blank Constructor
        /// </summary>
        public MusicPackMetaData()
        {

        }

        /// <summary>
        /// Loads the music pack information from a json file.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static MusicPackMetaData readFromJson(string path)
        {
            return StardewSymphony.ModHelper.ReadJsonFile<MusicPackMetaData>(path);
        }

        /// <summary>
        /// Writes the music pack information to a json file.
        /// </summary>
        /// <param name="path"></param>
        public void writeToJson(string path)
        {
          StardewSymphony.ModHelper.WriteJsonFile<MusicPackMetaData>(path,this);
        }


    }
}
