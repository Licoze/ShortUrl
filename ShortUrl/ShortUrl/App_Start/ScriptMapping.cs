using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
namespace ShortUrl
{
    public static class ScriptMapping
    {
       public static void AddDefinitions()
        {
            ScriptManager.ScriptResourceMapping.AddDefinition(
                "Jquery",
                new ScriptResourceDefinition
                {
                    Path = "~/Scripts/jquery-3.1.1.min.js",
                    DebugPath = "~/Scripts/jquery-3.1.1.js"
                });
            ScriptManager.ScriptResourceMapping.AddDefinition(
                "Bootstrap",
                new ScriptResourceDefinition
                {
                    Path = "~/Scripts/bootstrap.min.js",
                    DebugPath = "~/Scripts/bootstrap.js"
                });
            ScriptManager.ScriptResourceMapping.AddDefinition(
                "General",
                new ScriptResourceDefinition {
                   Path = "~/Scripts/general.js",
                });
            ScriptManager.ScriptResourceMapping.AddDefinition(
                "JqueryValid",
                new ScriptResourceDefinition
                {
                    Path = "~/Scripts/jquery.validate.min.js",
                    DebugPath = "~/Scripts/jquery.validate.js"
                });
        }
    }
}