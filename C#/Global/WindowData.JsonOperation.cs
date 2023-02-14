
using Global.Mode;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows;

namespace Global
{

    public class ObjectiveConfig 
    {

        /// <summary>
        /// 序号
        /// </summary>
        public int No { get; set; }
        /// <summary>
        /// 型号
        /// </summary>
        public string Brand { get; set; }
        /// <summary>
        /// 倍数
        /// </summary>
        public int Magnitude { get; set; }

        /// <summary>
        /// 标示
        /// </summary>
        public string ObjectiveKey { get; set; }


        /// <summary>
        /// 放大倍数
        /// </summary>
        public double Multiple { get; set; }

        /// <summary>
        /// 工作距离
        /// </summary>
        public string WorkingDistance { get; set; }

        /// <summary>
        /// 数值孔径
        /// </summary>
        [JsonPropertyName("N.A")]
        public double NA { get; set; }

        /// <summary>
        /// 消色差
        /// </summary>
        public bool Achromatic { get; set; }



    }

   


    public partial class WindowData
    {
        public List<int> ObjGainListBF = new List<int>() { 0,0,0,0};
        public List<int> ObjGainListDF = new List<int>() { 0, 0, 0, 0 };
        public List<int> ObjGainListRI = new List<int>() { 0, 0, 0, 0 };
        public List<int> ObjGainListDP = new List<int>() { 0, 0, 0, 0 };
        public List<int> ObjGainListQP = new List<int>() { 0, 0, 0, 0 };
        public List<int> ObjGainListPC = new List<int>() { 0, 0, 0, 0 };
        public List<int> ObjExposureListBF = new List<int>() { 0, 0, 0, 0 };
        public List<int> ObjExposureListDF = new List<int>() { 0, 0, 0, 0 };
        public List<int> ObjExposureListRI = new List<int>() { 0, 0, 0, 0 };
        public List<int> ObjExposureListDP = new List<int>() { 0, 0, 0, 0 };
        public List<int> ObjExposureListQP = new List<int>() { 0, 0, 0, 0 };
        public List<int> ObjExposureListPC = new List<int>() { 0, 0, 0, 0 };
        public List<int> ObjLEDListBF = new List<int>() { 0, 0, 0, 0 };
        public List<int> ObjLEDListDF = new List<int>() { 0, 0, 0, 0 };
        public List<int> ObjLEDListRI = new List<int>() { 0, 0, 0, 0 };
        public List<int> ObjXStepList = new List<int>() { 0, 0, 0, 0 };
        public List<int> ObjYStepList = new List<int>() { 0, 0, 0, 0 };
        public List<int> ObjZStepList = new List<int>() { 0, 0, 0, 0 };
        public List<string> ObjList = new List<string>() { };
        public List<ObjectiveConfig> ObjParaList = new List<ObjectiveConfig> { };
        public ObjectiveConfig CurrentObjective = new ObjectiveConfig();
        // public List<ObjectiveConfig> ObjParList = new List<ObjectiveConfig>() { };



