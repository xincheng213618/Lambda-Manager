# 🧰NLG

# 快速开始

```
git clone https://github.com/NJUST-SCIL/Lambda-Manager
```

除OPENCV，CUDA外，程序编译需要的依赖环境已经打包进项目中，不需要自行配置

需要先将程序编译环境从AnyCPU 改成 X64 然后 Build  Lambda 目录下的LambdaManager 。

#### 添加CUDA运行环境

如果没有CUDA运行环境，请自行官网安装CUDA开发包，否则，编译时请移除  application.xml中配置的CUDA 关联的DLL。

#### 添加OPENCV运行环境

在props/AddPathBat/存在 ADD_OPENCV_PATH.bat 脚本，复制脚本，到提供的OPNECV 开发环境下，点击运行即可。也可以自己添加 PATH 环境到中 OPENCV_PATH，或者自行修改OpenCV.Release.x64.props 亦可。

## 编译

之后需要将packages中的opencv 的dll copy 到debug 或者release 目录中，然后创建lib目录。

之后bulid common 项目

之后build c++ 项目

之后运行LambdaManager  即可看见初始界面

将已有的c++项目copy进来，编译，就可以进行联合调试

# 详细介绍

## Lambda

主控的一些接口

## LambdaUtils

Lambda的json解析的辅助类，可以合并在Lambda中

## LambdaCore、Common

串联在C++ 和C# 的交互逻辑

## LambdaManager

程序的主体部分。

## packages

包管理

## props

调用packages的属性表

## ACE

加密代码模块

## Register、AboutMsg



## Global

对主控修改的DLL，业务逻辑，拒绝拆分的代码

## Global.Common

无其他引用项，仅C#中可以共用和复用的部分代码

## Global.Setting

和皇黄交涉失败下的产物

## Global.SettingUp

控制逻辑中控的部分

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

## HotKey

封装的热键工具

