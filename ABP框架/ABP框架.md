## ABP框架

- 学习博客：https://www.cnblogs.com/mienreal/p/4528470.html

- ABP是一个**开源**且文档友好的**应用程序框架**
- 提供了一个基于**领域驱动设计(DDD)**的结构模型



### ABP框架涉及到的内容：

- 依赖注入：这个部分使用 Castle windsor （依赖注入容器）来实现依赖注入，这个也是我们经常使用IOC来处理的方式；
- Repository仓储模式：已实现了Entity Framework、NHibernate、MangoDB、内存数据库等，仓储模式可以快速实现对数据接口的调用；
- 身份认证和授权管理：可以使用声明特性的方式对用户是否登录，或者接口的权限进行验证，可以通过一个很细粒度的方式，对各个接口的调用权限进行设置；
- 数据有效性验证：ABP自动对接口的输入参数对象进行非空判断，并且可以根据属性的申请信息对属性的有效性进行校验；
- 审计日志记录：记录每个接口的调用记录，以及对记录的创建、修改、删除人员进行记录等处理；
- UnitOfWork工作单元：为应用层和仓储层的方法自动实现数据库事务，默认所有应用服务层的接口，都是以工作单元方式运行，即使它们调用了不同的存储对象处理，都是处于一个事务的逻辑里面；
- AutoMap自动映射：通过使用AutoMaper来实现域对象和DTO对象的属性映射，可以隔离两者的逻辑关系，但是又能轻松实现属性信息的赋值；
- 动态WebAPI层：可以把Application Service 直接发布为Web API层，而不需要在累赘的为每个业务对象手工创建一个Web API的控制器，非常方便；



### ABP 框架的项目结构:

- Application应用层：应用层提供一些应用服务（Application Services）方法供展现层调用。接收一个DTO作为输入参数，使用这个参数执行特定的领域层操作并返回另一个DTO。
- Core领域核心层：领域层就是业务层，是一个项目的核心，所有业务规则都应该在领域层实现。除了定义所需的领域实体类外，可以自定义仓储对象，以及定义自己的业务逻辑层和基于AutoMap映射规则的内容。
- EF Core实体框架核心层：不需要改太多的内容，只需要在DbContext里面加入对应领域对象的仓储对象。
- Migrator数据迁移层：基于DB First，创建项目的初始化数据库。
- Web.Host WebAPI的宿主层：动态发布WebAPI的核心内容，整合了Swagger方便对WebAPI接口的调试。
- Tests 单元测试层：提供应用层的模拟测试。