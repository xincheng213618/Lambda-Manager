# TODO:

- 重构注册模块
- 自动化构建和测试环境
- C++和C#的协同开发测试
- 样式和语言

# CHANGELOAG:

## [1.4.5] 2023-01-10

- 重构 RecentFile ✔  并添加菜单项
- 添加LICENSE ，并修改ReadMe文档✔
- Fix PhaseAlgorithm.dll 日志需要管理员权限的问题 ✔
- 添加MessageBox的消息支持 ✔

## [1.4.4] 2023-01-09
- 修改公司名为 Zircon ,软件名为Grid, 用Lambda 框架开发 ✔ 
- 重构ACE代码，使之存贮位置唯一  ✔


## [1.4.3] 2023-01-06

- 添加MessageBox DontShowAgain 选项  ✔ 
- Solution Button 添加点击效果 ✔ 
- NewCreatWindow 重构 ，样式调整 ✔ 

## [1.4.2] 2023-01-04

- 添加注册模块后台    Python ✔ 
- Fix  Solution 在删除时为空的bug ✔ 

## [1.4.1] 2023-01-01

- 调整样式模块，添加对control的控制，✔ 
- 添加 样式HandyControl，以及对应的封装控制✔ 

## [1.3.20] 2022-12-27

- Fix MessageBox1 渲染会有缺失的问题 ✔ 
- 对配置页面的结构做一个调整 ✔ 
- 对Solution进行微调，使得结构更完整 ✔ 
- 注册模块重构 ✔ 

## [1.3.19] 2022-12-19

- Fix 工程名称，不能正确排序的问题  ✔  StrCmpLogicalW    Shlwapi.dll
- 调整初始化文件的结构  ✔
- 添加lua和相关测试 ✔

## [1.3.18] 2022-12-16

- 重构代码，MVVM 改用_  而不是小写，调整ViewModeBase代码结构✔
- 解决enum ToString 序列化的问题 ✔
- 重构，注册表写入的逻辑，以及封装基于ViewModeBase 的ViewModelReg ✔

## [1.3.17] 2022-12-13

- 合并皇黄代码 ✔
- Merge Lambda Manager 0.8.7  ✔
- Solution，菜单悬浮  ✔
- 向导和校准的代码  ✔
- 向导关闭修改，直接关闭，强行关闭，正常关闭  ✔
- Fix 获取显卡内存物理的数据向下取整的错误 ✔
- 更改校准的默认参数从C++里执行 ✔

## [1.3.16] 2022-12-08

- 调整主题和BaseWindow ，添加透明质感，和可穿透，以及在win7和 win10和win11的不同情况✔
- 修改Setting的样式和相关代码，调整代码逻辑✔

## [1.3.15] 2022-12-05

- 硬件参数回显在设备中  ✔
- 对BaseWindow  Close 事件进行重构，提供即使在Alt +F4情况下，也可以在窗口关闭事件之前进行一段操作 ✔
- 调整 校准窗口的函数封装，和配置页面的相关布局 ✔
- 使用代码生成器，生成代码  ✔
- 代码生成器写的不好，造成了内存泄漏和崩溃，还原  ✔

## [1.3.14] 2022-11-30

- Fix   MessageBox1 多线程情况下 SAT报错  ✔
- Refactor  Global.SettingUp  ✔
- Add  CameraStatus 等硬件状态信息，并在主界面添加相对应的提示 ✔
- Wizard -> DLL✔
- RecentFile ->Global.Common✔
- Grid 启动器样式修改✔
- 工具栏状态附加测试 ✔  https://stackoverflow.com/questions/8398000/how-to-set-itemspaneltemplate-to-a-dynamically-created-grid-in-code-behind

## [1.3.13] 2022-11-24

- Global.Setting ->Global.SettingUp ✔
- Fix Dispatch Remove 造成的，Dictionary 多线程异常抛出✔
- 初始化✔
- 硬件连接 ,添加C++测试实例✔
- Helper ->Win32✔
- 移除工程配置中的硬件部分，独立出来✔
- 添加CUDA检测✔

