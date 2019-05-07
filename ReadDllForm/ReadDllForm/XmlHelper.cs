using System;
using System.Collections.Generic;
using System.Linq;
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
    public void SaveProject(List<SimulinkModel> models, string fileName)
    {
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
            WriteXmlSignal(xWriter, insignal);
            xWriter.WriteEndElement();
        }
        foreach (var insignal in model.GetOutSignals())
        {
            xWriter.WriteStartElement("OutSignal");
            WriteXmlSignal(xWriter, insignal);
            xWriter.WriteEndElement();
        }
    }
    private static void WriteXmlSignal(XmlTextWriter xWriter, ISignal signal)
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
                if (reader.Name == "Model"&&modelName!="")
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
                            InSignal inSignal = new InSignal(port, signalName, path, hicore,channelName);
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
                            OutSignal outSignal = new OutSignal(port, signalName, path, hicore,channelName);
                            outSignals.Add(outSignal);
                        }

                }
            }

        }

        SimulinkModel mod = new SimulinkModel(path, hicore, inSignals, outSignals);
        models.Add(mod);
        return models;
    }
}

}
