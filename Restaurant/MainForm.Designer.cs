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
            this.tb_productName = new System.Windows.Forms.ListView();
            this.col_productNmae = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_puchasePrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_salePrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_VAT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_netProfit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.col_No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(598, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "매입가";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(598, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "판매가";
            // 
            // tb_purchasePrice
            // 
            this.tb_purchasePrice.Location = new System.Drawing.Point(613, 432);
            this.tb_purchasePrice.Name = "tb_purchasePrice";
            this.tb_purchasePrice.Size = new System.Drawing.Size(100, 21);
            this.tb_purchasePrice.TabIndex = 4;
            // 
            // tb_salePrice
            // 
            this.tb_salePrice.Location = new System.Drawing.Point(613, 477);
            this.tb_salePrice.Name = "tb_salePrice";
            this.tb_salePrice.Size = new System.Drawing.Size(100, 21);
            this.tb_salePrice.TabIndex = 5;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(681, 526);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 6;
            this.btn_Delete.Text = "삭제";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(600, 526);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.Text = "등록";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // tb_productName
            // 
            this.tb_productName.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_productNmae,
            this.col_puchasePrice,
            this.col_salePrice,
            this.col_VAT,
            this.col_netProfit,
            this.col_No});
            this.tb_productName.Dock = System.Windows.Forms.DockStyle.Left;
            this.tb_productName.FullRowSelect = true;
            this.tb_productName.GridLines = true;
            this.tb_productName.Location = new System.Drawing.Point(0, 0);
            this.tb_productName.Name = "tb_productName";
            this.tb_productName.Size = new System.Drawing.Size(594, 561);
            this.tb_productName.TabIndex = 8;
            this.tb_productName.UseCompatibleStateImageBehavior = false;
            this.tb_productName.View = System.Windows.Forms.View.Details;
            // 
            // col_productNmae
            // 
            this.col_productNmae.DisplayIndex = 1;
            this.col_productNmae.Text = "품명";
            // 
            // col_puchasePrice
            // 
            this.col_puchasePrice.DisplayIndex = 2;
            this.col_puchasePrice.Text = "매입가";
            // 
            // col_salePrice
            // 
            this.col_salePrice.DisplayIndex = 3;
            this.col_salePrice.Text = "판매가";
            // 
            // col_VAT
            // 
            this.col_VAT.DisplayIndex = 4;
            this.col_VAT.Text = "부가세";
            // 
            // col_netProfit
            // 
            this.col_netProfit.DisplayIndex = 5;
            this.col_netProfit.Text = "순이익";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(613, 393);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "품명";
            // 
            // col_No
            // 
            this.col_No.DisplayIndex = 0;
            this.col_No.Text = "No";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_productName);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.tb_salePrice);
            this.Controls.Add(this.tb_purchasePrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "박민재";
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
        private System.Windows.Forms.ListView tb_productName;
        private System.Windows.Forms.ColumnHeader col_productNmae;
        private System.Windows.Forms.ColumnHeader col_puchasePrice;
        private System.Windows.Forms.ColumnHeader col_salePrice;
        private System.Windows.Forms.ColumnHeader col_VAT;
        private System.Windows.Forms.ColumnHeader col_netProfit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader col_No;
    }
}