## [1.3.12] 2022-11-21

- 调整黑白样式的相关代码✔
- 调整文件结构✔  Global.common ->Global.setting✔
- Remove  projectfile  kinds limit✔
- 添加打开系统文件，添加打开属性文件夹✔
- 代码去耦合✔
- 调整页面代码✔
- 添加热键支持✔

## [1.3.11] 2022-11-18

- 重构 GetAncestor  ->  BaseObjectExtensions  ,并且泛型化✔
- 导出模块的一些小的BUG修改与重构✔
- 添加重构 RemoveAll -> ObservableCollectionExtension✔
- Fix merge huanghuang 引起的BUG ✔
- 拆分Global✔
- 重构图标✔

## [1.3.10] 2022-11-15

- merge huanghuang  独立窗口模块✔
- 修改导出模块✔
- 调整独立的grif代码✔

## [1.3.9] -2022-11-10

- 修复因为调整BaseWindow结构引起的最大化坐标被覆盖的BUG ✔
- 调整导出模块的代码位置 ✔
- 根据 Generation of All-in-focus Images by Noise-robust Selective Fusion of Limited Depth-of-field Images ，调整Fusion 算法 sth 13->11   ✔

## [1.3.8] -2022-11-8

- 对导出模块的重构✔

- 调整BaseWindow的结构和相关补充✔

  https://www.cnblogs.com/dino623/p/CustomWindowStyle.html?spm=a2c6h.12873639.article-detail.6.64ff2fa4FJC0lK

## [1.3.7] -2022-11-2

- 分离Global  ✔

## [1.3.6] -2022-11-1

- 调整Solution的文件封装，样式分离✔
- 添加图标✔

## [1.3.5] -2022-10-31

- 移除LambdaDemo✔

- 添加Denoise✔

- 合并皇黄代码使得样式为新版✔
- 修改ProjecFile种类为反射✔

## [1.3.4] -2022-10-24

- 修改Solution使其支持自定义格式，添加GridIcon64 ✔
- 添加Cuda测试 ✔
- 添加算法工程 ✔

## [1.3.3] - 2022-10-20

- 自定义文件格式封装，重构成为独立项目，提供 静态编译lib 和include ，对头文件的格式进行了调整✔
- 添加头文件信息，C# 对C++ 的联合读取 ✔
- 调整工程的格式和结构✔
- 调整自定义的MessageBox1 格式为输出适用✔

## [1.3.2] - 2022-10-17

- 添加C++工程LFOCM ,里面的内容为去年全息和沈茜调试的相关代码，速度大概比纯C慢了一些在2s（1.25s）左右。测试多线程加速情况，生产-消费模型✔
- 添加C++ 工程 CacheFileTest，将硬盘作为缓存文件的读写测试，效果等同于手动malloc。✔
- 对自定义文件数据的相关合并测试，以及期相关代码✔
- 解决C#的样式覆盖问题，Slider✔
- 解决管道的相关事情（等同于在内存中写文件）测试Base64编码和非Base64编码的情况✔
- OpenGL 的相关适宜 ✔
- 调整文件夹结构，并修改一部分相对地址为程序目录下 ✔

## [1.3.1] - 2022-10-09

- 保存数据持久化✔

## [1.3] - 2022-10-08

- 代码结构调整与优化✔
- 对工程的重构，使其支持复杂的模式调度✔

## [1.2.3] - 2022-10-05

- 添加从沈德同的文件读取测试操作，并增加相关测试用例✔

- 自定义文件读取，重新组织Demo✔

- 自定义文件格式的确认，结构体+MatData ✔

- 自定义文件的压缩测试✔

  https://blog.csdn.net/chenlycly/article/details/40477755

  https://stackoverflow.com/questions/21186535/compressing-decompressing-char-array-using-zlib-some-characters-missing

- 添加Copy 刘娜的OpenGL的测试代码，解决内存泄露问题，遗留多线程问题✔

## [1.2.2] - 2022-09-30

