# 多线程 作业

---

清华大学电子系科协软件部 2022 暑期培训作业

---

## 题目及要求

现在有一个消费者，一个生产者。消费者生产一个蛋糕，消费者消费一个蛋糕。初始时没有蛋糕。两个线程开始的时间不确定。

要求：保证消费者消费蛋糕时，生产者已经把蛋糕生产好了。

修改`MultiThreading/hw1/hw1/Program.cs`指定部分的代码，允许添加字段或者属性或者方法，使程序满足要求。

## 使用工具

### VS 2022

作业的 C# 程序运行在.NET 6平台上，建议使用Visual Studio 2022进行编写。

使用 Visual Studio 2022直接打开`MultiThreading/hw1/hw1.sln`进行编写。

### VScode

也可以使用 VScode，使用 VScode 请保证你的计算机上有.NET 6 环境。

使用 VScode 直接修改`MultiThreading/hw1/hw1/Program.cs`即可。若要检验结果是否正确，可以使用命令启动`Program.cs`程序

`dotnet run --project MultiThreading/hw1/hw1`

或直接用我们写好的测试程序进行测试

`dotnet test MultiThreading/hw1/hw1.sln`

## 提交方式

提供两种提交方式：

1. GitHub 提交
   - fork 仓库： [TCL606/MultiThreading: 2022 THU EESAST 软件部暑期培训 (github.com)](https://github.com/TCL606/MultiThreading) 到个人仓库，按要求修改好后，从个人仓库提pr到原本的仓库。
2. 邮箱提交
   - 只允许修改`MultiThreading/hw1/hw1/Program.cs`代码，修改好后，将`MultiThreading`整个文件夹打包成常见压缩格式（如`.rar`、`.zip`等），并命名为：`多线程_姓名_班级` （如：`多线程_小明_无19`）发送到邮箱 **tcl606_thu@163.com**。

