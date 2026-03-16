using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManager.Services;

namespace InventoryManager
{
    public partial class InventoryForm : Form
    {
        private ProductService productService;

        private int selectedProductId;

        private const int LOW_STOCK_THRESHOLD = 5;
        
        public InventoryForm()
        {
            InitializeComponent();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            productService = new ProductService();

            RefreshProducts();
        }
        
        private void RefreshProducts()
        {

            var products = productService.GetAllProducts();

            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.AllowUserToResizeColumns = false;
            dgvProducts.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.MultiSelect = false;
            dgvProducts.ReadOnly = true;

            dgvProducts.DataSource = null;
            dgvProducts.DataSource = products;

            if (dgvProducts.Columns.Contains("Type"))
            {
                dgvProducts.Columns["Type"].Visible = false;
            }

            if (dgvProducts.Columns["Id"] != null)
            {
                dgvProducts.Columns["Id"].Width = 50;
            }

            if (dgvProducts.Columns["Quantity"] != null)
            {
                dgvProducts.Columns["Quantity"].Width = 80;
            }

            dgvProducts.Columns["Id"].DisplayIndex = 0;
            dgvProducts.Columns["ProductType"].DisplayIndex = 1;
            dgvProducts.Columns["Name"].DisplayIndex = 2;
            dgvProducts.Columns["Quantity"].DisplayIndex = 3;

            dgvProducts.Columns["Id"].HeaderText = "ID";
            dgvProducts.Columns["ProductType"].HeaderText = "제품 타입";
            dgvProducts.Columns["Name"].HeaderText = "제품 이름";
            dgvProducts.Columns["Quantity"].HeaderText = "수량";
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvProducts.Rows[e.RowIndex];

            selectedProductId = Convert.ToInt32(row.Cells["Id"].Value);

            txtProductType.Text = row.Cells["ProductType"].Value.ToString();
            txtProductName.Text = row.Cells["Name"].Value.ToString();
            numQuantity.Value = Convert.ToInt32(row.Cells["Quantity"].Value);
        }
        
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                string type = txtProductType.Text;
                string name = txtProductName.Text;
                int quantity = (int)numQuantity.Value;

                productService.AddProduct(type, name, quantity);

                RefreshProducts();


                RefreshProducts();

                MessageBox.Show("제품이 추가 되었습니다.");
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            var result = productService.SearchProducts(keyword);

            dgvProducts.DataSource = result;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            RefreshProducts();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProducts.SelectedRows.Count == 0)
                {
                    MessageBox.Show("삭제할 제품을 선택하세요.");
                    return;
                }

                int id = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["Id"].Value);

                productService.DeleteProduct(id);

                RefreshProducts();

                MessageBox.Show("제품이 삭제되었습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProducts.SelectedRows.Count == 0)
                {
                    MessageBox.Show("수정할 제품을 선택하세요.");
                    return;
                }

                int id = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["Id"].Value);

                string type = txtProductType.Text;
                string name = txtProductName.Text;
                int quantity = int.Parse(numQuantity.Text);

                productService.UpdateProduct(id, type, name, quantity);

                RefreshProducts();

                MessageBox.Show("제품이 수정되었습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void btnIncreaseStock_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProducts.SelectedRows.Count == 0)
                {
                    MessageBox.Show("제품을 선택하세요.");
                    return;
                }

                int id = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["Id"].Value);
                int amount = (int)numStockAmount.Value;

                productService.IncreaseStock(id, amount);

                RefreshProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDecreaseStock_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProducts.SelectedRows.Count == 0)
                {
                    MessageBox.Show("제품을 선택하세요.");
                    return;
                }

                int id = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["Id"].Value);
                int amount = (int)numStockAmount.Value;
                
                productService.DecreaseStock(id, amount);

                RefreshProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLowStock_Click(object sender, EventArgs e)
        {
            try
            {
                var result = productService.GetLowStockProducts(LOW_STOCK_THRESHOLD);

                dgvProducts.DataSource = null;
                dgvProducts.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOutOfStock_Click(object sender, EventArgs e)
        {
            try
            {
                int threshold = (int)numQuantity.Value;

                var result = productService.GetOutOfStockProducts();

                dgvProducts.DataSource = null;
                dgvProducts.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSortName_Click(object sender, EventArgs e)
        {
            try
            {
                var result = productService.GetProductsSortedByName();

                dgvProducts.DataSource = null;
                dgvProducts.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSortQuantity_Click(object sender, EventArgs e)
        {
            try
            {
                var result = productService.GetProductsSortedByQuantity();

                dgvProducts.DataSource = null;
                dgvProducts.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSortQuantityDesc_Click(object sender, EventArgs e)
        {
            try
            {
                var result = productService.GetProductsSortedByQuantity();

                dgvProducts.DataSource = null;
                dgvProducts.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
