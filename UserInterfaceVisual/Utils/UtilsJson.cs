﻿using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using NUnit.Framework;

namespace ApiTest.Utils
{
    public static class UtilsJson
    {
        private static string pathJson = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "../../../")) + "Resources\\testData.json";
        public static string ReadJsonFile(string key)
        {
            TestContext.WriteLine(pathJson);
            try
            {
                dynamic file = JsonConvert.DeserializeObject(File.ReadAllText(pathJson));
                return Convert.ToString(file[$"{key}"]);
            }
            catch
            {
                return string.Empty;
            }
        }

    }
}
