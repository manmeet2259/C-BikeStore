
namespace MyBikes
{
    partial class Form1
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonPrintAllBikes = new System.Windows.Forms.Button();
            this.buttonPrintMountainBikes = new System.Windows.Forms.Button();
            this.buttonPrintRoadBikes = new System.Windows.Forms.Button();
            this.listBoxBikeList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxBikeType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxSerialNo = new System.Windows.Forms.TextBox();
            this.textBoxMake = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxHeighFromGround = new System.Windows.Forms.TextBox();
            this.textBoxSeatHeight = new System.Windows.Forms.TextBox();
            this.comboBoxSuspension = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.dateTimePickerMadeDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.buttonReadData = new System.Windows.Forms.Button();
            this.buttonWriteData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.AutoSize = true;
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(24, 512);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(112, 43);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.AutoSize = true;
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(140, 512);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(130, 43);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.AutoSize = true;
            this.buttonRemove.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.Location = new System.Drawing.Point(274, 512);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(122, 43);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.AutoSize = true;
            this.buttonExit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(400, 581);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(112, 43);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonPrintAllBikes
            // 
            this.buttonPrintAllBikes.AutoSize = true;
            this.buttonPrintAllBikes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonPrintAllBikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrintAllBikes.Location = new System.Drawing.Point(24, 581);
            this.buttonPrintAllBikes.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrintAllBikes.Name = "buttonPrintAllBikes";
            this.buttonPrintAllBikes.Size = new System.Drawing.Size(112, 43);
            this.buttonPrintAllBikes.TabIndex = 5;
            this.buttonPrintAllBikes.Text = "Print All Bikes";
            this.buttonPrintAllBikes.UseVisualStyleBackColor = false;
            this.buttonPrintAllBikes.Click += new System.EventHandler(this.buttonPrintAllBikes_Click);
            // 
            // buttonPrintMountainBikes
            // 
            this.buttonPrintMountainBikes.AutoSize = true;
            this.buttonPrintMountainBikes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonPrintMountainBikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrintMountainBikes.Location = new System.Drawing.Point(140, 581);
            this.buttonPrintMountainBikes.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrintMountainBikes.Name = "buttonPrintMountainBikes";
            this.buttonPrintMountainBikes.Size = new System.Drawing.Size(130, 43);
            this.buttonPrintMountainBikes.TabIndex = 6;
            this.buttonPrintMountainBikes.Text = "Print Mountain Bikes";
            this.buttonPrintMountainBikes.UseVisualStyleBackColor = false;
            this.buttonPrintMountainBikes.Click += new System.EventHandler(this.buttonPrintMountainBikes_Click);
            // 
            // buttonPrintRoadBikes
            // 
            this.buttonPrintRoadBikes.AutoSize = true;
            this.buttonPrintRoadBikes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonPrintRoadBikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrintRoadBikes.Location = new System.Drawing.Point(274, 581);
            this.buttonPrintRoadBikes.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrintRoadBikes.Name = "buttonPrintRoadBikes";
            this.buttonPrintRoadBikes.Size = new System.Drawing.Size(122, 43);
            this.buttonPrintRoadBikes.TabIndex = 7;
            this.buttonPrintRoadBikes.Text = "Print Road Bikes";
            this.buttonPrintRoadBikes.UseVisualStyleBackColor = false;
            this.buttonPrintRoadBikes.Click += new System.EventHandler(this.buttonPrintRoadBikes_Click);
            // 
            // listBoxBikeList
            // 
            this.listBoxBikeList.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBoxBikeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxBikeList.FormattingEnabled = true;
            this.listBoxBikeList.ItemHeight = 16;
            this.listBoxBikeList.Location = new System.Drawing.Point(374, 33);
            this.listBoxBikeList.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxBikeList.Name = "listBoxBikeList";
            this.listBoxBikeList.Size = new System.Drawing.Size(649, 420);
            this.listBoxBikeList.TabIndex = 8;
            this.listBoxBikeList.SelectedIndexChanged += new System.EventHandler(this.listBoxBikeList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select Bike Type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxBikeType
            // 
            this.comboBoxBikeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBikeType.FormattingEnabled = true;
            this.comboBoxBikeType.Location = new System.Drawing.Point(176, 33);
            this.comboBoxBikeType.Name = "comboBoxBikeType";
            this.comboBoxBikeType.Size = new System.Drawing.Size(182, 24);
            this.comboBoxBikeType.TabIndex = 11;
            this.comboBoxBikeType.SelectedIndexChanged += new System.EventHandler(this.comboBoxBikeType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "Serial No.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Make";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Model";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "Color";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 30);
            this.label6.TabIndex = 10;
            this.label6.Text = "Made Date";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 30);
            this.label7.TabIndex = 10;
            this.label7.Text = "Suspension";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 30);
            this.label8.TabIndex = 10;
            this.label8.Text = "Height From Ground";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 435);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 30);
            this.label9.TabIndex = 10;
            this.label9.Text = "Seat Height";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(54, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 30);
            this.label10.TabIndex = 10;
            this.label10.Text = "Search By Serial No.";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSerialNo
            // 
            this.textBoxSerialNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSerialNo.Location = new System.Drawing.Point(176, 81);
            this.textBoxSerialNo.Name = "textBoxSerialNo";
            this.textBoxSerialNo.Size = new System.Drawing.Size(182, 23);
            this.textBoxSerialNo.TabIndex = 12;
            // 
            // textBoxMake
            // 
            this.textBoxMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMake.Location = new System.Drawing.Point(176, 127);
            this.textBoxMake.Name = "textBoxMake";
            this.textBoxMake.Size = new System.Drawing.Size(182, 23);
            this.textBoxMake.TabIndex = 12;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModel.Location = new System.Drawing.Point(176, 173);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(182, 23);
            this.textBoxModel.TabIndex = 12;
            // 
            // textBoxHeighFromGround
            // 
            this.textBoxHeighFromGround.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHeighFromGround.Location = new System.Drawing.Point(177, 391);
            this.textBoxHeighFromGround.Name = "textBoxHeighFromGround";
            this.textBoxHeighFromGround.Size = new System.Drawing.Size(182, 23);
            this.textBoxHeighFromGround.TabIndex = 12;
            // 
            // textBoxSeatHeight
            // 
            this.textBoxSeatHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSeatHeight.Location = new System.Drawing.Point(177, 436);
            this.textBoxSeatHeight.Name = "textBoxSeatHeight";
            this.textBoxSeatHeight.Size = new System.Drawing.Size(182, 23);
            this.textBoxSeatHeight.TabIndex = 12;
            // 
            // comboBoxSuspension
            // 
            this.comboBoxSuspension.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSuspension.FormattingEnabled = true;
            this.comboBoxSuspension.Location = new System.Drawing.Point(176, 347);
            this.comboBoxSuspension.Name = "comboBoxSuspension";
            this.comboBoxSuspension.Size = new System.Drawing.Size(182, 24);
            this.comboBoxSuspension.TabIndex = 11;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(20, 72);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(215, 27);
            this.textBoxSearch.TabIndex = 12;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonSearch.Location = new System.Drawing.Point(79, 111);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(112, 30);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.AutoSize = true;
            this.buttonReset.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(400, 512);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(112, 43);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(174, 214);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(182, 24);
            this.comboBoxColor.TabIndex = 11;
            // 
            // dateTimePickerMadeDate
            // 
            this.dateTimePickerMadeDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerMadeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerMadeDate.Location = new System.Drawing.Point(176, 258);
            this.dateTimePickerMadeDate.Name = "dateTimePickerMadeDate";
            this.dateTimePickerMadeDate.Size = new System.Drawing.Size(180, 23);
            this.dateTimePickerMadeDate.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 30);
            this.label11.TabIndex = 10;
            this.label11.Text = "Speed";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSpeed.Location = new System.Drawing.Point(176, 304);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(182, 23);
            this.textBoxSpeed.TabIndex = 12;
            // 
            // buttonReadData
            // 
            this.buttonReadData.AutoSize = true;
            this.buttonReadData.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonReadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReadData.Location = new System.Drawing.Point(516, 512);
            this.buttonReadData.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReadData.Name = "buttonReadData";
            this.buttonReadData.Size = new System.Drawing.Size(228, 43);
            this.buttonReadData.TabIndex = 4;
            this.buttonReadData.Text = "Read Data From FIle";
            this.buttonReadData.UseVisualStyleBackColor = false;
            this.buttonReadData.Click += new System.EventHandler(this.buttonReadData_Click);
            // 
            // buttonWriteData
            // 
            this.buttonWriteData.AutoSize = true;
            this.buttonWriteData.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonWriteData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWriteData.Location = new System.Drawing.Point(516, 581);
            this.buttonWriteData.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWriteData.Name = "buttonWriteData";
            this.buttonWriteData.Size = new System.Drawing.Size(228, 43);
            this.buttonWriteData.TabIndex = 4;
            this.buttonWriteData.Text = "Write Data to FIle";
            this.buttonWriteData.UseVisualStyleBackColor = false;
            this.buttonWriteData.Click += new System.EventHandler(this.buttonWriteData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxSearch);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(772, 482);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 155);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 661);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePickerMadeDate);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonWriteData);
            this.Controls.Add(this.buttonReadData);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPrintRoadBikes);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonPrintMountainBikes);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonPrintAllBikes);
            this.Controls.Add(this.textBoxSeatHeight);
            this.Controls.Add(this.textBoxHeighFromGround);
            this.Controls.Add(this.textBoxSpeed);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxMake);
            this.Controls.Add(this.textBoxSerialNo);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.comboBoxSuspension);
            this.Controls.Add(this.comboBoxBikeType);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxBikeList);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "My Bike Store (Manpreet Singh Khokhar, Manmeet Singh)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonPrintAllBikes;
        private System.Windows.Forms.Button buttonPrintMountainBikes;
        private System.Windows.Forms.Button buttonPrintRoadBikes;
        private System.Windows.Forms.ListBox listBoxBikeList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxBikeType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxSerialNo;
        private System.Windows.Forms.TextBox textBoxMake;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxHeighFromGround;
        private System.Windows.Forms.TextBox textBoxSeatHeight;
        private System.Windows.Forms.ComboBox comboBoxSuspension;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.DateTimePicker dateTimePickerMadeDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.Button buttonReadData;
        private System.Windows.Forms.Button buttonWriteData;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

