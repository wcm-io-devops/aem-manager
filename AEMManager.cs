// Add proper synchronization and data binding reset for DataTable to prevent index corruption on resolution changes.

public class AEMManager
{
    private readonly object _lock = new object();

    public void UpdateDataTableOnResolutionChange(DataTable dataTable)
    {
        // Synchronize access to the DataTable
        lock (_lock)
        {
            // Reset data binding
            dataTable.Clear();
            // Rebind data after changing resolution
            BindDataTable(dataTable);
        }
    }

    private void BindDataTable(DataTable dataTable)
    {
        // Your logic to bind the DataTable
    }
}