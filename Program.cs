using _5_stock;
using System;
Product CreateProduct()
{
    bool boolNum = true;
    short weight = 0;
    Console.WriteLine("Создайте новый продукт");
    Console.Write("Введите имя: ");
    string? name = Console.ReadLine();
    while(boolNum)
    {
        Console.Write("Введите вес: ");
        weight = Convert.ToInt16(Console.ReadLine());
        if (Stock.FreeSpace < weight)
            Console.WriteLine("Продукт имеет вес больше, чем доступно на складе");
        else boolNum = false;
    }
    Console.Write("Введите цену: ");
    short price = Convert.ToInt16(Console.ReadLine());
    Console.Clear();
    return new Product(name, weight, price);
}

while(true)
{
    Console.WriteLine("Меню");
    Console.WriteLine("1 - добавить продукт на склад\n2 - удалить продукт\n3 - показать список продуктов" +
        "\n4 - вывести свободное место");
    short switchNum = Convert.ToInt16(Console.ReadLine());
    switch (switchNum)
    {
        case 1: Console.Clear();
            Stock.AddProduct(CreateProduct());
            Console.Clear();
            Console.WriteLine("Продукт успешно добавлен!");
            break;
        case 2: Console.Clear();
            Console.Write("Введите индекс продукта для удаления: ");
            int index = Convert.ToInt32(Console.ReadLine());
            if (Stock.Products.Count <= index)
                Console.WriteLine("Продукта с таким индексом не существует");
            else
            {
                Stock.DeleteProduct(index);
                Console.Clear();
                Console.WriteLine("Продукт успешно удалён!");
            }
            break;
        case 3:
            Console.Clear();
            Stock.ShowProducts();
            break;
        case 4:
            Console.Clear();
            Console.WriteLine("Свободное место: " + Stock.FreeSpace);
            break;
    }
}
