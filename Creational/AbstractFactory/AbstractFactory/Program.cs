using AF.Impl.CocaCola;
using AF.Impl.Pepsi;
using AF.Manager;

SalesManager salesManager;

salesManager = new SalesManager(new CocaColaFactory());
salesManager.RunProduction();

salesManager = new SalesManager(new PepsiFactory());
salesManager.RunProduction();
