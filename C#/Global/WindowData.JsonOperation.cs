
using Global.Mode;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Global
{
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

        public List<string> ObjList = new List<string>() { "10x", "20s", "20px" };

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
                if (gainJsonBF![objList[i]]!= null)
                {
                    ObjGainListBF[i] = gainJsonBF![objList[i]]!.GetValue<int>();
                };
                if (gainJsonDF![objList[i]]!= null)
                {
                    ObjGainListDF[i] = gainJsonDF![objList[i]]!.GetValue<int>();
                }
                if(gainJsonRI![objList[i]]!= null)
                {
                    ObjGainListRI[i] = gainJsonRI![objList[i]]!.GetValue<int>();
                }
                if (gainJsonDP![objList[i]]!=null)
                {
                    ObjGainListDP[i] = gainJsonDP![objList[i]]!.GetValue<int>();
                }
                if (gainJsonQP![objList[i]]!=null)
                {
                    ObjGainListQP[i] = gainJsonQP![objList[i]]!.GetValue<int>();
                }
                if (gainJsonPC![objList[i]]!=null)
                {
                    ObjGainListPC[i] = gainJsonPC![objList[i]]!.GetValue<int>();
                }
               


            }


            GainWriteBack();



        }

        public void GainWriteBack()
        {
           
            SolutionConfig.OperatingMode.BrightField.CameraSetting.MultiObjGain.Gain1 = ObjGainListBF[0];
            SolutionConfig.OperatingMode.BrightField.CameraSetting.MultiObjGain.Gain2 = ObjGainListBF[1];
            SolutionConfig.OperatingMode.BrightField.CameraSetting.MultiObjGain.Gain3 = ObjGainListBF[2];
            SolutionConfig.OperatingMode.BrightField.CameraSetting.MultiObjGain.Gain4 = ObjGainListBF[3];

            SolutionConfig.OperatingMode.DarkField.CameraSetting.MultiObjGain.Gain1 = ObjGainListBF[0];
            SolutionConfig.OperatingMode.DarkField.CameraSetting.MultiObjGain.Gain2 = ObjGainListBF[1];
            SolutionConfig.OperatingMode.DarkField.CameraSetting.MultiObjGain.Gain3 = ObjGainListBF[2];
            SolutionConfig.OperatingMode.DarkField.CameraSetting.MultiObjGain.Gain4 = ObjGainListBF[3];




        }














        public void GenerateGainList()
        {
            //BF
            ObjGainListBF.Clear();
            ObjGainListBF.Add(SolutionConfig.OperatingMode.BrightField.CameraSetting.MultiObjGain.Gain1);
            ObjGainListBF.Add(SolutionConfig.OperatingMode.BrightField.CameraSetting.MultiObjGain.Gain2);
            ObjGainListBF.Add(SolutionConfig.OperatingMode.BrightField.CameraSetting.MultiObjGain.Gain3);
            ObjGainListBF.Add(SolutionConfig.OperatingMode.BrightField.CameraSetting.MultiObjGain.Gain4);
            //DF
            ObjGainListDF.Clear();
            ObjGainListDF.Add(SolutionConfig.OperatingMode.DarkField.CameraSetting.MultiObjGain.Gain1);
            ObjGainListDF.Add(SolutionConfig.OperatingMode.DarkField.CameraSetting.MultiObjGain.Gain2);
            ObjGainListDF.Add(SolutionConfig.OperatingMode.DarkField.CameraSetting.MultiObjGain.Gain3);
            ObjGainListDF.Add(SolutionConfig.OperatingMode.DarkField.CameraSetting.MultiObjGain.Gain4);
            //RI
            ObjGainListRI.Clear();
            ObjGainListRI.Add(SolutionConfig.OperatingMode.Reinberg.CameraSetting.MultiObjGain.Gain1);
            ObjGainListRI.Add(SolutionConfig.OperatingMode.Reinberg.CameraSetting.MultiObjGain.Gain2);
            ObjGainListRI.Add(SolutionConfig.OperatingMode.Reinberg.CameraSetting.MultiObjGain.Gain3);
            ObjGainListRI.Add(SolutionConfig.OperatingMode.Reinberg.CameraSetting.MultiObjGain.Gain4);
            //DP
            ObjGainListDP.Clear();
            ObjGainListDP.Add(SolutionConfig.OperatingMode.ReliefContrast.CameraSetting.MultiObjGain.Gain1);
            ObjGainListDP.Add(SolutionConfig.OperatingMode.ReliefContrast.CameraSetting.MultiObjGain.Gain2);
            ObjGainListDP.Add(SolutionConfig.OperatingMode.ReliefContrast.CameraSetting.MultiObjGain.Gain3);
            ObjGainListDP.Add(SolutionConfig.OperatingMode.ReliefContrast.CameraSetting.MultiObjGain.Gain4);
            //QP
            ObjGainListQP.Clear();
            ObjGainListQP.Add(SolutionConfig.OperatingMode.QuantitativePhase.CameraSetting.MultiObjGain.Gain1);
            ObjGainListQP.Add(SolutionConfig.OperatingMode.QuantitativePhase.CameraSetting.MultiObjGain.Gain2);
            ObjGainListQP.Add(SolutionConfig.OperatingMode.QuantitativePhase.CameraSetting.MultiObjGain.Gain3);
            ObjGainListQP.Add(SolutionConfig.OperatingMode.QuantitativePhase.CameraSetting.MultiObjGain.Gain4);
            //PC
            ObjGainListPC.Clear();
            ObjGainListPC.Add(SolutionConfig.OperatingMode.PhaseContrast.CameraSetting.MultiObjGain.Gain1);
            ObjGainListPC.Add(SolutionConfig.OperatingMode.PhaseContrast.CameraSetting.MultiObjGain.Gain2);
            ObjGainListPC.Add(SolutionConfig.OperatingMode.PhaseContrast.CameraSetting.MultiObjGain.Gain3);
            ObjGainListPC.Add(SolutionConfig.OperatingMode.PhaseContrast.CameraSetting.MultiObjGain.Gain4);
        }
        public void GenerateExposureList()
        {
            //BF
            ObjExposureListBF.Clear();
            ObjExposureListBF.Add(SolutionConfig.OperatingMode.BrightField.CameraSetting.MultiObjExposure.Exposure1);
            ObjExposureListBF.Add(SolutionConfig.OperatingMode.BrightField.CameraSetting.MultiObjExposure.Exposure2);
            ObjExposureListBF.Add(SolutionConfig.OperatingMode.BrightField.CameraSetting.MultiObjExposure.Exposure3);
            ObjExposureListBF.Add(SolutionConfig.OperatingMode.BrightField.CameraSetting.MultiObjExposure.Exposure4);
            //DF
            ObjExposureListDF.Clear();
            ObjExposureListDF.Add(SolutionConfig.OperatingMode.DarkField.CameraSetting.MultiObjExposure.Exposure1);
            ObjExposureListDF.Add(SolutionConfig.OperatingMode.DarkField.CameraSetting.MultiObjExposure.Exposure2);
            ObjExposureListDF.Add(SolutionConfig.OperatingMode.DarkField.CameraSetting.MultiObjExposure.Exposure3);
            ObjExposureListDF.Add(SolutionConfig.OperatingMode.DarkField.CameraSetting.MultiObjExposure.Exposure4);
            //RI
            ObjExposureListRI.Clear();
            ObjExposureListRI.Add(SolutionConfig.OperatingMode.Reinberg.CameraSetting.MultiObjExposure.Exposure1);
            ObjExposureListRI.Add(SolutionConfig.OperatingMode.Reinberg.CameraSetting.MultiObjExposure.Exposure2);
            ObjExposureListRI.Add(SolutionConfig.OperatingMode.Reinberg.CameraSetting.MultiObjExposure.Exposure3);
            ObjExposureListRI.Add(SolutionConfig.OperatingMode.Reinberg.CameraSetting.MultiObjExposure.Exposure4);
            //DP
            ObjExposureListDP.Clear();
            ObjExposureListDP.Add(SolutionConfig.OperatingMode.ReliefContrast.CameraSetting.MultiObjExposure.Exposure1);
            ObjExposureListDP.Add(SolutionConfig.OperatingMode.ReliefContrast.CameraSetting.MultiObjExposure.Exposure2);
            ObjExposureListDP.Add(SolutionConfig.OperatingMode.ReliefContrast.CameraSetting.MultiObjExposure.Exposure3);
            ObjExposureListDP.Add(SolutionConfig.OperatingMode.ReliefContrast.CameraSetting.MultiObjExposure.Exposure4);
            //QP
            ObjExposureListQP.Clear();
            ObjExposureListQP.Add(SolutionConfig.OperatingMode.QuantitativePhase.CameraSetting.MultiObjExposure.Exposure1);
            ObjExposureListQP.Add(SolutionConfig.OperatingMode.QuantitativePhase.CameraSetting.MultiObjExposure.Exposure2);
            ObjExposureListQP.Add(SolutionConfig.OperatingMode.QuantitativePhase.CameraSetting.MultiObjExposure.Exposure3);
            ObjExposureListQP.Add(SolutionConfig.OperatingMode.QuantitativePhase.CameraSetting.MultiObjExposure.Exposure4);
            //PC
            ObjExposureListPC.Clear();
            ObjExposureListPC.Add(SolutionConfig.OperatingMode.PhaseContrast.CameraSetting.MultiObjExposure.Exposure1);
            ObjExposureListPC.Add(SolutionConfig.OperatingMode.PhaseContrast.CameraSetting.MultiObjExposure.Exposure2);
            ObjExposureListPC.Add(SolutionConfig.OperatingMode.PhaseContrast.CameraSetting.MultiObjExposure.Exposure3);
            ObjExposureListPC.Add(SolutionConfig.OperatingMode.PhaseContrast.CameraSetting.MultiObjExposure.Exposure4);
        }
        public void GenerateLedList()
        {
            //BF LED
            ObjLEDListBF.Clear();
            ObjLEDListBF.Add(SolutionConfig.OperatingMode.BrightField.MultiAperture.Outer1);
            ObjLEDListBF.Add(SolutionConfig.OperatingMode.BrightField.MultiAperture.Outer2);
            ObjLEDListBF.Add(SolutionConfig.OperatingMode.BrightField.MultiAperture.Outer3);
            ObjLEDListBF.Add(SolutionConfig.OperatingMode.BrightField.MultiAperture.Outer4);
            //DF LED
            ObjLEDListDF.Clear();
            ObjLEDListDF.Add(SolutionConfig.OperatingMode.DarkField.MultiAperture.Inner1);
            ObjLEDListDF.Add(SolutionConfig.OperatingMode.DarkField.MultiAperture.Inner2);
            ObjLEDListDF.Add(SolutionConfig.OperatingMode.DarkField.MultiAperture.Inner3);
            ObjLEDListDF.Add(SolutionConfig.OperatingMode.DarkField.MultiAperture.Inner4);

            //RI LED
            ObjLEDListRI.Clear();
            ObjLEDListRI.Add(SolutionConfig.OperatingMode.Reinberg.MultiAperture.Inner1);
            ObjLEDListRI.Add(SolutionConfig.OperatingMode.Reinberg.MultiAperture.Inner2);
            ObjLEDListRI.Add(SolutionConfig.OperatingMode.Reinberg.MultiAperture.Inner3);
            ObjLEDListRI.Add(SolutionConfig.OperatingMode.Reinberg.MultiAperture.Inner4);
        }

        public void GenerateStepList()
        {
            //X Step
            ObjXStepList.Clear();
            ObjXStepList.Add(SolutionConfig.Stage.MoveStep.XStep_.Step1);
            ObjXStepList.Add(SolutionConfig.Stage.MoveStep.XStep_.Step2);
            ObjXStepList.Add(SolutionConfig.Stage.MoveStep.XStep_.Step3);
            ObjXStepList.Add(SolutionConfig.Stage.MoveStep.XStep_.Step4);

            //Y Step
            ObjYStepList.Clear();
            ObjYStepList.Add(SolutionConfig.Stage.MoveStep.YStep_.Step1);
            ObjYStepList.Add(SolutionConfig.Stage.MoveStep.YStep_.Step2);
            ObjYStepList.Add(SolutionConfig.Stage.MoveStep.YStep_.Step3);
            ObjYStepList.Add(SolutionConfig.Stage.MoveStep.YStep_.Step4);

            //Z Step
            ObjZStepList.Clear();
            ObjZStepList.Add(SolutionConfig.Stage.MoveStep.ZStep_.Step1);
            ObjZStepList.Add(SolutionConfig.Stage.MoveStep.ZStep_.Step2);
            ObjZStepList.Add(SolutionConfig.Stage.MoveStep.ZStep_.Step3);
            ObjZStepList.Add(SolutionConfig.Stage.MoveStep.ZStep_.Step4);


        }



































    }
}