        public string DirectoryPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Grid\\Default\\default.gprj";
        public void SaveCustomConfig(string ConfigFullName)
        {
            string jsonString = File.ReadAllText(ConfigFullName);
            JsonObject lamdbda = (JsonObject)JsonNode.Parse(jsonString);
            lamdbda!["config-imaging-mode"]!["bright-field"]!["CameraSetting"]!["gain_"] = new JsonObject { ["10px"] = 60, ["20xs"] = 20 };
            lamdbda!["config-imaging-mode"]!["bright-field"]!["CameraSetting"]!["exposure_"] = new JsonObject { ["10px"] = 36, ["20xs"] = 18 };

            File.WriteAllText(ConfigFullName, lamdbda.ToJsonString());
        }
        public void SaveCustomConfig(string ConfigFullName, List<string> objList)
        {
            GenerateGainList();
            GenerateExposureList();
            GenerateLedList();
            GenerateStepList();

            string jsonString = File.ReadAllText(ConfigFullName);
            JsonObject lamdbda = (JsonObject)JsonNode.Parse(jsonString);
            JsonObject gainJsonBF = new JsonObject();
            JsonObject gainJsonDF = new JsonObject();
            JsonObject gainJsonRI = new JsonObject();
            JsonObject gainJsonDP = new JsonObject();
            JsonObject gainJsonQP = new JsonObject();
            JsonObject gainJsonPC = new JsonObject();

            JsonObject exposureJsonBF = new JsonObject();
            JsonObject exposureJsonDF = new JsonObject();
            JsonObject exposureJsonRI = new JsonObject();
            JsonObject exposureJsonDP = new JsonObject();
            JsonObject exposureJsonQP = new JsonObject();
            JsonObject exposureJsonPC = new JsonObject();

            JsonObject ledJsonBF = new JsonObject();
            JsonObject ledJsonDF = new JsonObject();
            JsonObject ledJsonRI = new JsonObject();

            JsonObject StepXJson = new JsonObject();
            JsonObject StepYJson = new JsonObject();
            JsonObject StepZJson = new JsonObject();


            for (int i = 0; i < objList.Count; i++)
            {
                gainJsonBF.Add(objList[i], ObjGainListBF[i]);
                gainJsonDF.Add(objList[i], ObjGainListDF[i]);
                gainJsonRI.Add(objList[i], ObjGainListRI[i]);
                gainJsonDP.Add(objList[i], ObjGainListDP[i]);
                gainJsonQP.Add(objList[i], ObjGainListQP[i]);
                gainJsonPC.Add(objList[i], ObjGainListPC[i]);

                exposureJsonBF.Add(objList[i], ObjExposureListBF[i]);
                exposureJsonDF.Add(objList[i], ObjExposureListDF[i]);
                exposureJsonRI.Add(objList[i], ObjExposureListRI[i]);
                exposureJsonDP.Add(objList[i], ObjExposureListDP[i]);
                exposureJsonQP.Add(objList[i], ObjExposureListQP[i]);
                exposureJsonPC.Add(objList[i], ObjExposureListPC[i]);

                ledJsonBF.Add(objList[i], ObjLEDListBF[i]);
                ledJsonDF.Add(objList[i], ObjLEDListDF[i]);
                ledJsonRI.Add(objList[i], ObjLEDListRI[i]);
                StepXJson.Add(objList[i], ObjXStepList[i]);
                StepYJson.Add(objList[i], ObjYStepList[i]);
                StepZJson.Add(objList[i], ObjZStepList[i]);

            }

            lamdbda!["config-imaging-mode"]!["bright-field"]!["CameraSetting"]!["gain_"] = gainJsonBF;
            lamdbda!["config-imaging-mode"]!["dark-field"]!["CameraSetting"]!["gain_"] = gainJsonDF;
            lamdbda!["config-imaging-mode"]!["rheinberg"]!["CameraSetting"]!["gain_"] = gainJsonRI;
            lamdbda!["config-imaging-mode"]!["relief-contrast"]!["CameraSetting"]!["gain_"] = gainJsonDP;
            lamdbda!["config-imaging-mode"]!["phase-contrast"]!["CameraSetting"]!["gain_"] = gainJsonQP;
            lamdbda!["config-imaging-mode"]!["quantitative-phase"]!["CameraSetting"]!["gain_"] = gainJsonPC;

            lamdbda!["config-imaging-mode"]!["bright-field"]!["CameraSetting"]!["exposure_"] = exposureJsonBF;
            lamdbda!["config-imaging-mode"]!["dark-field"]!["CameraSetting"]!["exposure_"] = exposureJsonDF;
            lamdbda!["config-imaging-mode"]!["rheinberg"]!["CameraSetting"]!["exposure_"] = exposureJsonRI;
            lamdbda!["config-imaging-mode"]!["relief-contrast"]!["CameraSetting"]!["exposure_"] = exposureJsonDP;
            lamdbda!["config-imaging-mode"]!["phase-contrast"]!["CameraSetting"]!["exposure_"] = exposureJsonQP;
            lamdbda!["config-imaging-mode"]!["quantitative-phase"]!["CameraSetting"]!["exposure_"] = exposureJsonPC;

            lamdbda!["config-imaging-mode"]!["bright-field"]!["led-diameter_"] = ledJsonBF;
            lamdbda!["config-imaging-mode"]!["dark-field"]!["led-diameter-inner_"] = ledJsonDF;
            lamdbda!["config-imaging-mode"]!["rheinberg"]!["led-diameter-inner_"] = ledJsonRI;

            lamdbda!["config-stage"]!["moving-step"]!["x-step_"]= StepXJson;
            lamdbda!["config-stage"]!["moving-step"]!["y-step_"] = StepYJson;
            lamdbda!["config-stage"]!["moving-step"]!["z-step_"] = StepZJson;

            File.WriteAllText(ConfigFullName, lamdbda.ToJsonString());
        }

        public void ReadCustomConfig(SolutionConfig solutionConfig, string json)
        {
            JsonObject lamdbda = (JsonObject)JsonNode.Parse(json);
            solutionConfig.OperatingMode.BrightField.CameraSetting.MultiObjGain.Gain1 = lamdbda!["config-imaging-mode"]!["bright-field"]!["CameraSetting"]!["gain_"]!["10px"]!.GetValue<int>();
        }
        public void ReadDefaultConfig(string path) 
        {  
            string result = File.ReadAllText(path);
            JsonObject defaultConfig = (JsonObject)JsonNode.Parse(result);
            if (defaultConfig!["multi-objectives"]  != null)
            {
                SolutionConfig.IsMultiObj.Enable = defaultConfig!["multi-objectives"].GetValue<bool>();
            }
            
            JsonNode document = JsonNode.Parse(result)!;
            JsonNode root = document.Root;
            if (root["lambda-manager"]!=null)
            {
                if (root["lambda-manager"]!["objective-keys"] != null)
                {
                    JsonArray objectArray = root["lambda-manager"]!["objective-keys"]!.AsArray();
                    if (objectArray.Count > 0)
                    {
                        ObjList.Clear();
                        for (int i = 0; i < objectArray.Count; i++)
                        {
                            if (objectArray[i] != null && objectArray[i].ToString().Length > 0)
                            {
                                ObjList.Add(objectArray[i].ToString());
                            }
                        }
                    }
                }
            }

            ReadDefaultConfigPreference(path);
            ReadObjectivePar(path);
        }
        public void WriteDefaultConfig(string path)
        {
            WriteDefaultConfigPreference(path);
            WriteCurrentOjective(path);
        }




