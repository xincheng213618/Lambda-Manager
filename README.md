# 快速开始

```
git clone https://github.com/NJUST-SCIL/Lambda-Manager
```

程序编译需要的依赖环境已经打包进项目中，不需要自行配置，克隆之后，用VS2022直接运行即可。

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
