﻿using System.IO;
using System.Reflection;

namespace Microsoft.DotNet.Interactive.Journey.Tests.Utilities
{
    public class PathUtilities
    {
        public static string GetNotebookPath(string notebookName)
        {
            var relativeFilePath = $"Notebooks/{notebookName}";
            var prefix = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return Path.GetFullPath(Path.Combine(prefix, relativeFilePath));
        }
    }
}