        private void WriteCurrentOjective(string path)
        {

            string result = File.ReadAllText(path);
            JsonObject defaultConfig = (JsonObject)JsonNode.Parse(result);

            if (defaultConfig["firmware"] != null)
            {

                if (defaultConfig["firmware"]!["objective"] != null)
                {
                    int index = WindowData.GetInstance().SolutionConfig.CurrentObjective;
                    int magnitude = ObjParaList[index].Magnitude;
                   defaultConfig["firmware"]!["objective"]!["current-magnitude"] = magnitude;

                }
               
            }
            File.WriteAllText(path, defaultConfig.ToJsonString());



        }
            public void ReadDefaultConfigPreference(string path)
        {
            string result = File.ReadAllText(path);
            JsonObject defaultConfig = (JsonObject)JsonNode.Parse(result);

            if (defaultConfig["preference"] != null)
            {
                
                if (defaultConfig["preference"]!["display-resolution"] != null)
                {
                    setting.otherMode.SnapMode = defaultConfig!["preference"]!["action-after-snapshot"].GetValue<int>();
                    
                }
                if (defaultConfig["preference"]!["annotation-target"] != null)
                {

                    setting.otherMode.InkMode = defaultConfig!["preference"]!["annotation-target"].GetValue<int>();

                }
            }

        }



        //private void ReadObjParList(string path)
        //{

        //    string result = File.ReadAllText(path);
        //    JsonObject defaultConfig = (JsonObject)JsonNode.Parse(result);
        //    JsonNode forecastNode = JsonNode.Parse(result)!;
        //    if (defaultConfig["firmware"] != null)
        //    {
        //        if (defaultConfig["firmware"]!["objective"] != null)
        //        {
        //            JsonObject objective = forecastNode!["firmware"]!["objective"]!.AsObject();
        //            using var stream = new MemoryStream();
        //            using var writer = new Utf8JsonWriter(stream);
        //            objective.WriteTo(writer);
        //            writer.Flush();
        //            try
        //            {
        //                OBJParameter? objPar =
        //                JsonSerializer.Deserialize<OBJParameter>(stream.ToArray());

        //            }
        //            catch
        //            {

        //            }

        //        }
        //    }


        //}

        private void ReadObjectivePar(string path)
        {
        
            string result = File.ReadAllText(path);
            JsonObject defaultConfig = (JsonObject)JsonNode.Parse(result);
            if (defaultConfig["firmware"]!["objective"] is JsonObject objective)
            {
               // var ObjectiveConfigs = SoftwareConfig.HardwareConfig.ObjectiveConfigs;

                try
                {
                    
                    if ((bool)defaultConfig["multi-objectives"]! == true)
                    {
                        List<string> ObjectiveList = new List<string>() { };

                        JsonArray jsonArray = (JsonArray)defaultConfig["lambda-manager"]!["objective-keys"];
                        foreach (var item in jsonArray!)
                        {
                            ObjectiveList.Add(item!.ToString());
                        }

                       
                        List<ObjectiveConfig> AvailableObjectives = new List<ObjectiveConfig> { };
                        foreach (var item in ObjectiveList)
                        {
                            ObjectiveConfig objectiveConfig = new ObjectiveConfig();
                            objectiveConfig.ObjectiveKey = item.ToString();
                            objectiveConfig.Magnitude = (int)objective["magnitude"]![item]!;
                            objectiveConfig.NA = (double)objective["NA"]![item]!;
                            objectiveConfig.Achromatic = (bool)objective["achromatic"]![item]!;
                            objectiveConfig.Multiple = (double)objective["multiple"]![item]!;
                            objectiveConfig.WorkingDistance = objective["WD"]![item]?.ToString();
                            AvailableObjectives.Add(objectiveConfig);
                        }
                        ObjParaList = AvailableObjectives;
                        foreach (var item in AvailableObjectives)
                        {
                            if (item.Magnitude == (int)objective["current-magnitude"]!)
                            {
                                CurrentObjective = item;
                                break;
                            }
                        }

                    }
                    else
                    {
                        ObjectiveConfig objectiveConfig = new ObjectiveConfig();
                        objectiveConfig.ObjectiveKey = ((JsonArray)defaultConfig["lambda-manager"]!["objective-keys"]!)[0]!.ToString();
                        objectiveConfig.Magnitude = (int)objective["magnitude"]!;
                        objectiveConfig.NA = (double)objective["NA"]!;
                        objectiveConfig.Achromatic = (bool)objective["achromatic"]!;
                        objectiveConfig.Multiple = (double)objective["multiple"]!;
                        objectiveConfig.WorkingDistance = objective["WD"]?.ToString();
                        ObjParaList.Clear();
                        ObjParaList.Add(objectiveConfig);
                    }
                }
                catch
                {

                }
            }
        }










        public void WriteDefaultConfigPreference(string path)
        {
            string result = File.ReadAllText(path);
            JsonObject defaultConfig = (JsonObject)JsonNode.Parse(result);

            if (defaultConfig["preference"] != null)
            {
                
                if (defaultConfig["preference"]!["display-resolution"] != null)
                {
                    defaultConfig["preference"]["action-after-snapshot"] = setting.otherMode.SnapMode;

                }
                if (defaultConfig["preference"]!["annotation-target"] != null)
                {
                    defaultConfig["preference"]["annotation-target"] = setting.otherMode.InkMode;
                   

                }
            }
            File.WriteAllText(path, defaultConfig.ToJsonString());
        }


