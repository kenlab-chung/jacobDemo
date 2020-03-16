# jacobDemo
JACOB is a JAVA-COM Bridge that allows you to call COM Automation components from Java. It uses JNI to make native calls to the COM libraries.
本例为java调用C# com控件方法和事件。
# 环境与工具(64位开发环境)
- .net framework 4.0
- java jdk1.8.0_211
- jacob-1.19

# C# com 签名步骤：
- 打开Visual Studio Command Prompt 输入：sn -k XXX.snk 生成XXX.snk 文件
- 打开 Project-->Properties菜单  在Signing标签中选中 Sign the assembly,选择刚刚生成的强名称文件XXX.snk
- 编译程序Debug目录中会生成 XXX.dll 和XXX.tlb

# java.lang.UnsatisfiedLinkError: no jacob-1.18-x64 in java.library.path 处理办法：
- 将jacob-1.19-x64.dll 放到java安装目录下: jdk1.X.X\bin，即你的JDK安装路径下bin中。
- 将jacob-1.19-x86.dll 放到C:\Windows\System32
- 将jacob-1.19-x64.dll 放到C:\Windows\SysWOW64

# com.jacob.com.ComFailException: Can't co-create object 处理办法：
- 将C# com的目标平台设置为x64。
