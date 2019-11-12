using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;

namespace SoL_client_service
{
    [RunInstaller(true)]
    public partial class Installer : System.Configuration.Install.Installer
    {
        public Installer()
        {
            InitializeComponent();
        }
        public override void Install(System.Collections.IDictionary stateSaver)
        {
            base.Install(stateSaver);
        }

        public override void Commit(IDictionary savedState)
        {
            base.Commit(savedState);
            try
            {
                AddConfigurationFileDetails();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка изменения файла конфигурации сервиса:\n" + e.Message);
                base.Rollback(savedState);
            }
        }

        public override void Rollback(IDictionary savedState)
        {
            base.Rollback(savedState);
        }

        public override void Uninstall(IDictionary savedState)
        {
            base.Uninstall(savedState);
        }

        private void AddConfigurationFileDetails()
        {
            try
            {
                string SERVER = Context.Parameters["SERVER"].ToString();
                string PORT = Context.Parameters["PORT"].ToString();
                MessageBox.Show(SERVER+":"+PORT);

                // Get the path to the executable file that is being installed on the target computer  
                string appConfigPath = Context.Parameters["assemblypath"] + ".config";

                // Write the path to the app.config file  
                XmlDocument doc = new XmlDocument();
                doc.Load(appConfigPath);

                XmlNode configuration = null;
                foreach (XmlNode node in doc.ChildNodes)
                    if (node.Name == "configuration")
                        configuration = node;

                if (configuration != null)
                {
                    // Get the ‘appSettings’ node  
                    XmlNode settingNode = null;
                    foreach (XmlNode node in configuration.ChildNodes)
                    {
                        if (node.Name == "appSettings")
                            settingNode = node;
                    }

                    if (settingNode != null)
                    {
                        //Reassign values in the config file  
                        foreach (XmlNode node in settingNode.ChildNodes)
                        {
                            if (node.Attributes == null)
                                continue;
                            XmlAttribute attribute = node.Attributes["value"];  
                            if (node.Attributes["key"] != null)
                            {
                                switch (node.Attributes["key"].Value)
                                {
                                    case "SERVER":
                                        attribute.Value = SERVER;
                                        break;
                                    case "PORT":
                                        attribute.Value = PORT;
                                        break;
                                }
                            }
                        }
                    }
                    doc.Save(appConfigPath);
                }
            }
            catch
            {
                throw;
            }
        }
    }
}