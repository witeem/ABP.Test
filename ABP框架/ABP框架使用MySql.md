## ABP框架使用MySql

1. #### 移除SQL Server的Nuget包

   Entityframeworkcore.Design

   Entityframeworkcore.Sqlserver

2. #### 安装MySql的Nuget包

   Entityframeworkcore.Mysql.Design

   Entityframeworkcore.Mysql

3. #### 更改DbContextConfigurer配置文件

   EntityFrameCore层找到DbContextConfigurer文件：

   > UserSqlServer()  改成  UserMySql();

4. #### 修改数据库链接字符串

   在appsetting.json文件中修改数据库连接字符串：

   > "Default": "Server=localhost;Port=3306;Database=你的数据库名;Uid=数据库用户名;Pwd=密码;"