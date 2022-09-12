namespace HotelManagementSystem.hotel
{
    partial class Room
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridRooms = new System.Windows.Forms.DataGridView();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRoomStatus = new System.Windows.Forms.ComboBox();
            this.cmbRoomCat = new System.Windows.Forms.ComboBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.room_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room_Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(240, 321);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 35);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(137, 321);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 35);
            this.btnUpdate.TabIndex = 40;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(137, 50);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(73, 20);
            this.txtID.TabIndex = 39;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(137, 221);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(169, 20);
            this.txtPrice.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.label4.Location = new System.Drawing.Point(18, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "Room Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.label3.Location = new System.Drawing.Point(16, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Price";
            // 
            // dataGridRooms
            // 
            this.dataGridRooms.AllowUserToAddRows = false;
            this.dataGridRooms.AllowUserToDeleteRows = false;
            this.dataGridRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.room_id,
            this.Room_Category,
            this.Room_Description,
            this.category_price,
            this.Room_status});
            this.dataGridRooms.Location = new System.Drawing.Point(332, 84);
            this.dataGridRooms.Name = "dataGridRooms";
            this.dataGridRooms.ReadOnly = true;
            this.dataGridRooms.Size = new System.Drawing.Size(441, 315);
            this.dataGridRooms.TabIndex = 29;
            this.dataGridRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRooms_CellContentClick);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.Location = new System.Drawing.Point(33, 321);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(85, 35);
            this.btnSubmit.TabIndex = 28;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.label2.Location = new System.Drawing.Point(16, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Room category";
            // 
            // cmbRoomStatus
            // 
            this.cmbRoomStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomStatus.FormattingEnabled = true;
            this.cmbRoomStatus.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.cmbRoomStatus.Location = new System.Drawing.Point(137, 263);
            this.cmbRoomStatus.Name = "cmbRoomStatus";
            this.cmbRoomStatus.Size = new System.Drawing.Size(169, 21);
            this.cmbRoomStatus.TabIndex = 43;
            // 
            // cmbRoomCat
            // 
            this.cmbRoomCat.FormattingEnabled = true;
            this.cmbRoomCat.Items.AddRange(new object[] {
            "Single Room",
            "Double-Double Room",
            "Suite Room",
            "Duplex Room",
            "Penthouse Room"});
            this.cmbRoomCat.Location = new System.Drawing.Point(137, 113);
            this.cmbRoomCat.Name = "cmbRoomCat";
            this.cmbRoomCat.Size = new System.Drawing.Size(169, 21);
            this.cmbRoomCat.TabIndex = 44;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(137, 151);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(169, 58);
            this.rtbDescription.TabIndex = 45;
            this.rtbDescription.Text = "";
            // 
            // room_id
            // 
            this.room_id.DataPropertyName = "room_id";
            this.room_id.HeaderText = "ID";
            this.room_id.Name = "room_id";
            this.room_id.ReadOnly = true;
            this.room_id.Visible = false;
            // 
            // Room_Category
            // 
            this.Room_Category.DataPropertyName = "room_Category";
            this.Room_Category.HeaderText = "Room Category";
            this.Room_Category.Name = "Room_Category";
            this.Room_Category.ReadOnly = true;
            // 
            // Room_Description
            // 
            this.Room_Description.DataPropertyName = "room_Description";
            this.Room_Description.HeaderText = "Description";
            this.Room_Description.Name = "Room_Description";
            this.Room_Description.ReadOnly = true;
            // 
            // category_price
            // 
            this.category_price.DataPropertyName = "category_price";
            this.category_price.HeaderText = "Price";
            this.category_price.Name = "category_price";
            this.category_price.ReadOnly = true;
            // 
            // Room_status
            // 
            this.Room_status.DataPropertyName = "room_status";
            this.Room_status.HeaderText = "Room Status";
            this.Room_status.Name = "Room_status";
            this.Room_status.ReadOnly = true;
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = global::HotelManagementSystem.Properties.Resources.pat;
            this.ClientSize = new System.Drawing.Size(795, 485);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.cmbRoomCat);
            this.Controls.Add(this.cmbRoomStatus);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridRooms);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Room";
            this.Text = "Room";
            this.Load += new System.EventHandler(this.Guest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridRooms;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRoomStatus;
        private System.Windows.Forms.ComboBox cmbRoomCat;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room_Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn category_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room_status;
    }
}