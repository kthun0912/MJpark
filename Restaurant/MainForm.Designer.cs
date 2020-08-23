namespace Restaurant
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_purchasePrice = new System.Windows.Forms.TextBox();
            this.tb_salePrice = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lv_MainVew = new System.Windows.Forms.ListView();
            this.col_productNmae = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_puchasePrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_salePrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_VAT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_netProfit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_num = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.col_Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.col_SumPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(701, 515);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "매입가";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(701, 578);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "판매가";
            // 
            // tb_purchasePrice
            // 
            this.tb_purchasePrice.Location = new System.Drawing.Point(701, 535);
            this.tb_purchasePrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_purchasePrice.Name = "tb_purchasePrice";
            this.tb_purchasePrice.Size = new System.Drawing.Size(114, 25);
            this.tb_purchasePrice.TabIndex = 2;
            // 
            // tb_salePrice
            // 
            this.tb_salePrice.Location = new System.Drawing.Point(701, 596);
            this.tb_salePrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_salePrice.Name = "tb_salePrice";
            this.tb_salePrice.Size = new System.Drawing.Size(114, 25);
            this.tb_salePrice.TabIndex = 3;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(778, 658);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(86, 29);
            this.btn_Delete.TabIndex = 6;
            this.btn_Delete.Text = "삭제";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(686, 658);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(86, 29);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.Text = "등록";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lv_MainVew
            // 
            this.lv_MainVew.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_No,
            this.col_productNmae,
            this.col_Count,
            this.col_puchasePrice,
            this.col_salePrice,
            this.col_VAT,
            this.col_netProfit,
            this.col_SumPrice});
            this.lv_MainVew.Dock = System.Windows.Forms.DockStyle.Left;
            this.lv_MainVew.FullRowSelect = true;
            this.lv_MainVew.GridLines = true;
            this.lv_MainVew.Location = new System.Drawing.Point(0, 0);
            this.lv_MainVew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lv_MainVew.Name = "lv_MainVew";
            this.lv_MainVew.Size = new System.Drawing.Size(678, 701);
            this.lv_MainVew.TabIndex = 8;
            this.lv_MainVew.UseCompatibleStateImageBehavior = false;
            this.lv_MainVew.View = System.Windows.Forms.View.Details;
            // 
            // col_productNmae
            // 
            this.col_productNmae.Text = "품명";
            // 
            // col_puchasePrice
            // 
            this.col_puchasePrice.Text = "매입가";
            // 
            // col_salePrice
            // 
            this.col_salePrice.Text = "판매가";
            // 
            // col_VAT
            // 
            this.col_VAT.Text = "부가세";
            // 
            // col_netProfit
            // 
            this.col_netProfit.Text = "순이익";
            // 
            // col_No
            // 
            this.col_No.Text = "No";
            // 
            // tb_num
            // 
            this.tb_num.Location = new System.Drawing.Point(701, 474);
            this.tb_num.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_num.Name = "tb_num";
            this.tb_num.Size = new System.Drawing.Size(114, 25);
            this.tb_num.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(701, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "수량";
            // 
            // col_Count
            // 
            this.col_Count.Text = "수량";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(701, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "품명";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(701, 413);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(114, 25);
            this.tb_Name.TabIndex = 0;
            // 
            // col_SumPrice
            // 
            this.col_SumPrice.Text = "합계";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 701);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_num);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lv_MainVew);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.tb_salePrice);
            this.Controls.Add(this.tb_purchasePrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "박민재";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_purchasePrice;
        private System.Windows.Forms.TextBox tb_salePrice;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ListView lv_MainVew;
        private System.Windows.Forms.ColumnHeader col_productNmae;
        private System.Windows.Forms.ColumnHeader col_puchasePrice;
        private System.Windows.Forms.ColumnHeader col_salePrice;
        private System.Windows.Forms.ColumnHeader col_VAT;
        private System.Windows.Forms.ColumnHeader col_netProfit;
        private System.Windows.Forms.TextBox tb_num;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader col_No;
        private System.Windows.Forms.ColumnHeader col_Count;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.ColumnHeader col_SumPrice;
    }
}