        public void ReadCustomConfig(string jsonString, List<string> objList)
        {
            //string jsonString = File.ReadAllText(ConfigFullName);
            JsonObject lamdbda = (JsonObject)JsonNode.Parse(jsonString);
            JsonObject gainJsonBF = (JsonObject)lamdbda!["config-imaging-mode"]!["bright-field"]!["CameraSetting"]!["gain_"];
            JsonObject gainJsonDF = (JsonObject)lamdbda!["config-imaging-mode"]!["dark-field"]!["CameraSetting"]!["gain_"];
            JsonObject gainJsonRI = (JsonObject)lamdbda!["config-imaging-mode"]!["rheinberg"]!["CameraSetting"]!["gain_"];
            JsonObject gainJsonDP = (JsonObject)lamdbda!["config-imaging-mode"]!["relief-contrast"]!["CameraSetting"]!["gain_"];
            JsonObject gainJsonQP = (JsonObject)lamdbda!["config-imaging-mode"]!["phase-contrast"]!["CameraSetting"]!["gain_"];
            JsonObject gainJsonPC = (JsonObject)lamdbda!["config-imaging-mode"]!["quantitative-phase"]!["CameraSetting"]!["gain_"];
            JsonObject exposureJsonBF = (JsonObject)lamdbda!["config-imaging-mode"]!["bright-field"]!["CameraSetting"]!["exposure_"];
            JsonObject exposureJsonDF = (JsonObject)lamdbda!["config-imaging-mode"]!["dark-field"]!["CameraSetting"]!["exposure_"];
            JsonObject exposureJsonRI = (JsonObject)lamdbda!["config-imaging-mode"]!["rheinberg"]!["CameraSetting"]!["exposure_"];
            JsonObject exposureJsonDP = (JsonObject)lamdbda!["config-imaging-mode"]!["relief-contrast"]!["CameraSetting"]!["exposure_"];
            JsonObject exposureJsonQP = (JsonObject)lamdbda!["config-imaging-mode"]!["phase-contrast"]!["CameraSetting"]!["exposure_"];
            JsonObject exposureJsonPC = (JsonObject)lamdbda!["config-imaging-mode"]!["quantitative-phase"]!["CameraSetting"]!["exposure_"];
            JsonObject ledJsonBF = (JsonObject)lamdbda!["config-imaging-mode"]!["bright-field"]!["led-diameter_"];
            JsonObject ledJsonDF = (JsonObject)lamdbda!["config-imaging-mode"]!["dark-field"]!["led-diameter-inner_"];
            JsonObject ledJsonRI = (JsonObject)lamdbda!["config-imaging-mode"]!["rheinberg"]!["led-diameter-inner_"];
            JsonObject StepXJson = (JsonObject)lamdbda!["config-stage"]!["moving-step"]!["x-step_"];
            JsonObject StepYJson = (JsonObject)lamdbda!["config-stage"]!["moving-step"]!["y-step_"];
            JsonObject StepZJson = (JsonObject)lamdbda!["config-stage"]!["moving-step"]!["z-step_"];

            for (int i = 0; i < objList.Count; i++)
            {
                if (gainJsonBF![objList[i]]!= null)
                {
                    ObjGainListBF[i] = gainJsonBF![objList[i]]!.GetValue<int>();
                };
                if (gainJsonDF![objList[i]]!= null)
                {
                    ObjGainListDF[i] = gainJsonDF![objList[i]]!.GetValue<int>();
                };
                if(gainJsonRI![objList[i]]!= null)
                {
                    ObjGainListRI[i] = gainJsonRI![objList[i]]!.GetValue<int>();
                };
                if (gainJsonDP![objList[i]]!=null)
                {
                    ObjGainListDP[i] = gainJsonDP![objList[i]]!.GetValue<int>();
                };
                if (gainJsonQP![objList[i]]!=null)
                {
                    ObjGainListQP[i] = gainJsonQP![objList[i]]!.GetValue<int>();
                };
                if (gainJsonPC![objList[i]]!=null)
                {
                    ObjGainListPC[i] = gainJsonPC![objList[i]]!.GetValue<int>();
                }
                ;
                if (exposureJsonBF![objList[i]] != null)
                {
                    ObjExposureListBF[i] = exposureJsonBF![objList[i]]!.GetValue<int>();
                };
                if (exposureJsonDF![objList[i]] != null)
                {
                    ObjExposureListDF[i] = exposureJsonDF![objList[i]]!.GetValue<int>();
                };
                if (exposureJsonRI![objList[i]] != null)
                {
                    ObjExposureListRI[i] = exposureJsonRI![objList[i]]!.GetValue<int>();
                };
                if (exposureJsonDP![objList[i]] != null)
                {
                    ObjExposureListDP[i] = exposureJsonDP![objList[i]]!.GetValue<int>();
                };
                if (exposureJsonQP![objList[i]] != null)
                {
                    ObjExposureListQP[i] = exposureJsonQP![objList[i]]!.GetValue<int>();
                };
                if (exposureJsonPC![objList[i]] != null)
                {
                    ObjExposureListPC[i] = exposureJsonPC![objList[i]]!.GetValue<int>();
                };

                if (ledJsonBF![objList[i]] != null)
                {
                    ObjLEDListBF[i] = ledJsonBF![objList[i]]!.GetValue<int>();
                };
                if (ledJsonDF![objList[i]] != null)
                {
                    ObjLEDListDF[i] = ledJsonDF![objList[i]]!.GetValue<int>();
                };
                if (ledJsonRI![objList[i]] != null)
                {
                    ObjLEDListRI[i] = ledJsonRI![objList[i]]!.GetValue<int>();
                };
                if (StepXJson![objList[i]] != null)
                {
                    ObjXStepList[i] = StepXJson![objList[i]]!.GetValue<int>();
                };
                if (StepYJson![objList[i]] != null)
                {
                    ObjYStepList[i] = StepYJson![objList[i]]!.GetValue<int>();
                };
                if (StepZJson![objList[i]] != null)
                {
                    ObjZStepList[i] = StepZJson![objList[i]]!.GetValue<int>();
                };
            }
            GainReadBack();
            ExposureReadBack();
            LEDReadBack();
            StepReadBack();
        }

