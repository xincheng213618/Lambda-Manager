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
