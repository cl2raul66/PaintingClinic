namespace PaintingClinic.Share;

public enum UserRole
{
    Unknown,
    DeliveryPerson,
    Operator,
    Supervisor,
    Administrator
}

public enum OrderStatus
{
    Unknown,
    Created,
    InProcess,
    Completed,
    Delivered
}

public enum ContactType
{
    Unknown,
    Customer,
    Supplier
}

public enum ReportType
{
    Unknown,
    // Here you can add the types of reports that supervisors and administrators can generate.
}