        public void GainReadBack()
        {
           
            SolutionConfig.OperatingMode.BrightField.CameraSetting.MultiObjGain.Gain0 = ObjGainListBF[0];
            SolutionConfig.OperatingMode.BrightField.CameraSetting.MultiObjGain.Gain1 = ObjGainListBF[1];
            SolutionConfig.OperatingMode.BrightField.CameraSetting.MultiObjGain.Gain2 = ObjGainListBF[2];
            SolutionConfig.OperatingMode.BrightField.CameraSetting.MultiObjGain.Gain3 = ObjGainListBF[3];

            SolutionConfig.OperatingMode.DarkField.CameraSetting.MultiObjGain.Gain0 = ObjGainListDF[0];
            SolutionConfig.OperatingMode.DarkField.CameraSetting.MultiObjGain.Gain1 = ObjGainListDF[1];
            SolutionConfig.OperatingMode.DarkField.CameraSetting.MultiObjGain.Gain2 = ObjGainListDF[2];
            SolutionConfig.OperatingMode.DarkField.CameraSetting.MultiObjGain.Gain3 = ObjGainListDF[3];

            SolutionConfig.OperatingMode.Reinberg.CameraSetting.MultiObjGain.Gain0 = ObjGainListRI[0];
            SolutionConfig.OperatingMode.Reinberg.CameraSetting.MultiObjGain.Gain1 = ObjGainListRI[1];
            SolutionConfig.OperatingMode.Reinberg.CameraSetting.MultiObjGain.Gain2 = ObjGainListRI[2];
            SolutionConfig.OperatingMode.Reinberg.CameraSetting.MultiObjGain.Gain3 = ObjGainListRI[3];

            SolutionConfig.OperatingMode.ReliefContrast.CameraSetting.MultiObjGain.Gain0 = ObjGainListDP[0];
            SolutionConfig.OperatingMode.ReliefContrast.CameraSetting.MultiObjGain.Gain1 = ObjGainListDP[1];
            SolutionConfig.OperatingMode.ReliefContrast.CameraSetting.MultiObjGain.Gain2 = ObjGainListDP[2];
            SolutionConfig.OperatingMode.ReliefContrast.CameraSetting.MultiObjGain.Gain3 = ObjGainListDP[3];

            SolutionConfig.OperatingMode.QuantitativePhase.CameraSetting.MultiObjGain.Gain0 = ObjGainListQP[0];
            SolutionConfig.OperatingMode.QuantitativePhase.CameraSetting.MultiObjGain.Gain1 = ObjGainListQP[1];
            SolutionConfig.OperatingMode.QuantitativePhase.CameraSetting.MultiObjGain.Gain2 = ObjGainListQP[2];
            SolutionConfig.OperatingMode.QuantitativePhase.CameraSetting.MultiObjGain.Gain3 = ObjGainListQP[3];

            SolutionConfig.OperatingMode.PhaseContrast.CameraSetting.MultiObjGain.Gain0 = ObjGainListPC[0];
            SolutionConfig.OperatingMode.PhaseContrast.CameraSetting.MultiObjGain.Gain1 = ObjGainListPC[1];
            SolutionConfig.OperatingMode.PhaseContrast.CameraSetting.MultiObjGain.Gain2 = ObjGainListPC[2];
            SolutionConfig.OperatingMode.PhaseContrast.CameraSetting.MultiObjGain.Gain3 = ObjGainListPC[3];



        }
        public void ExposureReadBack()
        {
            //BF

            SolutionConfig.OperatingMode.BrightField.CameraSetting.MultiObjExposure.Exposure0 = ObjExposureListBF[0];
            SolutionConfig.OperatingMode.BrightField.CameraSetting.MultiObjExposure.Exposure1= ObjExposureListBF[1];
            SolutionConfig.OperatingMode.BrightField.CameraSetting.MultiObjExposure.Exposure2= ObjExposureListBF[2];
            SolutionConfig.OperatingMode.BrightField.CameraSetting.MultiObjExposure.Exposure3= ObjExposureListBF[3];
            //DF
            SolutionConfig.OperatingMode.DarkField.CameraSetting.MultiObjExposure.Exposure0= ObjExposureListDF[0];
            SolutionConfig.OperatingMode.DarkField.CameraSetting.MultiObjExposure.Exposure1 = ObjExposureListDF[1];
            SolutionConfig.OperatingMode.DarkField.CameraSetting.MultiObjExposure.Exposure2 =ObjExposureListDF[2];
            SolutionConfig.OperatingMode.DarkField.CameraSetting.MultiObjExposure.Exposure3 = ObjExposureListDF[3];
            //RI
            SolutionConfig.OperatingMode.Reinberg.CameraSetting.MultiObjExposure.Exposure0= ObjExposureListRI[0];
            SolutionConfig.OperatingMode.Reinberg.CameraSetting.MultiObjExposure.Exposure1 = ObjExposureListRI[1];
            SolutionConfig.OperatingMode.Reinberg.CameraSetting.MultiObjExposure.Exposure2= ObjExposureListRI[2];
            SolutionConfig.OperatingMode.Reinberg.CameraSetting.MultiObjExposure.Exposure3 = ObjExposureListRI[3];
            //DP

            SolutionConfig.OperatingMode.ReliefContrast.CameraSetting.MultiObjExposure.Exposure0 = ObjExposureListDP[0];
            SolutionConfig.OperatingMode.ReliefContrast.CameraSetting.MultiObjExposure.Exposure1 = ObjExposureListDP[1];
            SolutionConfig.OperatingMode.ReliefContrast.CameraSetting.MultiObjExposure.Exposure2 = ObjExposureListDP[2];
            SolutionConfig.OperatingMode.ReliefContrast.CameraSetting.MultiObjExposure.Exposure3 = ObjExposureListDP[3];
            //QP
            SolutionConfig.OperatingMode.QuantitativePhase.CameraSetting.MultiObjExposure.Exposure0 = ObjExposureListQP[0];
            SolutionConfig.OperatingMode.QuantitativePhase.CameraSetting.MultiObjExposure.Exposure1 = ObjExposureListQP[1];
            SolutionConfig.OperatingMode.QuantitativePhase.CameraSetting.MultiObjExposure.Exposure2 = ObjExposureListQP[2];
            SolutionConfig.OperatingMode.QuantitativePhase.CameraSetting.MultiObjExposure.Exposure3 = ObjExposureListQP[3];
            //PC
            SolutionConfig.OperatingMode.PhaseContrast.CameraSetting.MultiObjExposure.Exposure0 = ObjExposureListPC[0];
            SolutionConfig.OperatingMode.PhaseContrast.CameraSetting.MultiObjExposure.Exposure1 = ObjExposureListPC[1];
            SolutionConfig.OperatingMode.PhaseContrast.CameraSetting.MultiObjExposure.Exposure2 = ObjExposureListPC[2];
            SolutionConfig.OperatingMode.PhaseContrast.CameraSetting.MultiObjExposure.Exposure3 = ObjExposureListPC[3];


        }

