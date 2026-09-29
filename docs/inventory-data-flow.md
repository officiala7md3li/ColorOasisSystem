# Transaction Isolation and Inventory Balance Validation

## Rules
1. Sales deductions executed inside ReadCommitted transaction scope.
2. Automatic check prevents negative stock quantities before committing paint orders.
3. Rollback triggers if barcode lookup mismatches batch registry.