var log = NLog.LogManager.GetCurrentClassLogger();
log.Warn("Enter option in integer only.");
Console.WriteLine("Enter the required JSON to know : \n1.Inventoy Management system\n2.Stock Account Management");
int option = Convert.ToInt32(Console.ReadLine());
switch (option)
{
    case 1:
        log.Info("JSON : Inventory Management System");
        Object_Oriented_Programming.grains_json_main json = new Object_Oriented_Programming.grains_json_main();
        json.conversion(@"C:\Users\Lenovo\source\repos\Bridgelabz\object_Oriented_Programs\Object_Oriented_Programming\Inventory_Details.json");
        break;
    case 2:
        log.Info("JSON : Stock Account Management");
        Object_Oriented_Programming.Stock_PortFolio_main stock = new Object_Oriented_Programming.Stock_PortFolio_main();
        stock.conversion(@"C:\Users\Lenovo\source\repos\Bridgelabz\object_Oriented_Programs\Object_Oriented_Programming\PortFolio.json");
        break;
    default:
        Console.WriteLine("Invalid option");
        break;
}