
using Proxy;

IHuman operatorHuman = new Operator();
IHuman proxy = new Surrogate(operatorHuman);
proxy.Request();
