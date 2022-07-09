Object_Oriented_Programming.grains_json_main json = new Object_Oriented_Programming.grains_json_main();
var log = NLog.LogManager.GetCurrentClassLogger();
log.Info("Inventory Management Program has started");
json.conversion(@"C:\Users\Lenovo\source\repos\Bridgelabz\object_Oriented_Programs\Object_Oriented_Programming\Inventory_Details.json");