        public void LEDReadBack()
        {
            //BF LED
            SolutionConfig.OperatingMode.BrightField.MultiAperture.Outer0 = ObjLEDListBF[0];
            SolutionConfig.OperatingMode.BrightField.MultiAperture.Outer1= ObjLEDListBF[1];
            SolutionConfig.OperatingMode.BrightField.MultiAperture.Outer2= ObjLEDListBF[2];
            SolutionConfig.OperatingMode.BrightField.MultiAperture.Outer3= ObjLEDListBF[3];
            //DF LED
            SolutionConfig.OperatingMode.DarkField.MultiAperture.Inner0= ObjLEDListDF[0];
            SolutionConfig.OperatingMode.DarkField.MultiAperture.Inner1= ObjLEDListDF[1];
            SolutionConfig.OperatingMode.DarkField.MultiAperture.Inner2= ObjLEDListDF[2];
            SolutionConfig.OperatingMode.DarkField.MultiAperture.Inner3= ObjLEDListDF[3];

            //RI LED
            SolutionConfig.OperatingMode.Reinberg.MultiAperture.Inner0 = ObjLEDListDF[0];
            SolutionConfig.OperatingMode.Reinberg.MultiAperture.Inner1 = ObjLEDListDF[1];
            SolutionConfig.OperatingMode.Reinberg.MultiAperture.Inner2= ObjLEDListDF[2];
            SolutionConfig.OperatingMode.Reinberg.MultiAperture.Inner3 = ObjLEDListDF[3];


        }
        public void StepReadBack()
        {
            //X Step
            SolutionConfig.Stage.MoveStep.XStep_.Step0 = ObjXStepList[0];
            SolutionConfig.Stage.MoveStep.XStep_.Step1 = ObjXStepList[1];
            SolutionConfig.Stage.MoveStep.XStep_.Step2 = ObjXStepList[2];
            SolutionConfig.Stage.MoveStep.XStep_.Step3 = ObjXStepList[3];
            //Y Step
            SolutionConfig.Stage.MoveStep.YStep_.Step0 = ObjYStepList[0];
            SolutionConfig.Stage.MoveStep.YStep_.Step1 = ObjYStepList[1];
            SolutionConfig.Stage.MoveStep.YStep_.Step2 = ObjYStepList[2];
            SolutionConfig.Stage.MoveStep.YStep_.Step3 = ObjYStepList[3];

            //Z Step
            SolutionConfig.Stage.MoveStep.ZStep_.Step0 = ObjZStepList[0];
            SolutionConfig.Stage.MoveStep.ZStep_.Step1 = ObjZStepList[1];
            SolutionConfig.Stage.MoveStep.YStep_.Step2 = ObjZStepList[2];
            SolutionConfig.Stage.MoveStep.YStep_.Step3 = ObjZStepList[3];


        }


