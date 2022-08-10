# 快速开始

```
git clone https://github.com/NJUST-SCIL/Lambda-Manager
```

程序编译需要的依赖环境已经打包进项目中，不需要自行配置

需要先将程序编译环境从AnyCPU 改成 X64 然后 Build  Lambda 目录下的LambdaManager 。



common  的环境已经内置，OpenCV 的环境需要自行编辑，并配置

之后需要将packages中的opencv 的dll copy 到debug 或者release 目录中，然后创建lib目录。

之后bulid common 项目

之后build c++ 项目

之后运行LambdaManager  即可看见初始界面

将已有的c++项目copy进来，编译，就可以进行联合调试





## LambdaManager

主控的部分代码，加上自行魔改和修复的代码，已通过兼容性测试（强签名除外）

## Common

c++ 转发的核心，主控的一部分， 存在BUG ,  仅可作为测试参考使用

## packages

包的一部分，为了方便编译，程序集中引用的c++的DLL的路径放在这里

## props

调用packages的属性表，可以直接在c++项目中引用

## Lambda

主控对于C# 预留的接口，控制逻辑从这里接入

## LambdaCore

无效代码，主控的单DLL封装测试

## Global

C# 附加DLL 的核心控制逻辑，需重构

## ConfigObjective

C# DLL  业务模块

## Solution

通用的解决方案管理器模板，未完工形态
