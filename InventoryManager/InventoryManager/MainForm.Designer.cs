namespace InventoryManager
{
    partial class InventoryForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.grpProductList = new System.Windows.Forms.GroupBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.grpProductInfo = new System.Windows.Forms.GroupBox();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductType = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductType = new System.Windows.Forms.Label();
            this.grpStockControl = new System.Windows.Forms.GroupBox();
            this.btnDecreaseStock = new System.Windows.Forms.Button();
            this.btnIncreaseStock = new System.Windows.Forms.Button();
            this.numStockAmount = new System.Windows.Forms.NumericUpDown();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.grpFilterSort = new System.Windows.Forms.GroupBox();
            this.btnSortQuantityDesc = new System.Windows.Forms.Button();
            this.btnSortQuantity = new System.Windows.Forms.Button();
            this.btnSortName = new System.Windows.Forms.Button();
            this.btnOutOfStock = new System.Windows.Forms.Button();
            this.btnLowStock = new System.Windows.Forms.Button();
            this.grpSearch.SuspendLayout();
            this.grpProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.grpProductInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.grpStockControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStockAmount)).BeginInit();
            this.grpFilterSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(611, 116);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnShowAll);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Controls.Add(this.lblSearch);
            this.grpSearch.Location = new System.Drawing.Point(20, 20);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(1040, 80);
            this.grpSearch.TabIndex = 2;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "검색";
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(460, 28);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(100, 30);
            this.btnShowAll.TabIndex = 3;
            this.btnShowAll.Text = "전체보기";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(350, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(80, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 23);
            this.txtSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Enabled = false;
            this.lblSearch.Location = new System.Drawing.Point(20, 35);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(43, 15);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "검색어";
            // 
            // grpProductList
            // 
            this.grpProductList.Controls.Add(this.dgvProducts);
            this.grpProductList.Location = new System.Drawing.Point(20, 110);
            this.grpProductList.Name = "grpProductList";
            this.grpProductList.Size = new System.Drawing.Size(1040, 300);
            this.grpProductList.TabIndex = 3;
            this.grpProductList.TabStop = false;
            this.grpProductList.Text = "제품 목록";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(15, 25);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowTemplate.Height = 23;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(1010, 255);
            this.dgvProducts.TabIndex = 0;
            // 
            // grpProductInfo
            // 
            this.grpProductInfo.Controls.Add(this.btnDeleteProduct);
            this.grpProductInfo.Controls.Add(this.btnUpdateProduct);
            this.grpProductInfo.Controls.Add(this.btnAddProduct);
            this.grpProductInfo.Controls.Add(this.numQuantity);
            this.grpProductInfo.Controls.Add(this.txtProductName);
            this.grpProductInfo.Controls.Add(this.txtProductType);
            this.grpProductInfo.Controls.Add(this.lblQuantity);
            this.grpProductInfo.Controls.Add(this.lblProductName);
            this.grpProductInfo.Controls.Add(this.lblProductType);
            this.grpProductInfo.Location = new System.Drawing.Point(20, 425);
            this.grpProductInfo.Name = "grpProductInfo";
            this.grpProductInfo.Size = new System.Drawing.Size(500, 180);
            this.grpProductInfo.TabIndex = 4;
            this.grpProductInfo.TabStop = false;
            this.grpProductInfo.Text = "제품 정보";
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(240, 145);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteProduct.TabIndex = 8;
            this.btnDeleteProduct.Text = "삭제";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(130, 145);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(100, 30);
            this.btnUpdateProduct.TabIndex = 7;
            this.btnUpdateProduct.Text = "수정";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(20, 145);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(100, 30);
            this.btnAddProduct.TabIndex = 6;
            this.btnAddProduct.Text = "추가";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(100, 110);
            this.numQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(100, 23);
            this.numQuantity.TabIndex = 5;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(100, 70);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(250, 23);
            this.txtProductName.TabIndex = 4;
            // 
            // txtProductType
            // 
            this.txtProductType.Location = new System.Drawing.Point(100, 30);
            this.txtProductType.Name = "txtProductType";
            this.txtProductType.Size = new System.Drawing.Size(150, 23);
            this.txtProductType.TabIndex = 3;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(20, 115);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(31, 15);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "수량";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(20, 75);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(59, 15);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "제품 이름";
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Location = new System.Drawing.Point(20, 35);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(59, 15);
            this.lblProductType.TabIndex = 0;
            this.lblProductType.Text = "제품 타입";
            // 
            // grpStockControl
            // 
            this.grpStockControl.Controls.Add(this.btnDecreaseStock);
            this.grpStockControl.Controls.Add(this.btnIncreaseStock);
            this.grpStockControl.Controls.Add(this.numStockAmount);
            this.grpStockControl.Controls.Add(this.lblStockAmount);
            this.grpStockControl.Location = new System.Drawing.Point(540, 425);
            this.grpStockControl.Name = "grpStockControl";
            this.grpStockControl.Size = new System.Drawing.Size(250, 180);
            this.grpStockControl.TabIndex = 5;
            this.grpStockControl.TabStop = false;
            this.grpStockControl.Text = "재고 관리";
            // 
            // btnDecreaseStock
            // 
            this.btnDecreaseStock.Location = new System.Drawing.Point(120, 105);
            this.btnDecreaseStock.Name = "btnDecreaseStock";
            this.btnDecreaseStock.Size = new System.Drawing.Size(90, 30);
            this.btnDecreaseStock.TabIndex = 3;
            this.btnDecreaseStock.Text = "출고 -";
            this.btnDecreaseStock.UseVisualStyleBackColor = true;
            this.btnDecreaseStock.Click += new System.EventHandler(this.btnDecreaseStock_Click);
            // 
            // btnIncreaseStock
            // 
            this.btnIncreaseStock.Location = new System.Drawing.Point(20, 105);
            this.btnIncreaseStock.Name = "btnIncreaseStock";
            this.btnIncreaseStock.Size = new System.Drawing.Size(90, 30);
            this.btnIncreaseStock.TabIndex = 2;
            this.btnIncreaseStock.Text = "입고 +";
            this.btnIncreaseStock.UseVisualStyleBackColor = true;
            this.btnIncreaseStock.Click += new System.EventHandler(this.btnIncreaseStock_Click);
            // 
            // numStockAmount
            // 
            this.numStockAmount.Location = new System.Drawing.Point(20, 60);
            this.numStockAmount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numStockAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numStockAmount.Name = "numStockAmount";
            this.numStockAmount.Size = new System.Drawing.Size(120, 23);
            this.numStockAmount.TabIndex = 1;
            this.numStockAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.Location = new System.Drawing.Point(20, 35);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(59, 15);
            this.lblStockAmount.TabIndex = 0;
            this.lblStockAmount.Text = "변경 수량";
            // 
            // grpFilterSort
            // 
            this.grpFilterSort.Controls.Add(this.btnSortQuantityDesc);
            this.grpFilterSort.Controls.Add(this.btnSortQuantity);
            this.grpFilterSort.Controls.Add(this.btnSortName);
            this.grpFilterSort.Controls.Add(this.btnOutOfStock);
            this.grpFilterSort.Controls.Add(this.btnLowStock);
            this.grpFilterSort.Location = new System.Drawing.Point(810, 425);
            this.grpFilterSort.Name = "grpFilterSort";
            this.grpFilterSort.Size = new System.Drawing.Size(250, 180);
            this.grpFilterSort.TabIndex = 6;
            this.grpFilterSort.TabStop = false;
            this.grpFilterSort.Text = "조회 / 정렬";
            // 
            // btnSortQuantityDesc
            // 
            this.btnSortQuantityDesc.Location = new System.Drawing.Point(20, 120);
            this.btnSortQuantityDesc.Name = "btnSortQuantityDesc";
            this.btnSortQuantityDesc.Size = new System.Drawing.Size(190, 30);
            this.btnSortQuantityDesc.TabIndex = 4;
            this.btnSortQuantityDesc.Text = "수량 역순";
            this.btnSortQuantityDesc.UseVisualStyleBackColor = true;
            // 
            // btnSortQuantity
            // 
            this.btnSortQuantity.Location = new System.Drawing.Point(120, 75);
            this.btnSortQuantity.Name = "btnSortQuantity";
            this.btnSortQuantity.Size = new System.Drawing.Size(90, 30);
            this.btnSortQuantity.TabIndex = 3;
            this.btnSortQuantity.Text = "수량순";
            this.btnSortQuantity.UseVisualStyleBackColor = true;
            // 
            // btnSortName
            // 
            this.btnSortName.Location = new System.Drawing.Point(20, 75);
            this.btnSortName.Name = "btnSortName";
            this.btnSortName.Size = new System.Drawing.Size(90, 30);
            this.btnSortName.TabIndex = 2;
            this.btnSortName.Text = "이름순";
            this.btnSortName.UseVisualStyleBackColor = true;
            // 
            // btnOutOfStock
            // 
            this.btnOutOfStock.Location = new System.Drawing.Point(120, 30);
            this.btnOutOfStock.Name = "btnOutOfStock";
            this.btnOutOfStock.Size = new System.Drawing.Size(90, 30);
            this.btnOutOfStock.TabIndex = 1;
            this.btnOutOfStock.Text = "품절 조회";
            this.btnOutOfStock.UseVisualStyleBackColor = true;
            // 
            // btnLowStock
            // 
            this.btnLowStock.Location = new System.Drawing.Point(20, 30);
            this.btnLowStock.Name = "btnLowStock";
            this.btnLowStock.Size = new System.Drawing.Size(90, 30);
            this.btnLowStock.TabIndex = 0;
            this.btnLowStock.Text = "재고 부족";
            this.btnLowStock.UseVisualStyleBackColor = true;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 889);
            this.Controls.Add(this.grpFilterSort);
            this.Controls.Add(this.grpStockControl);
            this.Controls.Add(this.grpProductInfo);
            this.Controls.Add(this.grpProductList);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpProductList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.grpProductInfo.ResumeLayout(false);
            this.grpProductInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.grpStockControl.ResumeLayout(false);
            this.grpStockControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStockAmount)).EndInit();
            this.grpFilterSort.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.GroupBox grpProductList;
        private System.Windows.Forms.GroupBox grpProductInfo;
        private System.Windows.Forms.GroupBox grpStockControl;
        private System.Windows.Forms.GroupBox grpFilterSort;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductType;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.Button btnDecreaseStock;
        private System.Windows.Forms.Button btnIncreaseStock;
        private System.Windows.Forms.NumericUpDown numStockAmount;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.Button btnSortQuantityDesc;
        private System.Windows.Forms.Button btnSortQuantity;
        private System.Windows.Forms.Button btnSortName;
        private System.Windows.Forms.Button btnOutOfStock;
        private System.Windows.Forms.Button btnLowStock;
    }
}