        public void GenerateGainList()
        {
            //BF
            ObjGainListBF.Clear();
            ObjGainListBF.Add(SolutionConfig.OperatingMode.BrightField.CameraSetting.MultiObjGain.Gain0);
            ObjGainListBF.Add(SolutionConfig.OperatingMode.BrightField.CameraSetting.MultiObjGain.Gain1);
            ObjGainListBF.Add(SolutionConfig.OperatingMode.BrightField.CameraSetting.MultiObjGain.Gain2);
            ObjGainListBF.Add(SolutionConfig.OperatingMode.BrightField.CameraSetting.MultiObjGain.Gain3);
            //DF
            ObjGainListDF.Clear();
            ObjGainListDF.Add(SolutionConfig.OperatingMode.DarkField.CameraSetting.MultiObjGain.Gain0);
            ObjGainListDF.Add(SolutionConfig.OperatingMode.DarkField.CameraSetting.MultiObjGain.Gain1);
            ObjGainListDF.Add(SolutionConfig.OperatingMode.DarkField.CameraSetting.MultiObjGain.Gain2);
            ObjGainListDF.Add(SolutionConfig.OperatingMode.DarkField.CameraSetting.MultiObjGain.Gain3);
            //RI
            ObjGainListRI.Clear();
            ObjGainListRI.Add(SolutionConfig.OperatingMode.Reinberg.CameraSetting.MultiObjGain.Gain0);
            ObjGainListRI.Add(SolutionConfig.OperatingMode.Reinberg.CameraSetting.MultiObjGain.Gain1);
            ObjGainListRI.Add(SolutionConfig.OperatingMode.Reinberg.CameraSetting.MultiObjGain.Gain2);
            ObjGainListRI.Add(SolutionConfig.OperatingMode.Reinberg.CameraSetting.MultiObjGain.Gain3);
            //DP
            ObjGainListDP.Clear();
            ObjGainListDP.Add(SolutionConfig.OperatingMode.ReliefContrast.CameraSetting.MultiObjGain.Gain0);
            ObjGainListDP.Add(SolutionConfig.OperatingMode.ReliefContrast.CameraSetting.MultiObjGain.Gain1);
            ObjGainListDP.Add(SolutionConfig.OperatingMode.ReliefContrast.CameraSetting.MultiObjGain.Gain2);
            ObjGainListDP.Add(SolutionConfig.OperatingMode.ReliefContrast.CameraSetting.MultiObjGain.Gain3);
            //QP
            ObjGainListQP.Clear();
            ObjGainListQP.Add(SolutionConfig.OperatingMode.QuantitativePhase.CameraSetting.MultiObjGain.Gain0);
            ObjGainListQP.Add(SolutionConfig.OperatingMode.QuantitativePhase.CameraSetting.MultiObjGain.Gain1);
            ObjGainListQP.Add(SolutionConfig.OperatingMode.QuantitativePhase.CameraSetting.MultiObjGain.Gain2);
            ObjGainListQP.Add(SolutionConfig.OperatingMode.QuantitativePhase.CameraSetting.MultiObjGain.Gain3);
            //PC
            ObjGainListPC.Clear();
            ObjGainListPC.Add(SolutionConfig.OperatingMode.PhaseContrast.CameraSetting.MultiObjGain.Gain0);
            ObjGainListPC.Add(SolutionConfig.OperatingMode.PhaseContrast.CameraSetting.MultiObjGain.Gain1);
            ObjGainListPC.Add(SolutionConfig.OperatingMode.PhaseContrast.CameraSetting.MultiObjGain.Gain2);
            ObjGainListPC.Add(SolutionConfig.OperatingMode.PhaseContrast.CameraSetting.MultiObjGain.Gain3);
        }
        public void GenerateExposureList()
        {
            //BF
            ObjExposureListBF.Clear();
            ObjExposureListBF.Add(SolutionConfig.OperatingMode.BrightField.CameraSetting.MultiObjExposure.Exposure0);
            ObjExposureListBF.Add(SolutionConfig.OperatingMode.BrightField.CameraSetting.MultiObjExposure.Exposure1);
            ObjExposureListBF.Add(SolutionConfig.OperatingMode.BrightField.CameraSetting.MultiObjExposure.Exposure2);
            ObjExposureListBF.Add(SolutionConfig.OperatingMode.BrightField.CameraSetting.MultiObjExposure.Exposure3);
            //DF
            ObjExposureListDF.Clear();
            ObjExposureListDF.Add(SolutionConfig.OperatingMode.DarkField.CameraSetting.MultiObjExposure.Exposure0);
            ObjExposureListDF.Add(SolutionConfig.OperatingMode.DarkField.CameraSetting.MultiObjExposure.Exposure1);
            ObjExposureListDF.Add(SolutionConfig.OperatingMode.DarkField.CameraSetting.MultiObjExposure.Exposure2);
            ObjExposureListDF.Add(SolutionConfig.OperatingMode.DarkField.CameraSetting.MultiObjExposure.Exposure3);
            //RI
            ObjExposureListRI.Clear();
            ObjExposureListRI.Add(SolutionConfig.OperatingMode.Reinberg.CameraSetting.MultiObjExposure.Exposure0);
            ObjExposureListRI.Add(SolutionConfig.OperatingMode.Reinberg.CameraSetting.MultiObjExposure.Exposure1);
            ObjExposureListRI.Add(SolutionConfig.OperatingMode.Reinberg.CameraSetting.MultiObjExposure.Exposure2);
            ObjExposureListRI.Add(SolutionConfig.OperatingMode.Reinberg.CameraSetting.MultiObjExposure.Exposure3);
            //DP
            ObjExposureListDP.Clear();
            ObjExposureListDP.Add(SolutionConfig.OperatingMode.ReliefContrast.CameraSetting.MultiObjExposure.Exposure0);
            ObjExposureListDP.Add(SolutionConfig.OperatingMode.ReliefContrast.CameraSetting.MultiObjExposure.Exposure1);
            ObjExposureListDP.Add(SolutionConfig.OperatingMode.ReliefContrast.CameraSetting.MultiObjExposure.Exposure2);
            ObjExposureListDP.Add(SolutionConfig.OperatingMode.ReliefContrast.CameraSetting.MultiObjExposure.Exposure3);
            //QP
            ObjExposureListQP.Clear();
            ObjExposureListQP.Add(SolutionConfig.OperatingMode.QuantitativePhase.CameraSetting.MultiObjExposure.Exposure0);
            ObjExposureListQP.Add(SolutionConfig.OperatingMode.QuantitativePhase.CameraSetting.MultiObjExposure.Exposure1);
            ObjExposureListQP.Add(SolutionConfig.OperatingMode.QuantitativePhase.CameraSetting.MultiObjExposure.Exposure2);
            ObjExposureListQP.Add(SolutionConfig.OperatingMode.QuantitativePhase.CameraSetting.MultiObjExposure.Exposure3);
            //PC
            ObjExposureListPC.Clear();
            ObjExposureListPC.Add(SolutionConfig.OperatingMode.PhaseContrast.CameraSetting.MultiObjExposure.Exposure0);
            ObjExposureListPC.Add(SolutionConfig.OperatingMode.PhaseContrast.CameraSetting.MultiObjExposure.Exposure1);
            ObjExposureListPC.Add(SolutionConfig.OperatingMode.PhaseContrast.CameraSetting.MultiObjExposure.Exposure2);
            ObjExposureListPC.Add(SolutionConfig.OperatingMode.PhaseContrast.CameraSetting.MultiObjExposure.Exposure3);
        }
        public void GenerateLedList()
        {
            //BF LED
            ObjLEDListBF.Clear();
            ObjLEDListBF.Add(SolutionConfig.OperatingMode.BrightField.MultiAperture.Outer0);
            ObjLEDListBF.Add(SolutionConfig.OperatingMode.BrightField.MultiAperture.Outer1);
            ObjLEDListBF.Add(SolutionConfig.OperatingMode.BrightField.MultiAperture.Outer2);
            ObjLEDListBF.Add(SolutionConfig.OperatingMode.BrightField.MultiAperture.Outer3);
            //DF LED
            ObjLEDListDF.Clear();
            ObjLEDListDF.Add(SolutionConfig.OperatingMode.DarkField.MultiAperture.Inner0);
            ObjLEDListDF.Add(SolutionConfig.OperatingMode.DarkField.MultiAperture.Inner1);
            ObjLEDListDF.Add(SolutionConfig.OperatingMode.DarkField.MultiAperture.Inner2);
            ObjLEDListDF.Add(SolutionConfig.OperatingMode.DarkField.MultiAperture.Inner3);

            //RI LED
            ObjLEDListRI.Clear();
            ObjLEDListRI.Add(SolutionConfig.OperatingMode.Reinberg.MultiAperture.Inner0);
            ObjLEDListRI.Add(SolutionConfig.OperatingMode.Reinberg.MultiAperture.Inner1);
            ObjLEDListRI.Add(SolutionConfig.OperatingMode.Reinberg.MultiAperture.Inner2);
            ObjLEDListRI.Add(SolutionConfig.OperatingMode.Reinberg.MultiAperture.Inner3);
        }