- 解决C# string 中文指针传入到C++ 中乱码的问题✔  https://blog.csdn.net/lpy369369/article/details/84849532
- 通过级联配置Process的代码✔  
-  Fix  textblock 的样式被隐式覆盖 ✔  https://social.msdn.microsoft.com/Forums/vstudio/en-US/f36c8a4b-0072-4a78-871e-b7fe800507ce/textbloxk-style-override-label-style-in-wpf?forum=wpf

## [1.2.1] - 2022-09-25

- 为主控添加级联支持，和测试，同时支持沈德同的DLL和自己的测试DLL 加载。并封装成压缩包进行测试，使之同时支持不同的DLL✔

## [1.1.10] - 2022-09-23

- 迁移工程中的的配置信息✔

- 调整updowncontrol✔

- 移除ListViewItem 中 RelativeSource AncestorType={x:Type ItemsControl}，引起的警告✔

- 解决WPF绘制矢量图形模糊的问题✔

  http://www.codebaoku.com/it-csharp/it-csharp-253237.html

## [1.1.9] - 2022-09-19

- 简化项目，调整生成文件夹目录层级结构，优化C#和C++引用配置的位置目录，调整相关代码✔
- 还原测试自带的ICcamera项目，添加新的UITest项目✔
- 添加Dump 配置，和提交dmup文件设置
- 修改hotkey 的写法✔


## [1.1.8] - 2022-09-16

- 对 LambdaCore 轻微改造，用以适应更多的可能性✔
- 移除 原本用于多点采集Z 的 WindowMsg ✔
- 修复一个MUL_SUMMARY_UPDATE , json 初始值位null 时，引起的C++ 异常错误✔
- 修复工程发送初始化指令在界面加载之前，软件初始化启动之后。✔
- 添加 辅助方法 ToASCII()，并添加静态扩展，并修改其他支持✔
- LambdaCore Action ->Actions ✔

## [1.1.7] - 2022-09-14

- 调整皇黄的代码，使其不报编译警告✔

## [1.1.6] - 2022-09-13

- Merge 皇黄代码✔
- 样式部分的加载，移动到ThemeManage 中✔
- fix  因为工具栏引起的切换问题✔
- 修改配置加载的部分，位正确的位置✔
- 兼容主控的静态样式加载✔

## [1.1.5] - 2022-09-12

- 修改注册表启动软件的逻辑，不使用重启Explorer 这么老旧的方式✔

  http://woshub.com/how-to-rebuild-corrupted-icon-cache-in-windows-10/

- 添加测试Demo，并尝试代码覆盖

## [1.1.4] - 2022-09-09

- Json 传参序列化Demo ✔

## [1.1.3] - 2022-09-08

- 修改WaitControl MessageBox ✔
- 修正Json✔

## [1.1.2] - 2022-09-07 

- 多种样式
- 性能计数器的Error✔

## [1.1.1] - 2022-09-04

- 修改Grid中启动位置为安装目录✔
- 修改Grid 可以通过命令行加载✔
- 添加Global.Reg项目，支持直接从工程加载项目✔
-  HSV  MAX 240 ->100 ,TreeView  样式调整✔
- 添加 对 Config 配置的支持 ✔

## [1.1.0] - 2022-09-02

- 对Solution中的命令部分的代码微调，并添加一个弹窗提示✔
- TextTrimming 中M需要的空间比其他的大，所以单独的M会显示省略号✔
- 修改ViewMode 为OperatingMode✔
- 增加SolidColorBrushConverter 保存Json 信息，修复 莱茵状态的存储✔

## [1.0.14] - 2022-08-31

- MessageBox 添加 MessageBoxImage 和Owner✔
- 重构ACE 注册的部分，和ToolHash✔
- Merge 皇黄代码✔
- 移除Style 中默认的Trim✔

## [1.0.13] - 2022-08-30

- 添加MessageBox 对于 MessageBoxButton 的支持 ✔
- 插件测试✔
- 学习添加一个VS插件✔
- 修改ToolHash✔

## [1.0.12] - 2022-08-29

