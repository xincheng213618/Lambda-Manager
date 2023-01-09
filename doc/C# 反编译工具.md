# C# 反编译工具

最近两天重新研究了一下反编译的技巧，整理一下。

## ILSpy

 https://github.com/icsharpcode/ILSpy

使用方式有两种，直接下载源文件，或者是安装VS插件，从插件处打开，因为实时更新所以支持最新的语法，缺点是只能看到源码，不支持加密等。复杂项目中拿到源码并不能够直接使用，而是需要手动重建项目。

## DNSpy

https://github.com/dnSpy/dnSpy

更新时间2020.8 

除了对新版语法糖的不支持之外，其他的效果还是可以的。可以作为重建的备选方案。

## de4dot

https://github.com/search?q=de4dot

更新时间2020.8 

可以对NET脱壳和反混淆

有一定效果。

## SimpleAssemblyExplorer

https://github.com/wickyhu/simple-assembly-explorer

更新时间 2015.5

可以对NET 进行字符串

## [dotPeek](https://www.jetbrains.com/zh-cn/decompiler/)



## ExtremeDumper

https://github.com/wwh1004/ExtremeDumper

.NET程序集Dump工具

能够反编译在内存中的代码。

拿出来的跑不了，只能用于分析逻辑。

## IDA pro

可以在程序加载之前进行断点调试，有些代码是程序加载之后破坏的，只需要断点卡在加载加密进程之前，就可以反编译拿到源码。





## Dotfuscator

非加密式重命名，直接修改了Metadata，可以拿到代码中的逻辑信息，和一些无法修改的变量名称，但是大部分的代码中的名字都被改掉了。

PE头中的Method表，被抹掉了。

### DOTFUSCATOR Professional 

 ![评价指数 2](https://static.52pojie.cn/static/image/common/recommend_1.gif) [[复制链接\]](https://www.52pojie.cn/thread-1240810-1-1.html)

**SETUP+CRACK**
**https://pan.baidu.com/s/12sGSW3ZbBjt4z_9lxQDDqw**
**提取码: n7kj**

测试，得到的结果相同，还原比较费劲。