        public void GenerateStepList()
        {
            //X Step
            ObjXStepList.Clear();
            ObjXStepList.Add(SolutionConfig.Stage.MoveStep.XStep_.Step0);
            ObjXStepList.Add(SolutionConfig.Stage.MoveStep.XStep_.Step1);
            ObjXStepList.Add(SolutionConfig.Stage.MoveStep.XStep_.Step2);
            ObjXStepList.Add(SolutionConfig.Stage.MoveStep.XStep_.Step3);

            //Y Step
            ObjYStepList.Clear();
            ObjYStepList.Add(SolutionConfig.Stage.MoveStep.YStep_.Step0);
            ObjYStepList.Add(SolutionConfig.Stage.MoveStep.YStep_.Step1);
            ObjYStepList.Add(SolutionConfig.Stage.MoveStep.YStep_.Step2);
            ObjYStepList.Add(SolutionConfig.Stage.MoveStep.YStep_.Step3);

            //Z Step
            ObjZStepList.Clear();
            ObjZStepList.Add(SolutionConfig.Stage.MoveStep.ZStep_.Step0);
            ObjZStepList.Add(SolutionConfig.Stage.MoveStep.ZStep_.Step1);
            ObjZStepList.Add(SolutionConfig.Stage.MoveStep.ZStep_.Step2);
            ObjZStepList.Add(SolutionConfig.Stage.MoveStep.ZStep_.Step3);


        }

    }
}
