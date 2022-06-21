using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.ServiceModel.Types;

public class Albums
{
    [AutoIncrement]
    public long AlbumId { get; set; }

    [Required]
    public string Title { get; set; }

    public long ArtistId { get; set; }
}

public class Artists
{
    [AutoIncrement]
    public long ArtistId { get; set; }

    public string Name { get; set; }
}

public class Customers
{
    [AutoIncrement]
    public long CustomerId { get; set; }

    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    public string Company { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public string PostalCode { get; set; }
    public string Phone { get; set; }
    public string Fax { get; set; }
    [Required]
    public string Email { get; set; }

    public long? SupportRepId { get; set; }
}

public class Employees
{
    [AutoIncrement]
    public long EmployeeId { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required]
    public string FirstName { get; set; }

    public string Title { get; set; }
    public long? ReportsTo { get; set; }
    public DateTime? BirthDate { get; set; }
    public DateTime? HireDate { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public string PostalCode { get; set; }
    public string Phone { get; set; }
    public string Fax { get; set; }
    public string Email { get; set; }
}

public class Genres
{
    [AutoIncrement]
    public long GenreId { get; set; }

    public string Name { get; set; }
}

[Alias("invoice_items")]
public class InvoiceItems
{
    [AutoIncrement]
    public long InvoiceLineId { get; set; }

    public long InvoiceId { get; set; }
    public long TrackId { get; set; }
    public decimal UnitPrice { get; set; }
    public long Quantity { get; set; }
}

public class Invoices
{
    [AutoIncrement]
    public long InvoiceId { get; set; }

    public long CustomerId { get; set; }
    public DateTime InvoiceDate { get; set; }
    public string BillingAddress { get; set; }
    public string BillingCity { get; set; }
    public string BillingState { get; set; }
    public string BillingCountry { get; set; }
    public string BillingPostalCode { get; set; }
    public decimal Total { get; set; }
}

[Alias("media_types")]
public class MediaTypes
{
    [AutoIncrement]
    public long MediaTypeId { get; set; }

    public string Name { get; set; }
}

public class Playlists
{
    [AutoIncrement]
    public long PlaylistId { get; set; }

    public string Name { get; set; }
}

public class Tracks
{
    [AutoIncrement]
    public long TrackId { get; set; }

    [Required]
    public string Name { get; set; }

    public long? AlbumId { get; set; }
    public long MediaTypeId { get; set; }
    public long? GenreId { get; set; }
    public string Composer { get; set; }
    public long Milliseconds { get; set; }
    public long? Bytes { get; set; }
    public decimal UnitPrice { get; set; }
}

