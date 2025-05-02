using Syncfusion.WinForms.DataGrid;

namespace DataGridSample
{
    public partial class Form1 : Form
    {
        OrderInfoCollection orderInfoCollection;
        public Form1()
        {
            InitializeComponent();

            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "OrderID" , HeaderText = "Order ID" });
            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "CustomerID" , HeaderText = "Customer ID" });
            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "CustomerName", Width = 150 , HeaderText = "Customer Name" });
            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "Country" , HeaderText = "Country" });
            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "ShipCity" , HeaderText = "Ship City" });
            orderInfoCollection = new OrderInfoCollection();
            sfDataGrid1.DataSource = orderInfoCollection.Orders;
        }

        private void SelectRow(object sender, EventArgs e)
        {
            var rowData = orderInfoCollection.Orders.FirstOrDefault(data => data.OrderID.ToString().ToLower() == textBox1.Text.ToLower() ||
                                                   data.CustomerID.ToString().ToLower() == textBox1.Text.ToLower() ||
                                                   data.CustomerName.ToString().ToLower() == textBox1.Text.ToLower() ||
                                                   data.ShipCity.ToString().ToLower() == textBox1.Text.ToLower() ||
                                                   data.Country.ToString().ToLower() == textBox1.Text.ToLower());

            this.sfDataGrid1.SelectedItem = rowData;
        }
    }
}