- 样式迁移到Theme 中，然后修改menu 样式✔
- 修改主窗口的因为hotfix改动的加载逻辑✔
- 重构MessageBox1的底层逻辑，并将之移入Common,同时Global.Common 添加Theme作为子项目  ✔
- 添加一个Solution切换事件  ✔
- 调整主窗口的部分界面buttomview的界面逻辑  ✔

## [1.0.11] - 2022-08-28

- 修复Slider 样式 和ListView 样式✔
- 将Soulution 中的样式移入ThemeManager✔
- Textblock 样式添加超出显示省略号✔

## [1.0.10] - 2022-08-26

- 添加LamDemo热重载✔
- 添加主控对于C#控件热加载的支持✔
- 通过配置后处理事件，移除生成后的deps.json✔
- Fix 新建工程中选择文件位置的关联✔
- Fix 默认工程解析不正确的问题✔

## [1.0.9] - 2022-08-24

- 单例使用复合分配，添加一个字典的扩展，同时修改Global.Common的文件结构✔
- 修改初次读取，Reg 读取异常的问题 ✔
- 添加Grid 和Soulution 的关联✔ 在选择工程中   
- 添加历史记录的清除接口✔ 
- 添加初始化Grid 的json 文件✔ 

## [1.0.8] - 2022-08-24

- 降低Soultion 选中时高亮颜色,更改界面顺序.调整导出窗口✔
- 新建工程时，没有正确加载配置的问题✔
-  Fix 工程在打开时，初始化值没有正确传递的问题✔
- 更新Grid 启动页面✔
- MessageBox  样式调整

## [1.0.7] - 2022-08-23

- 更新设计文档✔
- 合并皇黄代码✔
- 将日志文件等更新到代码中来✔

## [1.0.6] - 2022-08-22

- 更新主窗口的界面样式✔
- 合并NLG工程中样式部分✔
- 优化 ViewGrid 写法，提供一个示例，并对外暴漏接口可以自行实现✔
- 添加工程的新建文件窗口✔

## [1.0.5] - 2022-08-20

- 更新主控版本到0.8.2 ✔
- schedule API support end event callback as last parameter ✔
- support update frame by rect ✔

## [1.0.4] - 2022-08-19

- Fix  Job 一次执行 和Times 设置错误的问题✔
- Fix Solution 颜色不准确的问题✔
- 调整图标样式✔
- 主窗口显示需要后置，在沈茜的电脑上会出现DLL 第二次无法加载的情况，原因未知, 调整了主窗口加载的顺序✔

## [1.0.3] - 2022-08-18

- 对于Global的重命名  
- 修复Common 对于json* 指针的传递 ✔
- 修复Common 对于Log1 的中文异常情况 ✔
- 修复主窗口状态栏的BUG ✔
- 修复Solution 打开的问题 ✔
- 强签名密匙位置改为相对位置  ✔
- 修改更新日志为倒序 ✔

## [1.0.2] - 2022-08-17

- 修改图片按钮的样式的样式，并更新图片  ✔
- 在沈茜的电脑上，会存在C++ DLL 无法加载的情况 ✔
- 增加主窗口对XML 解析的异常提示 ✔

## [1.0.1] - 2022-08-16

- 解决ListView在选中的时候，会出现浮动的白色横条的问题 ✔
- 解决强签名的兼容性问题 ✔  
- 添加更新日志文档 ✔
- Fix 除了 Global的代码的警告问题 ✔
- 合并皇黄代码到 08-16 ✔
- 移除Solution 对Global 的依赖，将依赖关系转移到对于Global.Common 上 ✔

## [1.0.0] - 2022-08-15

- 一些检查数据的延迟初始化。如内存使用情况等  ✔
- 在保证兼容性的情况下，对代码进行调整，如一些接口细节和兼容性，让兼容性看起来更好  ✔
- 纯黑帧的情况下，后台控制了传入帧率   ✔（30ms, 可以修改，等待后续情况）
- 开发文档修订 ✔

## [0.8.1] - 2022-08-10

- 添加LambdaDemo✔

## [0.8.0] - 2022-08-05

- 修改Common 中，多通道显示会崩溃的问题 ✔
- 移除掉多余的代码 ✔
- LamdaDemo ✔
