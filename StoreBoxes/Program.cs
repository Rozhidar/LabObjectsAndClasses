string data = string.Empty;

List<Box> boxes = new List<Box>();

while ((data = Console.ReadLine()) != "end")
{
    string[] inputData = data.Split();

    int serialNumber = int.Parse(inputData[0]);
    string itemName = inputData[1];
    int itemQuantity = int.Parse(inputData[2]);
    decimal itemPrice = decimal.Parse(inputData[3]);

    decimal oneBoxPrice = CalculateOneBoxPrice(itemQuantity, itemPrice);

    Box box = new Box();

    box.serialNumber = serialNumber;
    box.itemQuantity = itemQuantity;
    box.itemPrice = itemPrice;

    box.item.name = itemName;
    box.item.price = oneBoxPrice;

    boxes.Add(box);
}

foreach (Box box in boxes.OrderByDescending(b => b.item.price))
{
    Console.WriteLine($"{box.serialNumber}");
    Console.WriteLine($"-- {box.item.name} - ${box.itemPrice:F2}: {box.itemQuantity}");
    Console.WriteLine($"-- ${box.item.price:F2}");
}

static decimal CalculateOneBoxPrice(int itemQuantity, decimal itemPrice)
{
    return itemPrice * itemQuantity;
}

public class Item
{
    public string name { get; set; }
    public decimal price { get; set; }
}

public class Box
{
    public Box()
    {
        item = new Item();
    }
    public int serialNumber { get; set; }
    public Item item { get; set; }
    public int itemQuantity { get; set; }
    public decimal itemPrice { get; set; }
}



