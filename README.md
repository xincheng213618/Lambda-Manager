# 🧰 NLG

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

## LambdaUtils

Lambda的一个依赖，没什么用

## Common

c++ 转发的核心，目前已经支持到0.8.2，需配合LambdaCore 使用

## LambdaCore

从主控中拆离出的核心转发代码，目前已经支持到0.8.2 ，需配合Common使用

## LambdaManager

在拆分完成之后，负责主窗口的部分。

## LambdaDemo

简易的调用LambdaCore的展示级的程序，在进行开发和维护LambdaManager之前，可以参考LambdaDemo。

## packages

包的一部分，为了方便编译，程序集中引用的c++的DLL的路径放在这里

## props

调用packages的属性表，可以直接在c++项目中引用

## ACE

加密代码模块

## Register、AboutMsg

无用逻辑

## Global

对主控修改的DLL，和图像区的逻辑（预备迁移），业务逻辑

## Global.Common

无其他引用项，仅C#中可以共用和复用的部分代码

## Global.Reg

对注册表的修改，因为需要管理员权限，所以暂时放在一个里面，可以提供关联文件的修改（可合并）

## ConfigObjective

采集配置，引用Global的代码

## Solution

通过继承完成的方案管理器模板，设计范式用的比较多。

## Wizard

配置的初始化，同样依赖主控，

在菜单栏中，和注册表中有所体现）

## ThemeManager

主题管理模块DLL，将会支持多种主题颜色。 目前支持 黑，白 两种主题



## ToolHash

自动配置脚本工具
