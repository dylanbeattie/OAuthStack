using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using log4net;

namespace OAuthStack.DemoClient {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            log4net.Config.XmlConfigurator.Configure();
            var log = LogManager.GetLogger(typeof(Program));
            log.Warn("Warn!");
            log.Error("Error!");
            log.Debug("Debug");
            LogManager.GetLogger("DotNetOpenAuth").Debug("Testing Debug logging...");
            LogManager.GetLogger("DotNetOpenAuth").Warn("Testing Warn logging...");
            LogManager.GetLogger("DotNetOpenAuth").Info("Testing Info logging...");
            LogManager.GetLogger("DotNetOpenAuth").Error("Testing Error logging...");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
