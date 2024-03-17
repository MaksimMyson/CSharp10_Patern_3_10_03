using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10_Patern_3_10_03
{
    class InventorySystem
    {
        public void UpdateInventory(int productId, int quantity)
        {
            Console.WriteLine($"Оновлено інвентар продукту {productId} на {quantity} одиниць.");
        }
    }

    class PaymentSystem
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Оброблено платіж на суму {amount} грн.");
        }
    }

    class ShippingSystem
    {
        public void ShipProduct(int productId, string address)
        {
            Console.WriteLine($"Відправлено продукт {productId} за адресою {address}.");
        }
    }

    
    class OrderFacade
    {
        private InventorySystem inventorySystem;
        private PaymentSystem paymentSystem;
        private ShippingSystem shippingSystem;

        public OrderFacade()
        {
            inventorySystem = new InventorySystem();
            paymentSystem = new PaymentSystem();
            shippingSystem = new ShippingSystem();
        }

        public void PlaceOrder(int productId, int quantity, double amount, string address)
        {
            inventorySystem.UpdateInventory(productId, quantity);
            paymentSystem.ProcessPayment(amount);
            shippingSystem.ShipProduct(productId, address);
            Console.WriteLine("Замовлення успішно оформлено!");
        }
    }
}
