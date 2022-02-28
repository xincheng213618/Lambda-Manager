using Lambda;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;


namespace MenuISCameraSetting;

partial class CameraDialog : Window, IComponentConnector
{

	public CameraDialog()
	{
		InitializeComponent();
    }
    private void Window_Initialized(object sender, EventArgs e)
    {

        LambdaControl.CallEventHandler += Call;
    }

    private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
    {

    }

    private int Call(string type, object sender, EventArgs e)
    {
        LambdaArgs lambdaArgs = (LambdaArgs)e;
        TextBox1.Text = type + lambdaArgs.Data.ToString();
        return 1;
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        this.Close();
    }

    private void Button_Test_Click(object sender, RoutedEventArgs e)
    {
        Button button = sender as Button;
        switch (button.Content)
        {
            case "Test1":
                Dictionary<string, object> data = new() { };
                LambdaControl.Trigger("ButtonTest1", button, data);
                break;
            case "Test2":
                data = new() { };
                LambdaControl.Trigger("ButtonTest2", button, data);
                break;
            case "Test3":
                data = new() { };
                LambdaControl.Trigger("ButtonTest3", button, data);
                break;
            case "Test4":
                data = new() { };
                LambdaControl.Trigger("ButtonTest4", button, data);
                break;
            case "Test5":
                data = new() { };
                LambdaControl.Trigger("ButtonTest5", button, data);
                break;
        }
    }


}
