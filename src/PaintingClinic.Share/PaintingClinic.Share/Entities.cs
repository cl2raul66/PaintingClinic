namespace PaintingClinic.Share;

public class User
{
    public string? UserID { get; set; }
    public string? Name { get; set; }
    public string? Password { get; set; }
    public string? Email { get; set; }
    public UserRole? Role { get; set; }
}

public class Contact
{
    public string? ContactID { get; set; }
    public string? Name { get; set; }
    public string? Street { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? PostalCode { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public ContactType? Type { get; set; }
}

public class Order
{
    public string? OrderID { get; set; }
    public string? ContactID { get; set; }
    public DateTime? OrderDate { get; set; }
    public DateTime? DeliveryDate { get; set; }
    public OrderStatus? OrderStatus { get; set; }
    public List<OrderDetail>? OrderDetails { get; set; }
    public decimal? TotalOrder { get; set; }
}

public class OrderDetail
{
    public string? ProductID { get; set; }
    public int? Quantity { get; set; }
    public decimal? UnitPrice { get; set; }
}

public class Product
{
    public string? ProductID { get; set; }
    public string? ProductName { get; set; }
    public string? ProductDescription { get; set; }
    public decimal? ProductPrice { get; set; }
    public int? InventoryQuantity { get; set; }
}

public class Income
{
    public string? IncomeID { get; set; }
    public string? OrderID { get; set; }
    public string? UserID { get; set; }
    public DateTime? IncomeDate { get; set; }
    public decimal? IncomeAmount { get; set; }
    public string? IncomeDescription { get; set; }
}

public class Expense
{
    public string? ExpenseID { get; set; }
    public string? UserID { get; set; }
    public DateTime? ExpenseDate { get; set; }
    public decimal? ExpenseAmount { get; set; }
    public string? ExpenseDescription { get; set; }
}

public class Report
{
    public string? ReportID { get; set; }
    public string? UserID { get; set; }
    public DateTime? ReportDate { get; set; }
    public ReportType? ReportType { get; set; }
    public string? ReportData { get; set; }
}

#region NotificationCenter
public class CustomNotification
{    
    public string? Title { get; set; }
    public string? Text { get; set; }
    public TypeNotification Type { get; set; }
    public int Priority { get; set; }
    public TimeSpan Duration { get; set; }
    public DateTime Date { get; set; }
}
#endregion