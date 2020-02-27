# TabDataGridError
Repo to show WPF TabControl error with DataGrid

Steps to repro:
1. Launch program.
2. Sort the "Tab1"'s DataGrid by pressing "Value".
3. Start editing the value by double-clicking the cell with 0 in it.
4. Press the second tab "Tab2".
5. The program crashes with error "System.InvalidOperationException: ''Sorting' is not allowed during an AddNew or EditItem transaction.'"
