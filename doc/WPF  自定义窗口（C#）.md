# WPF  自定义窗口（C#）

## 前言

WPF  自定义窗口 自定义窗口的这个问题，我在很久之前就有遇到，当时的解决办法也是简单粗暴，直接设置WindowStyle="None" 、ResizeMode="NoResize" 和 AllowsTransparency="True" ，然后在里面的窗口里，自行实现窗口事件和阴影效果。

现在回望，很蠢。边缘阴影效果很差，边界线的感觉很low，窗口功能和图标都不能完美现实，最大化，最小化，关比的按钮做的千奇百怪。

最为重要的一点是体验很差，没有办法完美实现窗口的效果，强行实现要花的时间不值当的。

## 进阶 WindowChrome 

我在Google 的过程中，突然看到了 可以使用WindowChrome 来自定义窗口样式。 不仅效果好，性能也高。

参考：[WPF 制作高性能的透明背景异形窗口（使用 WindowChrome 而不要使用 AllowsTransparency=True）]( https://blog.walterlv.com/post/wpf-transparent-window-without-allows-transparency.html) 

​            [WPF 使用 WindowChrome，在自定义窗口标题栏的同时最大程度保留原生窗口样式（类似 UWP/Chrome）](https://blog.walterlv.com/post/wpf-simulate-native-window-style-using-window-chrome.html)

若要自定义窗口，同时保留其标准功能，可以使用WindowChrome类。 WindowChrome类窗口框架的功能分离开来视觉对象，并允许您控制的客户端和应用程序窗口的非工作区之间的边界。

只需要配置，即可。我尝试了一下，效果害可以，但是带来了新的问题。

    <WindowChrome.WindowChrome>
        <WindowChrome GlassFrameThickness="0 64 0 0" NonClientFrameEdges="Left,Bottom,Right" />
    </WindowChrome.WindowChrome>
    <Window.Template>
        <ControlTemplate TargetType="Window">
            <Border Padding="0 30 0 0">
                <Grid x:Name="RootGrid" Background="{TemplateBinding Background}">
                    <Border Background="{TemplateBinding Background}"
                            VerticalAlignment="Top" Height="30" Margin="0 -29 140 0">
                        <TextBlock Foreground="White" Margin="16 0" VerticalAlignment="Center"
                                   FontSize="12" Text="{TemplateBinding Title}" />
                    </Border>
                    <ContentPresenter />
                </Grid>
            </Border>
            <ControlTemplate.Triggers>
                <Trigger Property="WindowState" Value="Maximized">
                    <Setter TargetName="RootGrid" Property="Margin" Value="6" />
                </Trigger>
            </ControlTemplate.Triggers>
        </ControlTemplate>
    </Window.Template>

我在进行主题切换的时候，还剩下右上角的三颗按钮的背景色无法定制。这种样子蠢得要死。查了就很久的网页，解决的办法分成两种，一种复杂一些，要copy 100行代码左右，直接修改Win32 Api 。 另一种是 设置WindowChrome 的属性 UseAeroCaptionButtons =“False” 然后自定义工具栏。

说实在的我感觉这两种都很蠢，都需要很高的代码量，才能解决问题，而且复用性极差。复用只能Copy 代码，还需要按照需求修改 。

于是我又参考了[WPF 应用完全模拟 UWP 的标题栏按钮](https://blog.walterlv.com/post/wpf-simulate-native-window-title-bar-buttons) ，感觉呢，有可能是我很蠢，我直接调用失败了，有些参数，参考里没有给，

写完跑不了。

## [Segoe MDL2 Assets](https://docs.microsoft.com/en-us/windows/uwp/design/style/segoe-ui-symbol-font)

这是一个字体图标库，设置字体为里面的参数，就可以使用，就是上面缺失的那个部分。

在Github 里面找到的.....，重新设定参数。 使用方式如下。

     <TextBlock Text="&#xEC45;" FontFamily="Segoe MDL2 Assets" FontSize="15"  Foreground="{DynamicResource WindowTitleBrush}"/>

# 结束

通过 Ctrl +C ，Ctrl +V ，完美的实现了自定义窗口的效果，并且代码的每个部分都可以单独拆分使用，通过拆解这些代码，就可以完美模仿各种软件上的窗口。比如QQ 的没有最大化的窗口，微信的前置置顶,chrome 的搜索和标签，以及凶残的Office。

本代码模仿 Visual Studio 2019。 

# 最后的完整的参数如下

Xaml

    <WindowChrome.WindowChrome>
        <WindowChrome  GlassFrameThickness="1 64 1 1" NonClientFrameEdges="Right" UseAeroCaptionButtons="False" />
    </WindowChrome.WindowChrome>
    <Window.Template>
        <ControlTemplate TargetType="Window">
            <Border Padding="0 30 0 0"   BorderBrush="{TemplateBinding BorderBrush}"  BorderThickness="{TemplateBinding BorderThickness}"  >
                <Grid x:Name="RootGrid"  Background="{TemplateBinding Background}">
                    <Grid.RowDefinitions>
                        <RowDefinition />
                    </Grid.RowDefinitions>
                    <Grid Background="{TemplateBinding BorderBrush}" VerticalAlignment="Top" Height="30" Margin="0 -29 0 0" d:LayoutOverrides="LeftMargin, RightMargin, TopMargin, BottomMargin">
                        <Grid.ColumnDefinitions>
                            <ColumnDefinition Width="*" />
                            <ColumnDefinition Width="135" />
                        </Grid.ColumnDefinitions>
                        <StackPanel Orientation="Horizontal">
                            <Image Source="{TemplateBinding Icon}"   Height="{x:Static SystemParameters.SmallIconHeight}" Width="{x:Static SystemParameters.SmallIconWidth}" WindowChrome.IsHitTestVisibleInChrome="True" >
                            </Image>
                            <ContentControl Foreground="{DynamicResource WindowTitleBrush}"  FontSize="{DynamicResource {x:Static SystemFonts.CaptionFontSize}}"  Content="{TemplateBinding Title}"  VerticalAlignment="Center" Margin="2,0,0,0"/>
                        </StackPanel>
    
                        <StackPanel x:Name="WindowCommandButtonsPanel" Grid.Column="1"  HorizontalAlignment="Center" Orientation="Horizontal" WindowChrome.IsHitTestVisibleInChrome="True" Margin="0,0,-1,0">
                            <Button x:Name="MinimizeButton" Style="{DynamicResource MinimizeButtonStyle}" Width="45"  Click="SystemCommands_Click"  />
                            <Grid Margin="1,0,1,0">
                                <Button x:Name="MaximizeButton" Style="{DynamicResource MaximizeButtonStyle}" Width="45"  Click="SystemCommands_Click" />
                                <Button x:Name="RestoreButton" Style ="{DynamicResource RestoreButtonStyle}" Width="45"  Click="SystemCommands_Click" Visibility="Hidden" />
                            </Grid>
                            <Button x:Name="CloseButton" Style="{DynamicResource CloseButtonStyle}" Width="45"  Click="SystemCommands_Click" />
                        </StackPanel>
                    </Grid>
    
                    <ContentPresenter Content="{TemplateBinding Content}" Grid.Column="0" Grid.ColumnSpan="1" d:LayoutOverrides="LeftMargin, RightMargin, TopMargin, BottomMargin" />
                </Grid>
            </Border>
            <ControlTemplate.Triggers>
                <Trigger Property="WindowState" Value="Maximized">
                    <Setter TargetName="RootGrid" Property="Margin" Value="6" />
                    <Setter TargetName="MaximizeButton" Property="Visibility" Value="Hidden"/>
                    <Setter TargetName="RestoreButton" Property="Visibility" Value="Visible"/>
                </Trigger>
    
                <MultiTrigger>
                    <MultiTrigger.Conditions>
                        <Condition Property="ResizeMode" Value="CanResizeWithGrip" />
                        <Condition Property="WindowState" Value="Normal" />
                    </MultiTrigger.Conditions>
                    <Setter TargetName="MaximizeButton" Property="Visibility" Value="Visible"/>
                    <Setter TargetName="RestoreButton" Property="Visibility" Value="Hidden"/>
                </MultiTrigger>
            </ControlTemplate.Triggers>
        </ControlTemplate>
    </Window.Template>

Xaml.cs

        private void SystemCommands_Click(object sender, RoutedEventArgs e)
        {
            
            Button button = sender as Button;
            switch (button.Name)
            {
                case "CloseButton":
                    Close();
                    break;
                case "MinimizeButton":
                    WindowState = WindowState.Minimized;
                    break;
                case "MaximizeButton":
                    WindowState = WindowState.Maximized;
                    break;
                case "RestoreButton":
                    WindowState = WindowState.Normal;
                    break;
            }
        }

resourceDictionary

    <SolidColorBrush x:Key="WindowBackgroundBrush" Color="White" />
    <SolidColorBrush x:Key="WindowTitleBrush" Color="Black" />
    <SolidColorBrush x:Key="SubMenuBackgroundBrush"   Color="Red"/>
    <SolidColorBrush x:Key="StatusBarBackgroundBrush" Color="#007ACC"/>


    <Style x:Key="CaptionButtonStyleDefault" TargetType="Button">
        <Setter Property="Template">
            <Setter.Value>
                <ControlTemplate TargetType="Button">
                    <Grid x:Name="LayoutRoot" Background="Transparent" Width="46" Height="30">
                        <TextBlock x:Name="txt" Text="{TemplateBinding Content}" FontFamily="Segoe MDL2 Assets" FontSize="10" 
                                   Foreground="#868688" HorizontalAlignment="Center" VerticalAlignment="Center"
                                   RenderOptions.ClearTypeHint="Auto" TextOptions.TextRenderingMode="Aliased"  TextOptions.TextFormattingMode="Display"/>
                    </Grid>
                    <ControlTemplate.Triggers>
                        <Trigger Property="IsMouseOver" Value="True">
                            <Setter TargetName="LayoutRoot" Property="Background" Value="#E5E5E5"/>
                            <Setter TargetName="txt" Property="Foreground" Value="#000000"/>
                        </Trigger>
                    </ControlTemplate.Triggers>
                </ControlTemplate>
            </Setter.Value>
        </Setter>
    </Style>
    <Style x:Key="CaptionButtonStyleClose" TargetType="Button">
        <Setter Property="Template">
            <Setter.Value>
                <ControlTemplate TargetType="Button">
                    <Grid x:Name="LayoutRoot" Background="Transparent" Width="46" Height="30">
                        <TextBlock x:Name="txt" Text="{TemplateBinding Content}" FontFamily="Segoe MDL2 Assets" FontSize="10" 
                                   Foreground="#868688" HorizontalAlignment="Center" VerticalAlignment="Center"
                                   RenderOptions.ClearTypeHint="Auto" TextOptions.TextRenderingMode="Aliased"  TextOptions.TextFormattingMode="Display"/>
                    </Grid>
                    <ControlTemplate.Triggers>
                        <Trigger Property="IsMouseOver" Value="True">
                            <Setter TargetName="LayoutRoot" Property="Background" Value="#E81123"/>
                            <Setter TargetName="txt" Property="Foreground" Value="#FFFFFF"/>
                        </Trigger>
                    </ControlTemplate.Triggers>
                </ControlTemplate>
            </Setter.Value>
        </Setter>
    </Style>
    
    <Style x:Key="MinimizeButtonStyle" TargetType="Button" BasedOn="{StaticResource CaptionButtonStyleDefault}">
        <Setter Property="Content" Value="&#xE949;"/>
    </Style>
    
    <Style x:Key="MaximizeButtonStyle" TargetType="Button" BasedOn="{StaticResource CaptionButtonStyleDefault}">
        <Setter Property="Content" Value="&#xE739;"/>
    </Style>
    
    <Style x:Key="RestoreButtonStyle" TargetType="Button" BasedOn="{StaticResource CaptionButtonStyleDefault}">
        <Setter Property="Content" Value="&#xE923;"/>
    </Style>
    
    <Style x:Key="CloseButtonStyle" TargetType="Button" BasedOn="{StaticResource CaptionButtonStyleClose}">
        <Setter Property="Content" Value="&#xE8BB;"/>
    </Style>

