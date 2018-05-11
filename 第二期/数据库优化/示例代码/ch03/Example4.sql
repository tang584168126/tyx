/*
 *Example4
 *T-SQL的全局变量
 */

use MySchool182

--最后一个插入的标识列
PRINT @@IDENTITY

--本地服务器名称
PRINT @@SERVERNAME

--SQL Server版本信息
PRINT @@VERSION