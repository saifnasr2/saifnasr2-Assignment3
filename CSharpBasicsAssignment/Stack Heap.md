# Stack and Heap

## Diagram 1 — After line 1

```text
STACK                         HEAP
+------------------+         +-----------------------------+
| o1               |         | Order object               |
| address: 0x001   | ------> | OrderId = 1                |
+------------------+         | CustomerName = "Ali"       |
                             | Quantity = 0                |
                             | UnitPrice = 0               |
                             | TotalPrice = 0              |
                             | IsPaid = false              |
                             | DiscountPercent = 0         |
                             | ShippingCity = null         |
                             | Priority = '\0'             |
                             | ItemCode = 0                |
                             +-----------------------------+


## Diagram 2 — After line 2

STACK                         HEAP
+------------------+         +-----------------------------+
| o1               | ------> | Order object               |
| address: 0x001   | ------> | OrderId = 1                |
+------------------+    |    | CustomerName = "Ali"       |
| o2               | ----+    | Quantity = 0                |
| address: 0x001   |         | UnitPrice = 0               |
+------------------+         | TotalPrice = 0              |
                             | IsPaid = false              |
                             | DiscountPercent = 0         |
                             | ShippingCity = null         |
                             | Priority = '\0'             |
                             | ItemCode = 0                |
                             +-----------------------------+



## Diagram 3 — After line 3

STACK                         HEAP
+------------------+         +-----------------------------+
| o1               | ------> | Order object               |
| address: 0x001   | ------> | OrderId = 1                |
+------------------+    |    | CustomerName = "Ali"       |
| o2               | ----+    | Quantity = 0                |
| address: 0x001   |         | UnitPrice = 0               |
+------------------+         | TotalPrice = 0              |
                             | IsPaid = true               |
                             | DiscountPercent = 0         |
                             | ShippingCity = null         |
                             | Priority = '\0'             |
                             | ItemCode = 0                |
                             +-----------------------------+