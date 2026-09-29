# ColorOasis ERP Architecture

## Data Access Layer (DAL)
- Implements Repository pattern for business entities (`ProductRepository`, `InvoiceRepository`).
- Entity Framework DbContext handles unit of work transactions.
- Encapsulated business logic in `Services` layer to isolate presentation forms.