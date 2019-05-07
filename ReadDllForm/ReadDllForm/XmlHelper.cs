using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using HiQ.HiMacs.WCF.Client;
using ReadDllForm.Properties;


namespace ReadDllForm
{
    class XmlHelper
    {
        private const string TargetFolder = "TargetFolder";
        private void CreateProjectFolder()
        {
           
            string path = $@"{Settings.Default[TargetFolder]}{"\\Projects"}";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

        }
        public void SaveProject(List<SimulinkModel> models, string fileName)
        {
            CreateProjectFolder();
            
            string xmlFileNamePath = $@"{Settings.Default[TargetFolder]}{"\\Projects\\"}{fileName}{".xml"}";
            XmlTextWriter xWriter = new XmlTextWriter(xmlFileNamePath, Encoding.UTF8);

            xWriter.WriteStartElement("Models");

            for (int i = 0; i < models.Count; i++)
            {
                xWriter.WriteStartElement("Model");
                WriteModel(xWriter, models[i]);
                xWriter.WriteEndElement();
            }

            xWriter.WriteEndElement();
            xWriter.Close();

        }
        public List<SimulinkModel> LoadProject(string fileName, HiCoreClient hicore)
        {
            List<SimulinkModel> models = new List<SimulinkModel>();

            XmlTextReader reader = new XmlTextReader(fileName);
            //reader.Read();
            string path = "";
            string modelName = "";
            List<ISignal> inSignals = new List<ISignal>();
            List<ISignal> outSignals = new List<ISignal>();

            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    if (reader.Name == "Model" && modelName != "")
                    {

                        SimulinkModel m = new SimulinkModel(path, hicore, inSignals, outSignals);
                        models.Add(m);
                        inSignals = new List<ISignal>();
                        outSignals = new List<ISignal>();
                    }
                    if (reader.Name == "ModelName")
                    {
                        modelName = reader.ReadString();
                    }
                    if (reader.Name == "Path")
                    {
                        path = reader.ReadString();
                    }
                    if (reader.IsStartElement())
                    {
                        if (reader.Name == "InSignal")
                        {
                            reader.Read();
                            string signalName = "";
                            if (reader.Name == "Name")
                            {
                                signalName = reader.ReadString();
                            }

                            reader.Read();
                            int port = -1;
                            if (reader.Name == "Port")
                            {
                                port = Convert.ToInt32(reader.ReadString());
                            }
                            reader.Read();
                            string channelName = "";
                            if (reader.Name == "ChannelName")
                            {
                                channelName = reader.ReadString();
                            }
                            InSignal inSignal = new InSignal(port, signalName, path, hicore, channelName);
                            inSignals.Add(inSignal);


                        }
                        else if (reader.Name == "OutSignal")
                        {
                            string signalName = "";
                            int port = 0;
                            reader.Read();
                            if (reader.Name == "Name")
                            {
                                signalName = reader.ReadString();
                            }
                            reader.Read();
                            if (reader.Name == "Port")
                            {
                                port = Convert.ToInt32(reader.ReadString());
                            }
                            reader.Read();
                            string channelName = "";
                            if (reader.Name == "ChannelName")
                            {
                                channelName = reader.ReadString();
                            }
                            OutSignal outSignal = new OutSignal(port, signalName, path, hicore, channelName);
                            outSignals.Add(outSignal);
                        }

                    }
                }

            }

            SimulinkModel mod = new SimulinkModel(path, hicore, inSignals, outSignals);
            models.Add(mod);
            return models;
        }

        private static void WriteModel(XmlTextWriter xWriter, SimulinkModel model)
        {
            xWriter.WriteStartElement("ModelName");
            xWriter.WriteString(model.GetName());
            xWriter.WriteEndElement();

            xWriter.WriteStartElement("Path");
            xWriter.WriteString(model.GetPath());
            xWriter.WriteEndElement();
            foreach (var insignal in model.GetInSignals())
            {
                xWriter.WriteStartElement("InSignal");
                WriteSignal(xWriter, insignal);
                xWriter.WriteEndElement();
            }
            foreach (var insignal in model.GetOutSignals())
            {
                xWriter.WriteStartElement("OutSignal");
                WriteSignal(xWriter, insignal);
                xWriter.WriteEndElement();
            }
        }
        private static void WriteSignal(XmlTextWriter xWriter, ISignal signal)
        {
            xWriter.WriteStartElement("Name");
            xWriter.WriteString(signal.GetSignalName());
            xWriter.WriteEndElement();
            xWriter.WriteStartElement("Port");
            xWriter.WriteString(signal.GetPortNumber().ToString());
            xWriter.WriteEndElement();
            xWriter.WriteStartElement("ChannelName");
            xWriter.WriteString(signal.GetChannelName());
            xWriter.WriteEndElement();
        }

       
        public List<ISignal> ReadXmlSimulinkModel(string _directoryPath,string _path,HiCoreClient _hiCore)
        {
            List<ISignal> signals=new List<ISignal>();
            
            XmlTextReader reader = new XmlTextReader(_directoryPath + "\\modelXML.xml");
            reader.Read();
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    if (reader.Name == "InSignal")
                    {
                        reader.Read();
                        string name = "";
                        if (reader.Name == "Name")
                        {
                            name = reader.ReadString();
                        }

                        reader.Read();
                        int port = -1;
                        if (reader.Name == "Port")
                        {
                            port = Convert.ToInt32(reader.ReadString());
                        }
                        InSignal inSignal = new InSignal(port, name, _path, _hiCore);
                        //inSignal.SetSignal(5);
                        signals.Add(inSignal);


                    }
                    else if (reader.Name == "OutSignal")
                    {
                        string Name = "";
                        int port = 0;
                        reader.Read();
                        if (reader.Name == "Name")
                        {
                            Name = reader.ReadString();
                        }
                        reader.Read();
                        if (reader.Name == "Port")
                        {
                            port = Convert.ToInt32(reader.ReadString());
                        }
                        OutSignal outSignal = new OutSignal(port, Name, _path, _hiCore);
                        signals.Add(outSignal);
                    }
                }
            }
            return signals;
        }

        public void WriteModelXml(string fileName,List<string>Inputs,List<string>Outputs)
        {
            XmlTextWriter xWriter = new XmlTextWriter(fileName, Encoding.UTF8);
            xWriter.WriteStartElement("InSignal");

            xWriter.WriteStartElement("NumInSignals");
            xWriter.WriteString(Inputs.Count.ToString());
            xWriter.WriteEndElement();

            xWriter.WriteStartElement("NumOutSignals");
            xWriter.WriteString(Outputs.Count.ToString());
            xWriter.WriteEndElement();

            for (int i = 0; i < Inputs.Count; i++)
            {
                xWriter.WriteStartElement("InSignal");
                WriteSignalXml(xWriter, i, Inputs[i]);
                xWriter.WriteEndElement();
            }

            for (int i = 0; i < Outputs.Count; i++)
            {
                xWriter.WriteStartElement("OutSignal");
                WriteSignalXml(xWriter, i, Outputs[i]);
                xWriter.WriteEndElement();
            }
            xWriter.WriteEndElement();


            xWriter.Close();
        }
        private static void WriteSignalXml(XmlTextWriter xWriter, int i, string name)
        {
            xWriter.WriteStartElement("Name");
            xWriter.WriteString(name);
            xWriter.WriteEndElement();
            xWriter.WriteStartElement("Port");
            xWriter.WriteString(i.ToString());
            xWriter.WriteEndElement();
        }

    }

}
