# 快速开始

```
git clone https://github.com/NJUST-SCIL/Lambda-Manager
```



除OPENCV，CUDA,外，程序编译需要的依赖环境已经打包进项目中，不需要自行配置

需要先将程序编译环境从AnyCPU 改成 X64 然后 Build  Lambda 目录下的LambdaManager 。



#### 添加OPENCV运行环境

在props/AddPathBat/存在 ADD_OPENCV_PATH.bat 脚本，复制脚本，到提供的OPNECV 开发环境下，点击运行即可。也可以自己添加 PATH 环境到中 OPENCV_PATH，或者自行修改OpenCV.Release.x64.props 亦可。

#### 添加CUDA运行环境

如果没有CUDA运行环境，请自行官网安装CUDA开发包，否则，请移除  application.xml中配置的CUDA 关联的DLL。

之后需要将packages中的opencv 的dll copy 到debug 或者release 目录中，然后创建lib目录。

之后bulid common 项目

之后build c++ 项目

之后运行LambdaManager  即可看见初始界面

将已有的c++项目copy进来，编译，就可以进行联合调试

# 详细介绍

## Lambda

根据依赖倒置原则，预留的接口，提供一些基本处理接口

## Common

c++ 转发的核心，主控的一部分，已通过兼容性测试，无大问题

## LambdaCore

从主控中拆离出的核心转发代码，目前已经支持到0.8.0  已通过兼容性测试，无大问题，基本逻辑复现正确，少量代码无伤大雅，可以自行修改。

## LambdaManager

在拆分完成之后，负责主窗口的部分，之后其他人可以在此基础上自行开发维护。

## LambdaDemo

简易的调用LambdaCore的展示级的程序，在进行开发和维护LambdaManager之前，可以参考LambdaDemo。

## packages

包的一部分，为了方便编译，程序集中引用的c++的DLL的路径放在这里

## props

调用packages的属性表，可以直接在c++项目中引用

## ACE

加密代码模块的核心，原本和主窗口产生了耦合，在多次拆分之后，是一个单独的DLL,有部分逻辑依旧不完善，存在优化的控件

## Global

C# 附加DLL 的核心控制逻辑，需重构

## ConfigObjective

采集配置

## Solution

通过继承完成的方案管理器模板，设计范式用的比较多。

## Wizard

初始化配置界面，作为单独的程序，可以单独打开，可以依赖配置，（在菜单栏中，和注册表中有所体现）



## ThemeManager

预留的主题管理模块DLL，将会支持多种主题颜色。



## ToolHash

自动配置脚本工具
